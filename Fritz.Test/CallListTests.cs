using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using Fritz;

namespace FritzTR064.Test
{
    [TestClass]
    public class CallListTests
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
        public void TestDownloadCallList()
        {
            var service = new Contact(Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: UserName, password: Password);

            ushort onTelNumberOfEntries;
            service.GetNumberOfEntries(out onTelNumberOfEntries);

            string callListUrl;
            service.GetCallList(out callListUrl);

            var client = new WebClient();
            client.DownloadFile(callListUrl, "calllist.xml");
        }
    }
}
