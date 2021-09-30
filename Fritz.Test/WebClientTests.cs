using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
using System.Text;

namespace Fritz.Test
{
    [TestClass]
    public class WebClientTest
    {
        private string UserName { get; set; }
        private string Password { get; set; }
        private string Url { get; set; }
        private string SecurityPort { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            UserName = Environment.GetEnvironmentVariable("FritzBoxUserName");
            Password = Environment.GetEnvironmentVariable("FritzBoxPassword");

            DisableServerCertificateValidation();

            Url = $"http://fritz.box:{49000}";

            SecurityPort = GetSecurityPort();

            Url = $"https://fritz.box:{SecurityPort}";
        }

        private void DisableServerCertificateValidation()
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
        }

        private string GetSecurityPort()
        {
            var client = new WebClient()
            {
                Encoding = Encoding.UTF8
            };
            client.Headers["Content-Type"] = "text/xml; charset=\"utf-8\"";
            client.Headers["SOAPACTION"] = "urn:dslforum-org:service:DeviceInfo:1#GetSecurityPort";

            var data = "<?xml version=\"1.0\"?>"
                      + "<s:Envelope xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope/\" "
                      + "s:encodingStyle=\"http://schemas.xmlsoap.org/soap/encoding/\">"
                      + "<s:Body>"
                      + "<u:GetSecurityPort xmlns:u=\"urn:dslforum-org:service:DeviceInfo:1\">"
                      + "</u:GetSecurityPort>"
                      + "</s:Body>"
                      + "</s:Envelope>";

            var address = $"{this.Url}/upnp/control/deviceinfo";

            var reply = client.UploadString(address, data);

            var document = XDocument.Parse(reply);
            var query = from item in document.Descendants("NewSecurityPort")
                        select item;
            var securityPort = query.FirstOrDefault().Value;

            return securityPort;
        }

        [Ignore]
        [TestMethod]
        public void TestGetExternalIpAddress()
        {
            var client = new WebClient()
            {
                Encoding = Encoding.UTF8,
                Credentials = new NetworkCredential(UserName, Password)
            };
            client.Headers["Content-Type"] = "text/xml; charset=\"utf-8\"";
            client.Headers["SOAPACTION"] = "urn:dslforum-org:service:WANPPPConnection:1#GetExternalIPAddress";

            var data = "<?xml version=\"1.0\"?>"
                    + "<s:Envelope xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope\" "
                    + "s:encodingStyle=\"http://schemas.xmlsoap.org/soap/encoding/\">"
                    + "<s:Body>"
                    + "<u:GetExternalIPAddress xmlns:u=\"urn:dslforum-org:service:WANPPPConnection:1\">"
                    + "</u:GetExternalIPAddress>"
                    + "</s:Body>"
                    + "</s:Envelope>";

            var securityPort = GetSecurityPort();
            var address = string.Format("https://fritz.box:{0}/upnp/control/wanpppconn1", securityPort);
            var reply = client.UploadString(address, data);
        }

        [Ignore]
        [TestMethod]
        public void TestForceTermination()
        {
            var securityPort = GetSecurityPort();

            var client = new WebClient()
            {
                Encoding = Encoding.UTF8,
                Credentials = new NetworkCredential(UserName, Password)
            };
            client.Headers["Content-Type"] = "text/xml; charset=\"utf-8\"";
            client.Headers["SOAPACTION"] = "urn:schemas-upnp-org:service:WANIPConnection:1#ForceTermination";

            var data = "<?xml version=\"1.0\" encoding=\"utf-8\"?>"
                        + "<s:Envelope xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope/\" "
                        + "s:encodingStyle=\"http://schemas.xmlsoap.org/soap/encoding/\">"
                        + "<s:Body>"
                        + "<u:ForceTermination xmlns:u=\"urn:schemas-upnp-org:service:WANIPConnection:1\"/>"
                        + "</s:Body>"
                        + "</s:Envelope>";

            var address = $"{Url}/upnp/control/WANIPConn1";

            var reply = client.UploadString(address, data);
        }

        [TestMethod]
        public void TestGetDeviceLog()
        {
            var client = new WebClient()
            {
                Encoding = Encoding.UTF8,
                Credentials = new NetworkCredential(UserName, Password)
            };
            client.Headers["Content-Type"] = "text/xml; charset=\"utf-8\"";
            client.Headers["SOAPACTION"] = "urn:dslforum-org:service:DeviceInfo:1#GetDeviceLog";

            var data = "<?xml version=\"1.0\"?>"
                      + "<s:Envelope xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope/\" "
                      + "s:encodingStyle=\"http://schemas.xmlsoap.org/soap/encoding/\">"
                      + "<s:Body>"
                      + "<u:GetDeviceLog xmlns:u=\"urn:dslforum-org:service:DeviceInfo:1\">"
                      + "</u:GetDeviceLog>"
                      + "</s:Body>"
                      + "</s:Envelope>";

            var address = "http://fritz.box:49000/upnp/control/deviceinfo";

            var reply = client.UploadString(address, data);
            Console.WriteLine(reply);
        }

        [TestMethod]
        public void TestGetPhoneBook()
        {
            var client = new WebClient()
            {
                Encoding = Encoding.UTF8,
                Credentials = new NetworkCredential(UserName, Password)
            };
            client.Headers["Content-Type"] = "text/xml; charset=\"utf-8\"";
            client.Headers["SOAPACTION"] = "urn:dslforum-org:service:X_AVM-DE_OnTel:1#GetPhoneBook";

            var data = "<?xml version=\"1.0\"?>"
                    + "<s:Envelope xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope/\" "
                    + "s:encodingStyle=\"http://schemas.xmlsoap.org/soap/encoding/\">"
                    + "<s:Body>"
                    + "<u:GetPhoneBook xmlns:u=\"urn:dslforum-org:service:X_AVM-DE_OnTel:1\">"
                    + "<NewPhonebookID>0</NewPhonebookID>"
                    + "</u:GetPhoneBook>"
                    + "</s:Body>"
                    + "</s:Envelope>";

            var securityPort = GetSecurityPort();
            var address = $"{Url}/upnp/control/x_contact";
            var reply = client.UploadString(address, data);

            var document = XDocument.Parse(reply);
            var query = from item in document.Descendants("NewPhonebookURL")
                        select item;
            var phonebookUrl = query.FirstOrDefault().Value;

            client.Headers.Clear();
            client.DownloadFile(phonebookUrl, "pbook.xml");
        }

        [TestMethod]
        public void TestReboot()
        {
            var client = new WebClient()
            {
                Encoding = Encoding.UTF8,
                Credentials = new NetworkCredential(UserName, Password)
            };
            client.Headers["Content-Type"] = "text/xml; charset=\"utf-8\"";
            client.Headers["SOAPACTION"] = "urn:dslforum-org:service:DeviceConfig:1#Reboot";

            var data = "<?xml version=\"1.0\"?>"
                      + "<s:Envelope xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope/\" "
                      + "s:encodingStyle=\"http://schemas.xmlsoap.org/soap/encoding/\">"
                      + "<s:Body>"
                      + "<u:Reboot xmlns:u=\"urn:dslforum-org:service:DeviceConfig:1\">"
                      + "</u:Reboot>"
                      + "</s:Body>"
                      + "</s:Envelope>";

            var address = $"{Url}/upnp/control/deviceconfig";

            var reply = client.UploadString(address, data);
        }

        [Ignore]
        [TestMethod]
        public void TestComplete()
        {
            var w = new WebClient()
            {
                Encoding = System.Text.Encoding.UTF8
            };
            w.Headers["Content-Type"] = "text/xml; charset=\"utf-8\"";
            w.Headers["SOAPACTION"] = "urn:dslforum-org:service:DeviceInfo:1#GetSecurityPort";

            var query = "<?xml version=\"1.0\"?>"
                      + "<s:Envelope xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope/\" "
                      + "s:encodingStyle=\"http://schemas.xmlsoap.org/soap/encoding/\">"
                      + "<s:Body>"
                      + "<u:GetSecurityPort xmlns:u=\"urn:dslforum-org:service:DeviceInfo:1\">"
                      + "</u:GetSecurityPort>"
                      + "</s:Body>"
                      + "</s:Envelope>";
           

            var reply = w.UploadString("http://fritz.box:49000/upnp/control/deviceinfo", query);
           
            var document = XDocument.Parse(reply);
            var data = from item in document.Descendants("NewSecurityPort")
                       select item;
            var port = data.FirstOrDefault().Value;

            w.Headers["Content-Type"] = "text/xml; charset=\"utf-8\"";
            w.Headers["SOAPACTION"] = "urn:dslforum-org:service:WANPPPConnection:1#GetExternalIPAddress";

            query = "<?xml version=\"1.0\"?>"
                    + "<s:Envelope xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope\" "
                    + "s:encodingStyle=\"http://schemas.xmlsoap.org/soap/encoding/\">"
                    + "<s:Body>"
                    + "<u:GetExternalIPAddress xmlns:u=\"urn:dslforum-org:service:WANPPPConnection:1\">"
                    + "</u:GetExternalIPAddress>"
                    + "</s:Body>"
                    + "</s:Envelope>";
            
            w.Credentials = new NetworkCredential(UserName, Password);

            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

            reply = w.UploadString($"https://fritz.box:{port}/upnp/control/wanpppconn1", query);

            var newExternalIpAddress = string.Empty;

            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(reply);
            var elemList = xmlDocument.GetElementsByTagName("NewExternalIPAddress");
            foreach (XmlNode item in elemList)
            {
                newExternalIpAddress = item.InnerXml;
                break;
            }

            w.Headers["Content-Type"] = "text/xml; charset=\"utf-8\"";
            w.Headers["SOAPACTION"] = "urn:dslforum-org:service:X_AVM-DE_OnTel:1#GetPhoneBook";

            query = "<?xml version=\"1.0\"?>"
                    + "<s:Envelope xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope/\" "
                    + "s:encodingStyle=\"http://schemas.xmlsoap.org/soap/encoding/\">"
                    + "<s:Body>"
                    + "<u:GetPhoneBook xmlns:u=\"urn:dslforum-org:service:X_AVM-DE_OnTel:1\">"
                    + "<NewPhonebookID>0</NewPhonebookID>"
                    + "</u:GetPhoneBook>"
                    + "</s:Body>"
                    + "</s:Envelope>";

            reply = w.UploadString($"https://fritz.box:{port}/upnp/control/x_contact", query);

            var url = string.Empty;

            xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(reply);
            elemList = xmlDocument.GetElementsByTagName("NewPhonebookURL");
            foreach (XmlNode item in elemList)
            {
                url = item.InnerXml;
            }

            w.Headers.Clear();

            w.DownloadFile(url, "pbook.xml");
        }
    }
}