using System;
using System.Net;
using System.Security.Cryptography;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.IO;

namespace Fritz.Test
{
    /// <summary>
    /// Beispiel-Code für den Bezug einer Session-ID ab FRITZ!OS 5.50 
    /// </summary>
    [TestClass]
    public class SessionIdTests
    {
        private string UserName { get; set; }
        private string Password { get; set; }
        private string Url { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            UserName = Environment.GetEnvironmentVariable("FritzBoxUserName");
            Password = Environment.GetEnvironmentVariable("FritzBoxPassword");
        }

        [TestMethod]
        public void TestSessionId()
        {
            // SessionID ermitteln  
            string sid = GetSessionId(UserName, Password);
            string seite = SeiteEinlesen(@"http://fritz.box/home/home.lua", sid);
            Console.WriteLine(seite);
        }

        public string SeiteEinlesen(string url, string sid)
        {
            Uri uri = new Uri(url + "?sid=" + sid);
            HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string str = reader.ReadToEnd();
            return str;
        }

        public string GetSessionId(string benutzername, string kennwort)
        {
            XDocument doc = XDocument.Load(@"http://fritz.box/login_sid.lua");
            string sid = GetValue(doc, "SID");
            if (sid == "0000000000000000")
            {
                string challenge = GetValue(doc, "Challenge");
                string uri = @"http://fritz.box/login_sid.lua?username=" + benutzername + @"&response=" + GetResponse(challenge, kennwort);
                doc = XDocument.Load(uri); sid = GetValue(doc, "SID");
            }
            return sid;
        }
        
        public string GetResponse(string challenge, string kennwort)
        {
            return challenge + "-" + GetMD5Hash(challenge + "-" + kennwort);
        }

        public string GetMD5Hash(string input)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Unicode.GetBytes(input));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }
            return sb.ToString();
        }

        public string GetValue(XDocument doc, string name)
        {
            XElement info = doc.FirstNode as XElement;
            return info.Element(name).Value;
        }
    }
}
