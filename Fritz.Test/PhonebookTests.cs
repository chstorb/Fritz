using Fritz.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fritz.Test
{
    [TestClass]
    public class PhonebookTests
    {
        #region Properties & Fields

        private FritzClient _fb = null;

        #endregion

        /// <summary>
        /// TestInitialize runs before and after each test, this is to ensure that no tests are coupled.
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            var userName = Environment.GetEnvironmentVariable("FritzBoxUserName");
            var password = Environment.GetEnvironmentVariable("FritzBoxPassword");

            _fb = new FritzClient { UserName = userName, Password = password };
        }

        /// <summary>
        /// TestCleanup runs after each test, this is to ensure that no tests are coupled.
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {
            _fb.AddPhonebook(name: "Test Phonebook");
        }

        [TestMethod]
        public void TestPhonebook()
        {
            // Create a name for the test phonebook.
            string testPhonebookName = $"Test Phonebook {Utility.GetTimestamp()}";



            // Create the test phonebook on the device.
            _fb.AddPhonebook(name: testPhonebookName);
            Assert.IsTrue(_fb.PhonebookExists(testPhonebookName));



            // Get the phonebook id.
            bool success = _fb.GetPhonebookId(name: testPhonebookName, out ushort testPhonebookId);
            Assert.IsTrue(success);
            Assert.IsTrue(testPhonebookId > 0);



            // Add an inital phonebook entry.
            string testPhonebookEntryUniqueId = _fb.AddPhonebookEntry(phonebookId: testPhonebookId,
                name: "Siciliani Salvatore",
                telephonyNumbers: new List<contactTelephonyNumber>() {
                    new contactTelephonyNumber() { Value = "+1 205 111 0010", type = NumberType.Home.ToString("G") },
                    new contactTelephonyNumber() { Value = "+1 205 111 0010", type = NumberType.Mobile.ToString("G") },
                    new contactTelephonyNumber() { Value = "+1 205 111 0010", type = NumberType.Work.ToString("G") },
                    new contactTelephonyNumber() { Value = "+1 205 111 0010", type = NumberType.Fax_Work.ToString("G") },
                },
                category: 0,
                email: "salvatore.siciliani@fritz.box");
            Assert.IsNotNull(testPhonebookEntryUniqueId);
            Assert.IsTrue(testPhonebookEntryUniqueId.Length > 0);



            // Add a second phonebook entry.
            testPhonebookEntryUniqueId = _fb.AddPhonebookEntry(phonebookId: testPhonebookId,
                name: "Guzman Miguela",
                telephonyNumbers: new List<contactTelephonyNumber>() {
                    new contactTelephonyNumber() { Value = "+1 205 222 0011", type = NumberType.Home.ToString("G") },
                    new contactTelephonyNumber() { Value = "+1 205 222 0012", type = NumberType.Mobile.ToString("G") },
                    new contactTelephonyNumber() { Value = "+1 205 222 0013", type = NumberType.Work.ToString("G") },
                    new contactTelephonyNumber() { Value = "+1 205 222 0014", type = NumberType.Fax_Work.ToString("G") },
                },
                category: 0,
                email: "miguela.guzman@fritz.box");
            Assert.IsNotNull(testPhonebookEntryUniqueId);
            Assert.IsTrue(testPhonebookEntryUniqueId.Length > 0);



            // Get the phonebook entry by uid.
            contact result = _fb.GetPhonebookEntryUID(phonebookId: testPhonebookId, entryUniqueId: testPhonebookEntryUniqueId);
            Assert.IsNotNull(result);

            string name = result.person.realName;
            Assert.IsTrue(name.Length > 0);

            string email = result.services.email?.Value ?? string.Empty;
            Assert.AreEqual(expected: "miguela.guzman@fritz.box", actual: email);



            // Update phonebook entry.
            _fb.UpdatePhonebookEntry(phonebookId: testPhonebookId,
                uniqueId: testPhonebookEntryUniqueId,
                name: "Guzman E. Miguela",
                telephonyNumbers: new List<contactTelephonyNumber>() {
                    new contactTelephonyNumber() { Value = "+1 205 222 0021", type = NumberType.Home.ToString("G") },
                    new contactTelephonyNumber() { Value = "+1 205 222 0022", type = NumberType.Mobile.ToString("G") },
                    new contactTelephonyNumber() { Value = "+1 205 222 0023", type = NumberType.Work.ToString("G") },
                    new contactTelephonyNumber() { Value = "+1 205 222 0024", type = NumberType.Fax_Work.ToString("G") },
                },
                category: 0,
                email: "miguela.guzman@fritz.box"
            );




            // Delete phonebook entry.
            _fb.DeletePhonebookEntryUID(phonebookId: testPhonebookId, uniqueId: testPhonebookEntryUniqueId);



            // Write the phonebook to console.
            var phonebook = _fb.GetPhonebook(name: testPhonebookName);

            Assert.IsNotNull(phonebook);
            Assert.IsTrue(phonebook.contact.Count() > 0);

            foreach (var contact in phonebook.contact)
            {
                email = (contact.telephony[0].services != null && contact.telephony[0].services.Count() > 0)
                    ? contact.telephony[0].services[0].Value
                    : string.Empty;

                Console.WriteLine($"{contact.uniqueid}\t{contact.person[0].realName}\t{contact.telephony[0].number[0].Value}\t{email}");
            }



            // Backup the test phonebook as csv file.
            // Note: In VS, the deployment directories created for running tests are deleted after each test run.
            // If the test fails, these directories are retained for easier analysis. You can override this behavior
            // with the DeleteDeploymentDirectoryAfterTestRunIsComplete setting.See http://msdn.microsoft.com/en-us/library/jj635153.aspx
            _fb.WritePhonebookCsv(name: testPhonebookName, folder: TestContext.TestDeploymentDir);



            // Backup the test phonebook as xml file.
            _fb.WritePhonebookXml(name: testPhonebookName, folder: TestContext.TestDeploymentDir);



            // Remove the test phonebook from the device.
            _fb.DeletePhonebook(name: testPhonebookName);
        }

        [Ignore]
        [TestMethod]
        public void TestImportPhonebookEntriesFromCsv()
        {
            var fileName = @"Telefonbuch.csv";

            var list = Utility.ReadCsvFile(fileName);

            ushort phonebookId = 0;
            uint uniqueId = 0;
            uint phonebookEntryID = 0;
            foreach (var item in list)
            {
                if (!Enum.TryParse<NumberType>(item.Item5, out NumberType nmbrType)) nmbrType = NumberType.Home;

                if (!ushort.TryParse(item.Item1, out ushort ctgry)) ctgry = 0;

                _fb.AddOrUpdatePhonebookEntry(phonebookId: phonebookId, phonebookEntryID: phonebookEntryID, uniqueId: uniqueId, name: item.Item3,
                    telephonyNumbers: new List<contactTelephonyNumber>() { new contactTelephonyNumber() { Value = item.Item4, type = nmbrType.ToString("G") } },
                    category: ctgry);
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
