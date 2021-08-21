using System;
using System.Collections.Generic;
using System.Linq;
using Fritz.Serialization;
using Fritz.Services;

namespace Fritz.Extensions
{
    /// <summary>
    /// ContactExtensions class
    /// </summary>
    public static class ContactExtensions
    {
        /// <summary>
        /// Delete phonebook by name
        /// </summary>
        /// <param name="src"></param>
        /// <param name="name">phonebook name</param>
        public static void DeletePhonebook(this Contact service, string name)
        {
            var phonebook = service.GetPhonebookList().Where(p => p.Item2.Equals(name)).FirstOrDefault();
            if (null == phonebook) return;

            service.DeletePhonebook(phonebook.Item1, string.Empty);
        }

        /// <summary>
        /// Get phonebook by name
        /// </summary>
        /// <param name="service"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static phonebooksPhonebook GetPhonebook(this Contact service, string name)
        {
            var phonebook = service.GetPhonebookList().Where(p => p.Item2.Equals(name)).FirstOrDefault();
            if (null == phonebook) return new phonebooksPhonebook();

            phonebooks pbooks = FritzSerializer.DeserializePhonebookXml(phonebook.Item4);

            return pbooks.Items[0];
        }

        /// <summary>
        /// Get phonebook id by phonebook name.
        /// </summary>
        /// <param name="service"></param>
        /// <param name="name">The phonebook name, e.g. "Test Phonebook"</param>
        /// <param name="phonebookId">Output</param>
        /// <returns></returns>
        public static bool GetPhonebookId(this Contact service, string name, out ushort phonebookId)
        {
            bool found = false;
            phonebookId = 0;
            foreach (ushort pid in service.GetPhonebookIdList())
            {
                service.GetPhonebook(pid, out string phonebookName, out string _, out string _);
                if (phonebookName.Equals(name))
                {
                    phonebookId = pid;
                    found = true;
                    break;
                }
            }
            return found;
        }

        /// <summary>
        /// Get list of phonebook ids.
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        public static IEnumerable<UInt16> GetPhonebookIdList(this Contact service)
        {
            service.GetPhonebookList(out string csvPhonebookIds);
            var phonebookIds = csvPhonebookIds.Split(',').Select(i => Convert.ToUInt16(i));
            return phonebookIds;
        }

        /// <summary>
        /// Get phonebook list
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        public static IEnumerable<Tuple<ushort, string, string, string>> GetPhonebookList(this Contact service)
        {
            var phonebookList = new List<Tuple<ushort, string, string, string>>();
            foreach (var phonebookId in service.GetPhonebookIdList())
            {
                service.GetPhonebook(phonebookId, out string phonebookName, out string phonebookExtraId, out string phonebookUrl);
                phonebookList.Add(new Tuple<ushort, string, string, string>(phonebookId, phonebookName, phonebookExtraId, phonebookUrl));
            }
            return phonebookList;
        }

        /// <summary>
        /// Returns true if the phonebook exists
        /// </summary>
        /// <param name="service"></param>
        /// <param name="name">phonebook name</param>
        /// <returns>true if the phonebook exists, otherwise false</returns>
        public static bool PhonebookExists(this Contact service, string name)
        {
            return service.GetPhonebookList().Any(p => p.Item2.Equals(name));
        }
    }
}
