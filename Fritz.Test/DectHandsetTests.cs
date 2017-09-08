using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fritz;
using System.Net;

namespace FritzTR064.Test
{
    [TestClass]
    public class DectHandsetTests
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
        public void TestGetDectHandsetList()
        {
            var service = new Contact(Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: UserName, password: Password);

            string dectIDList;
            service.GetDECTHandsetList(out dectIDList);

            var dectIds = dectIDList.Split(',');
            foreach (var id in dectIds)
            {
                string handsetName;
                ushort phonebookID;
                service.GetDECTHandsetInfo((ushort)Convert.ToInt32(id), out handsetName, out phonebookID);

                Console.WriteLine($"{handsetName}\t{phonebookID}");
            }
        }
    }
}
