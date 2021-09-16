using Fritz.Serialization;
using Fritz.Services;
using Fritz.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Fritz
{
    /// <summary>
    /// FritzBox class
    /// </summary>
    public sealed class FritzClient : FritzClientBase
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public FritzClient()
            : base()
        {
        }

        /// <summary>
        /// Add a new entry in a telephone book using the unique ID of the entry.
        /// Add new entry:
        ///     - set phonebook ID and XML entry data structure(without the unique ID tag)
        /// </summary>
        /// <param name="phonebookId"></param>
        /// <param name="name"></param>
        /// <param name="number"></param>
        /// <param name="numberType"></param>
        /// <param name="category"></param>
        /// <param name="email"></param>
        /// <returns>The action returns the unique ID of the new or changed entry.</returns>
        public string AddPhonebookEntry(ushort phonebookId, string name, string number, NumberType numberType, ushort category = 0, string email = "")
        {
            var service = new Contact(Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: UserName, password: Password);

            var data = new StringBuilder("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            data.Append("<contact>");
            data.Append($"<category>{category}</category>");
            data.Append($"<person><realName>{FritzUtility.Encode(name)}</realName></person>");
            data.Append($"<telephony nid=\"0\">");
            data.Append($"<number type=\"{numberType.ToString("G").ToLower()}\" id=\"0\" vanity=\"\" prio=\"1\">{number}</number>");
            data.Append("</telephony>");
            data.Append("<services>");
            if (!string.IsNullOrEmpty(email))
            {
                data.Append($@"<email classifier=""private"">{email}</email>");
            }
            data.Append("</services>");
            data.Append("<setup><ringTone/></setup>");
            data.Append($"<mod_time>{DateTime.Now.Ticks}</mod_time>");
            data.Append("</contact>");

            service.SetPhonebookEntryUID(phonebookId, data.ToString(), out string PhonebookEntryUiniqueID);

            return PhonebookEntryUiniqueID;
        }

        /// <summary>
        /// Change an existing entry in a telephone book using the unique ID of the entry.
        /// Change existing entry:
        ///     - set phonebook ID and XML entry data structure with the unique ID tag
        ///       (e.g. <uniqueid>28</uniqueid>)
        /// </summary>
        /// <param name="phonebookId"></param>
        /// <param name="uniqueId"></param>
        /// <param name="name"></param>
        /// <param name="number"></param>
        /// <param name="numberType"></param>
        /// <param name="category"></param>
        /// <param name="email"></param>
        /// <returns>The action returns the unique ID of the changed entry.</returns>
        public string UpdatePhonebookEntry(ushort phonebookId, string uniqueId, string name, string number, NumberType numberType, ushort category = 0, string email = "")
        {
            var service = new Contact(Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: UserName, password: Password);

            var data = new StringBuilder("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            data.Append("<contact>");
            data.Append($"<category>{category}</category>");
            data.Append($"<person><realName>{FritzUtility.Encode(name)}</realName></person>");
            data.Append($"<telephony nid=\"0\">");
            data.Append($"<number type=\"{numberType.ToString("G").ToLower()}\" id=\"0\" vanity=\"\" prio=\"1\">{number}</number>");
            data.Append("</telephony>");
            data.Append("<services>");
            if (!string.IsNullOrEmpty(email))
            {
                data.Append($@"<email classifier=""private"">{email}</email>");
            }
            data.Append("</services>");
            data.Append("<setup><ringTone/></setup>");
            data.Append($"<mod_time>{DateTime.Now.Ticks}</mod_time>");
            data.Append($"<uniqueid>{uniqueId}</uniqueid>");
            data.Append("</contact>");

            service.SetPhonebookEntryUID(phonebookId, data.ToString(), out string PhonebookEntryUiniqueID);

            return PhonebookEntryUiniqueID;
        }

        /// <summary>
        /// Add new entries with "" as value for PhonebookEntryID. Change existing entries with a value used for 
        /// PhonebookEntryID with GetPhonebookEntry. The variable PhonebookEntryData may contain a unique ID.
        /// </summary>
        /// <param name="phonebookId"></param>
        /// <param name="phonebookEntryID"></param>
        /// <param name="uniqueId"></param>
        /// <param name="name"></param>
        /// <param name="number"></param>
        /// <param name="numberType"></param>
        /// <param name="category"></param>
        /// <param name="email"></param>
        public void AddOrUpdatePhonebookEntry(ushort phonebookId, uint phonebookEntryID, uint uniqueId, string name, string number, NumberType numberType, ushort category = 0, string email = "")
        {
            var service = new Contact(Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: UserName, password: Password);

            var data = new StringBuilder("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            data.Append("<contact>");
            data.Append($"<category>{category}</category>");
            data.Append($"<person><realName>{FritzUtility.Encode(name)}</realName></person>");
            data.Append($"<telephony nid=\"0\">");
            data.Append($"<number type=\"{numberType.ToString("G").ToLower()}\" id=\"0\" vanity=\"\" prio=\"1\">{number}</number>");
            data.Append("</telephony>");
            data.Append("<services>");
            if (!string.IsNullOrEmpty(email))
            {
                data.Append($@"<email classifier=""private"">{email}</email>");
            }
            data.Append("</services>");
            data.Append("<setup><ringTone/></setup>");
            data.Append($"<mod_time>{DateTime.Now.Ticks}</mod_time>");
            data.Append($"<uniqueid>{uniqueId}</uniqueid>");
            data.Append("</contact>");

            service.SetPhonebookEntry(phonebookId, phonebookEntryID, data.ToString());
        }

        /// <summary>
        /// Get a phonebook entry.
        /// </summary>
        /// <param name="phonebookId"></param>
        /// <param name="phonebookEntryId"></param>
        /// <returns></returns>
        //public string GetPhonebookEntry(ushort phonebookId, uint phonebookEntryID)
        public contact GetPhonebookEntry(ushort phonebookId, uint phonebookEntryId)
        {
            var service = new Contact(Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: UserName, password: Password);

            service.GetPhonebookEntry(phonebookId, phonebookEntryId, out string phonebookEntryData);

            contact result = FritzSerializer.DeserializePhonebookEntry(phonebookEntryData);

            return result;
        }

        public contact GetPhonebookEntryUID(ushort phonebookId, string entryUniqueId)
        {
            var service = new Contact(Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: UserName, password: Password);

            service.GetPhonebookEntryUID(phonebookId, entryUniqueId, out string phonebookEntryData);

            contact result = FritzSerializer.DeserializePhonebookEntry(phonebookEntryData);

            return result;
        }

        /// <summary>
        /// Get phonebook id by phonebook name.
        /// </summary>
        /// <param name="service"></param>
        /// <param name="name">The phonebook name, e.g. "Test Phonebook"</param>
        /// <param name="phonebookId"></param>
        /// <returns></returns>
        public bool GetPhonebookId(string name, out ushort phonebookId)
        {
            var service = new Contact(Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: UserName, password: Password);
            return service.GetPhonebookId(name, out phonebookId);
        }

        /// <summary>
        /// Write phonebook to csv file.
        /// </summary>
        /// <param name="name">phonebook name, if empty all phonebooks will be written</param>
        /// <param name="folder">output folder</param>
        public void WritePhonebookCsv(string name = "", string folder = "", string separator=";")
        {
            if (!string.IsNullOrEmpty(folder))
            {
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
            }

            var service = new Contact(Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: UserName, password: Password);

            foreach (var phoneBook in service.GetPhonebookList())
            {
                var phonebookName = phoneBook.Item2;

                if (!string.IsNullOrEmpty(name) && !phonebookName.Equals(name)) continue;

                var phonebookUrl = phoneBook.Item4;
                phonebooks pbooks = FritzSerializer.DeserializePhonebookXml(phonebookUrl);

                if (null == pbooks) continue;

                var content = new StringBuilder($"category{separator}uniqueid{separator}name{separator}number{separator}type{Environment.NewLine}");
                foreach (phonebooksPhonebookContact contact in pbooks.Items[0].contact)
                {                    
                    content.Append($"{contact.category}{separator}{contact.uniqueid}{separator}{contact.person[0].realName}{separator}{contact.telephony[0].number[0].Value}{separator}{contact.telephony[0].number[0].type}{Environment.NewLine}");
                }

                var fileName = string.IsNullOrEmpty(folder)
                    ? $"{phonebookName}.csv"
                    : Path.Combine(folder, $"{phonebookName}.csv");

                File.WriteAllText(fileName, content.ToString(), Encoding.UTF8);
            }
        }

        /// <summary>
        /// Write phonebook to xml file.
        /// </summary>
        /// <param name="name">phonebook name, if empty all phonebooks will be written</param>
        /// <param name="folder">output folder</param>
        public void WritePhonebookXml(string name = "", string folder = "")
        {
            if (!string.IsNullOrEmpty(folder))
            {
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
            }

            var service = new Contact(Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: UserName, password: Password);                       

            foreach (var phoneBook in service.GetPhonebookList())
            {
                var phonebookName = phoneBook.Item2;

                if (!string.IsNullOrEmpty(name) && !phonebookName.Equals(name)) continue;

                var phonebookUrl = phoneBook.Item4;

                var doc = XDocument.Load(phonebookUrl);

                var fileName = string.IsNullOrEmpty(folder)
                    ? $"{phonebookName}.xml"
                    : Path.Combine(folder, $"{phonebookName}.xml");

                doc.Save(fileName);
            }
        }
    }
}
