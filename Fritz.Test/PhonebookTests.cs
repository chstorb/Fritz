using Fritz.Serialization;
using System;
using System.Linq;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fritz.Services;
using System.Net;
using System.Collections.Generic;
using System.IO;

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

            ushort phonebookId = 0;
            uint phonebookEntryID = 0;
            service.GetPhonebookEntry(phonebookId, phonebookEntryID, out string phonebookEntryData);

            Console.WriteLine(phonebookEntryData);
        }

        [TestMethod]
        public void TestAddOrUpdatePhonebookEntry()
        {
            _fb.AddOrUpdatePhonebookEntry(phonebookId: 0, uniqueId: 319, name: "Mustermann, Marianne", number: "+49 1234 55555", numberType: NumberType.Home);
        }

        [TestMethod]
        public void TestImportPhonebookEntriesFromCsv()
        {
            var fileName = @"Telefonbuch.csv";

            var list = FritzUtility.ReadCsvFile(fileName);

            ushort phonebookId = 0;

            foreach (var item in list)
            {
                uint phonebookEntryID = 0;

                if (!Enum.TryParse<NumberType>(item.Item5, out NumberType nmbrType)) nmbrType = NumberType.Home;
                
                if (!ushort.TryParse(item.Item1, out ushort ctgry)) ctgry = 0;                

                _fb.AddOrUpdatePhonebookEntry(phonebookId: phonebookId, uniqueId: phonebookEntryID, name: item.Item3, number: item.Item4, numberType: nmbrType, category: ctgry);

                phonebookEntryID++;
            }
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
