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
        /// Add new entries with "" as value for PhonebookEntryID. Change existing entries with a value used for 
        /// PhonebookEntryID with GetPhonebookEntry.The variable PhonebookEntryData may contain a unique ID.
        /// </summary>
        /// <param name="phonebookId"></param>
        /// <param name="uniqueId"></param>
        /// <param name="name"></param>
        /// <param name="number"></param>
        /// <param name="numberType"></param>
        /// <param name="category"></param>
        public void AddOrUpdatePhonebookEntry(ushort phonebookId, uint uniqueId, string name, string number, NumberType numberType, ushort category = 0)
        {
            var service = new Contact(Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: UserName, password: Password);

            uint phonebookEntryID = 0;

            var data = new StringBuilder("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            data.Append("<contact>");
            data.Append($"<category>{category}</category>");
            data.Append($"<person><realName>{FritzUtility.Encode(name)}</realName></person>");
            data.Append($"<telephony nid=\"0\">");
            data.Append($"<number type=\"{numberType.ToString("G").ToLower()}\" id=\"0\" vanity=\"\" prio=\"1\">{number}</number>");
            data.Append("</telephony>");
            data.Append("<services/>");
            data.Append("<setup><ringTone/></setup>");
            data.Append($"<mod_time>{DateTime.Now.Ticks}</mod_time>");
            data.Append($"<uniqueid>{uniqueId}</uniqueid>");
            data.Append("</contact>");

            service.SetPhonebookEntry(phonebookId, phonebookEntryID, data.ToString());
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
