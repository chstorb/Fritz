using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fritz;
using System.Net;

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

        [TestMethod]
        public void TestContact()
        {
            var service = new Contact(Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: UserName, password: Password);

            ushort onTelNumberOfEntries;
            service.GetNumberOfEntries(out onTelNumberOfEntries);

            string phonebookList;
            service.GetPhonebookList(out phonebookList);

            ushort phonebookId = 0;
            string phonebookName;
            string phonebookExtraID;
            string PhonebookURL;
            service.GetPhonebook(phonebookId, out phonebookName, out phonebookExtraID, out PhonebookURL);

            uint phonebookEntryID = 0;
            string phonebookEntryData;
            service.GetPhonebookEntry(phonebookId, phonebookEntryID, out phonebookEntryData);

            // Add new entries with "" as value for PhonebookEntryID.Change existing entries with a value used for 
            // PhonebookEntryID with GetPhonebookEntry.The variable PhonebookEntryData may contain a unique ID.
            phonebookEntryID = 0;
            phonebookEntryData = "<?xml version=\"1.0\" encoding=\"utf-8\"?>"
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

            string callListUrl;
            service.GetCallList(out callListUrl);
        }

        [TestMethod]
        public void TestDeviceConfigRebootFritzBox()
        {
            Deviceconfig service = new Deviceconfig(Url);
            service.Reboot(); 
        }
    }
}
