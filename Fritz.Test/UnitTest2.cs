using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fritz;
using System.Net;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Fritz.Test
{
    [TestClass]
    public class UnitTest2
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

        public void GetSecurityPort()
        {            
            var deviceInfo = new Deviceinfo(Url);
            ushort SecurityPort;
            deviceInfo.GetSecurityPort(out SecurityPort);
            this.SecurityPort = SecurityPort;
        }

        [TestMethod]
        public void TestGetExternalIpAddress()
        {            
            Wanpppconn1 service = new Wanpppconn1(Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: UserName, password: Password);
            string ip;
            service.GetExternalIPAddress(out ip);
        }

        [TestMethod]
        public void TestTamGetInfo()
        {
            Tam service = new Tam(Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: UserName, password: Password);

            ushort index = 0; 
            bool enable;
            string name;
            bool tamRunning;
            ushort stick;
            ushort status;

            service.GetInfo(index, out enable, out name, out tamRunning, out stick, out status);
        }

        [TestMethod]
        public void TestGetTamMessageList()
        {
            Tam service = new Tam(Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: UserName, password: Password);
            string url;
            service.GetMessageList(3, out url); 
        }

        [TestMethod]
        public void TestMyFritzGetInfo()
        {
            var myFritz = new Myfritz(Url);

            myFritz.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: UserName, password: Password);

            bool Enabled;
            bool DeviceRegistered;
            string DynDNSName;
            string Port;

            myFritz.GetInfo(out Enabled, out DeviceRegistered, out DynDNSName, out Port);
        }

        public string Load(string url)
        {
            var uri = new Uri(url);
            var request = WebRequest.Create(uri) as HttpWebRequest;
            var response = request.GetResponse() as HttpWebResponse;
            var reader = new StreamReader(response.GetResponseStream());
            var result = reader.ReadToEnd();
            return result;
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
        public void TestDeserializePhonebook()
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

            Uri uri = new Uri(phonebookUrl);

            var factory = new XmlSerializerFactory();
            var ser = factory.CreateSerializer(typeof(Fritz.Model.phonebooks));
            var request = (HttpWebRequest)WebRequest.Create(uri);
            var response = (HttpWebResponse)request.GetResponse();
            var responseStream = response.GetResponseStream();
            Fritz.Model.phonebooks doc = (Fritz.Model.phonebooks)ser.Deserialize(responseStream);
            responseStream.Close();

            Assert.IsNotNull(doc);

            Console.WriteLine(doc.phonebook.name);
            foreach (Fritz.Model.phonebooksPhonebookContact contact in doc.phonebook.contact)
            {
                Console.WriteLine($"{contact.uniqueid}\t{contact.person.realName}\t{contact.telephony.number.Value}");
            }
        }

        [TestMethod]
        public void TestContact()
        {
            var service = new Contact(Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: UserName, password: Password);

            ushort onTelNumberOfEntries;
            service.GetNumberOfEntries(out onTelNumberOfEntries);

            string callListUrl;
            service.GetCallList(out callListUrl);

            var client = new WebClient();
            client.DownloadFile(callListUrl, "calllist.xml");

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

        [TestMethod]
        public void TestGetDectHandsetList()
        {
            var service = new Contact(Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: UserName, password: Password);

            string dectIDList;
            service.GetDECTHandsetList(out dectIDList);

            var dectIds = dectIDList.Split(',');
            foreach(var id in dectIds)
            { 
                string handsetName;
                ushort phonebookID;
                service.GetDECTHandsetInfo((ushort)Convert.ToInt32(id), out handsetName, out phonebookID);
            }
        }
        
        [TestMethod]
        public void TestDeviceConfigRebootFritzBox()
        {
            Deviceconfig service = new Deviceconfig(Url);
            service.Reboot(); 
        }
    }
}
