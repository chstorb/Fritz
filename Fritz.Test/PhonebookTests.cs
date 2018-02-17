using Fritz.Serialization;
using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fritz.Services;
using System.Net;

namespace Fritz.Test
{
    [TestClass]
    public class PhonebookTests
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
        public void TestAddPhonebook()
        {
            _fb.AddPhonebook(name: "Test Phonebook");            
        }

        [TestMethod]
        public void TestDeletePhonebook()
        {
            _fb.DeletePhonebook(name: "Test Phonebook");
        }

        [TestMethod]
        public void TestWritePhonebookXml()
        {
            _fb.WritePhonebookXml(name: "Test Phonebook", folder: TestContext.TestDeploymentDir);
        }

        [TestMethod]
        public void TestWritePhonebookCsv()
        {
            _fb.WritePhonebookCsv(name: "Test Phonebook", folder: TestContext.TestDeploymentDir);
        }

        [TestMethod]
        public void TestGetPhonebook()
        {
            phonebooksPhonebook phonebook = _fb.GetPhonebook("Telefonbuch");

            Assert.IsNotNull(phonebook);

            Console.WriteLine(phonebook.name);
            foreach (phonebooksPhonebookContact contact in phonebook.contact)
            {
                Console.WriteLine($"{contact.uniqueid}\t{contact.person[0].realName}\t{contact.telephony[0].number[0].Value}");
            }
        }

        [TestMethod]
        public void TestGetPhonebookEntry()
        {
            var service = new Contact(_fb.Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: _fb.UserName, password: _fb.Password);

            UInt16 phonebookId = 0;
            UInt16 phonebookEntryID = 0;
            string phonebookEntryData;
            service.GetPhonebookEntry(phonebookId, phonebookEntryID, out phonebookEntryData);
        }

        [TestMethod]
        public void TestSetPhonebookEntry()
        {
            var service = new Contact(_fb.Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: _fb.UserName, password: _fb.Password);

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

        #region TestContext

        private TestContext _testContext;

        /// <summary>
        /// Gets or sets the test context which provides
        /// information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return _testContext;
            }
            set
            {
                _testContext = value;
            }
        }

        #endregion
    }
}
