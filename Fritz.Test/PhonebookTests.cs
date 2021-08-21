﻿using Fritz.Serialization;
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
            const string PhoneBookName = "Test Phonebook";

            var phonebook = _fb.GetPhonebook(name: PhoneBookName);

            Assert.IsNotNull(phonebook);
            Assert.IsTrue(phonebook.contact.Count() > 0);

            foreach (var contact in phonebook.contact)
            {
                string email = (contact.telephony[0].services != null && contact.telephony[0].services.Count() > 0)
                    ? contact.telephony[0].services[0].Value
                    : string.Empty;

                Console.WriteLine($"{contact.uniqueid}\t{contact.person[0].realName}\t{contact.telephony[0].number[0].Value}\t{email}");
            }
        }

        [TestMethod]
        public void TestGetPhonebookEntry()
        {
            const string PhoneBookName = "Test Phonebook";

            bool success = _fb.GetPhonebookId(name: PhoneBookName, out ushort phonebookId);

            Assert.AreEqual(true, success);

            contact result = _fb.GetPhonebookEntry(phonebookId: phonebookId, phonebookEntryId: 0);

            string name = result.person.realName;
            string email = result.services.email.Value;

            Assert.IsTrue(name.Length > 0);
            Assert.IsTrue(email.Length > 0);
        }

        [TestMethod]
        public void TestGetPhonebookEntryUID()
        {
            const string PhoneBookName = "Test Phonebook";

            bool success = _fb.GetPhonebookId(name: PhoneBookName, out ushort phonebookId);

            Assert.AreEqual(true, success);

            contact result = _fb.GetPhonebookEntryUID(phonebookId: phonebookId, entryUniqueId: "222");

            string name = result.person.realName;
            string email = result.services.email.Value;

            Assert.IsTrue(name.Length > 0);
            Assert.IsTrue(email.Length > 0);
        }

        [TestMethod]
        public void TestAddPhonebookEntry()
        {
            const string PhoneBookName = "Test Phonebook";

            bool success = _fb.GetPhonebookId(name: PhoneBookName, out ushort phonebookId);

            Assert.AreEqual(true, success);

            string phonebookEntryUniqueID = _fb.AddPhonebookEntry(phonebookId: phonebookId,
                name: "Siciliani Drago",
                number: "+1 205 555 0108",
                numberType: NumberType.Home,
                category: 0,
                email: "sid@example.onmicrosoft.com");

            Console.WriteLine($"Unique ID: {phonebookEntryUniqueID}");
        }

        [TestMethod]
        public void TestUpdatePhonebookEntry()
        {
            const string PhoneBookName = "Test Phonebook";

            bool success = _fb.GetPhonebookId(name: PhoneBookName, out ushort phonebookId);

            Assert.AreEqual(true, success);

            _fb.UpdatePhonebookEntry(phonebookId: phonebookId,
                uniqueId: "222",
                name: "Siciliani Diego",
                number: "+1 205 555 0108",
                numberType: NumberType.Work,
                category: 0,
                email: "Diego.Siciliani@example.onmicrosoft.com"
            );
        }

        [TestMethod]
        public void TestAddOrUpdatePhonebookEntry()
        {
            const string PhoneBookName = "Test Phonebook";

            bool success = _fb.GetPhonebookId(name: PhoneBookName, out ushort phonebookId);

            Assert.AreEqual(true, success);

            _fb.AddOrUpdatePhonebookEntry(phonebookId: phonebookId,
                phonebookEntryID: 0,
                uniqueId: 216,
                name: "Siciliani Diego",
                number: " + 1 205 555 0108",
                numberType: NumberType.Work);
        }

        [TestMethod]
        public void TestImportPhonebookEntriesFromCsv()
        {
            var fileName = @"Telefonbuch.csv";

            var list = FritzUtility.ReadCsvFile(fileName);

            ushort phonebookId = 0;
            uint uniqueId = 0;
            uint phonebookEntryID = 0;
            foreach (var item in list)
            {
                if (!Enum.TryParse<NumberType>(item.Item5, out NumberType nmbrType)) nmbrType = NumberType.Home;

                if (!ushort.TryParse(item.Item1, out ushort ctgry)) ctgry = 0;

                _fb.AddOrUpdatePhonebookEntry(phonebookId: phonebookId, phonebookEntryID: phonebookEntryID, uniqueId: uniqueId, name: item.Item3, number: item.Item4, numberType: nmbrType, category: ctgry);
                uniqueId++;
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
