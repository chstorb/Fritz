using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fritz.Services;
using Fritz.Serialization;
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

        private void GetSecurityPort()
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
        public void TestDeviceConfigRebootFritzBox()
        {
            Deviceconfig service = new Deviceconfig(Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: UserName, password: Password);
            service.Reboot(); 
        }
    }
}
