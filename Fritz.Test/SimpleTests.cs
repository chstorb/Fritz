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
        private FritzClientBase _fb = null;

        [TestInitialize]
        public void Initialize()
        {
            var userName = Environment.GetEnvironmentVariable("FritzBoxUserName");
            var password = Environment.GetEnvironmentVariable("FritzBoxPassword");

            _fb = new FritzClient { UserName = userName, Password = password };
        }

        [TestMethod]
        public void TestGetExternalIpAddress()
        {            
            Wanpppconn1 service = new Wanpppconn1(_fb.Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: _fb.UserName, password: _fb.Password);
            string ip;
            service.GetExternalIPAddress(out ip);
        }

        [TestMethod]
        public void TestTamGetInfo()
        {
            Tam service = new Tam(_fb.Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: _fb.UserName, password: _fb.Password);

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
            Tam service = new Tam(_fb.Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: _fb.UserName, password: _fb.Password);
            string url;
            service.GetMessageList(3, out url); 
        }

        [TestMethod]
        public void TestMyFritzGetInfo()
        {
            var myFritz = new Myfritz(_fb.Url);

            myFritz.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: _fb.UserName, password: _fb.Password);

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
            _fb.Reboot();
        }
    }
}
