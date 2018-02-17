using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using Fritz.Services;

namespace Fritz.Test
{
    [TestClass]
    public class CallListTests
    {
        private FritzClient _fb = null;

        [TestInitialize]
        public void Initialize()
        {
            var userName = Environment.GetEnvironmentVariable("FritzBoxUserName");
            var password = Environment.GetEnvironmentVariable("FritzBoxPassword");

            _fb = new FritzClient { UserName = userName, Password = password };
        }

        [TestMethod]
        public void TestDownloadCallList()
        {
            var service = new Contact(_fb.Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: _fb.UserName, password: _fb.Password);

            ushort onTelNumberOfEntries;
            service.GetNumberOfEntries(out onTelNumberOfEntries);

            string callListUrl;
            service.GetCallList(out callListUrl);

            var client = new WebClient();
            client.DownloadFile(callListUrl, "calllist.xml");
        }
    }
}
