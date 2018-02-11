using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fritz.Services;
using System.Net;

namespace Fritz.Test
{
    [TestClass]
    public class DectHandsetTests
    {
        private FritzBox _fb = null;

        [TestInitialize]
        public void Initialize()
        {
            var userName = Environment.GetEnvironmentVariable("FritzBoxUserName");
            var password = Environment.GetEnvironmentVariable("FritzBoxPassword");

            _fb = new FritzBox { UserName = userName, Password = password };
        }

        [TestMethod]
        public void TestGetDectHandsetList()
        {
            var service = new Contact(_fb.Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: _fb.UserName, password: _fb.Password);

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
