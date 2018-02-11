using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fritz.Services;
using System.Net;
using System.Xml.Linq;
using Fritz.Serialization;

namespace FritzTR064.Test
{
    [TestClass]
    public class PhonebookTests
    {
        private string UserName { get; set; }
        private string Password { get; set; }
        private string Url { get; set; }
        private ushort SecurityPort { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            UserName = Environment.GetEnvironmentVariable("FritzBoxUserName");
            Password = Environment.GetEnvironmentVariable("FritzBoxPassword");

            DisableServerCertificateValidation();

            Url = $"http://fritz.box:{49000}";

            GetSecurityPort();

            Url = $"https://fritz.box:{this.SecurityPort}";
        }

        private void DisableServerCertificateValidation()
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
        }

        private void GetSecurityPort()
        {
            var deviceInfo = new Deviceinfo(Url);
            ushort SecurityPort;
            deviceInfo.GetSecurityPort(out SecurityPort);
            this.SecurityPort = SecurityPort;
        }

        [TestMethod]
        public void TestPhonebook()
        {
            var service = new Contact(Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: UserName, password: Password);

            string phonebookList;
            service.GetPhonebookList(out phonebookList);

            var phonebookExtraID = Guid.NewGuid().ToString();
            var phonebookName = "Temporary Phonebook";
            service.AddPhonebook(phonebookExtraID, phonebookName);

            service.GetPhonebookList(out phonebookList);

            var phonebookIds = phonebookList.Split(',')
                .Select(id => Convert.ToUInt16(id));

            foreach (var phonebookId in phonebookIds)
            {
                string phonebookURL;
                service.GetPhonebook(phonebookId, out phonebookName, out phonebookExtraID, out phonebookURL);

                Console.WriteLine($"{phonebookId}\t{phonebookName}\t{phonebookExtraID}\t{phonebookURL}\r\n");

                var doc = XDocument.Load(phonebookURL);
                var s = doc.Document.ToString();
                Console.WriteLine(s);
            }
        }

        [TestMethod]
        public void TestDeserializePhonebookXml()
        {
            var service = new Contact(Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: UserName, password: Password);

            string phonebookList;
            service.GetPhonebookList(out phonebookList);

            var phonebookId = Convert.ToUInt16(phonebookList.Split(',').FirstOrDefault() ?? "0");

            string phonebookName;
            string phonebookExtraId;
            string phonebookUrl;

            service.GetPhonebook(phonebookId, out phonebookName, out phonebookExtraId, out phonebookUrl);
            Console.WriteLine($"{phonebookId}\t{phonebookName}\t{phonebookExtraId}\t{phonebookUrl}\r\n");

            phonebooks pbooks = FritzSerializer.DeserializePhonebookXml(phonebookUrl);

            Assert.IsNotNull(pbooks);

            Console.WriteLine(pbooks.Items[0].name);
            foreach (phonebooksPhonebookContact contact in pbooks.Items[0].contact)
            {
                Console.WriteLine($"{contact.uniqueid}\t{contact.person[0].realName}\t{contact.telephony[0].number[0].Value}");
            }
        }

        [TestMethod]
        public void TestGetPhonebookEntry()
        {
            var service = new Contact(Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: UserName, password: Password);

            UInt16 phonebookId = 0;
            UInt16 phonebookEntryID = 0;
            string phonebookEntryData;
            service.GetPhonebookEntry(phonebookId, phonebookEntryID, out phonebookEntryData);
        }

        [TestMethod]
        public void TestSetPhonebookEntry()
        {
            var service = new Contact(Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: UserName, password: Password);

            ushort phonebookId = 0;

            // Add new entries with "" as value for PhonebookEntryID.Change existing entries with a value used for 
            // PhonebookEntryID with GetPhonebookEntry.The variable PhonebookEntryData may contain a unique ID.
            uint phonebookEntryID = 0;
            string phonebookEntryData = "<?xml version=\"1.0\" encoding=\"utf-8\"?>"
                + "<contact>"
                + "<category/>"
                + "<person>"
                + "<realName>Mustermann, Marianne</realName>"
                + "</person>"
                + "<telephony nid=\"1\">"
                + "<number type=\"home\" id=\"0\" vanity=\"\" prio=\"1\">0123456789</number>"
                + "</telephony>"
                + "<services/>"
                + "<setup>"
                + "<ringTone/>"
                + "</setup>"
                + "<mod_time>1487852657</mod_time>"
                + "<uniqueid></uniqueid>"
                + "</contact>";

            service.SetPhonebookEntry(phonebookId, phonebookEntryID, phonebookEntryData);
        }
    }
}
