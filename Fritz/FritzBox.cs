using Fritz.Serialization;
using Fritz.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Fritz
{
    /// <summary>
    /// FritzBox class
    /// </summary>
    public sealed class FritzBox : FritzBoxBase
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public FritzBox()
            : base()
        {
        }

        /// <summary>
        /// Write phonebook to csv file.
        /// </summary>
        /// <param name="name">phonebook name, if empty all phonebooks will be written</param>
        public void WritePhonebookCsv(string name = "")
        {
            var service = new Contact(Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: UserName, password: Password);

            var phonebookList = new List<Tuple<ushort,string,string,string>>();

            service.GetPhonebookList(out string csvPhonebookIds);

            var phonebookIds = csvPhonebookIds.Split(',').Select(i => Convert.ToUInt16(i));

            foreach (var phonebookId in phonebookIds)
            {
                service.GetPhonebook(phonebookId, out string phonebookName, out string phonebookExtraId, out string phonebookUrl);
                phonebookList.Add(new Tuple<ushort, string, string, string>(phonebookId, phonebookName, phonebookExtraId, phonebookUrl));
            }

            foreach (var phoneBook in phonebookList)
            {
                var phonebookName = phoneBook.Item2;

                if (!string.IsNullOrEmpty(name) && !phonebookName.Equals(name)) continue;

                var phonebookUrl = phoneBook.Item4;
                phonebooks pbooks = FritzSerializer.DeserializePhonebookXml(phonebookUrl);

                if (null == pbooks) continue;

                var content = new StringBuilder();
                foreach (phonebooksPhonebookContact contact in pbooks.Items[0].contact)
                {
                    content.Append($"{contact.uniqueid};{contact.person[0].realName};{contact.telephony[0].number[0].Value}{Environment.NewLine}");
                }

                var fileName = $"{phonebookName}.csv";
                File.WriteAllText(fileName, content.ToString(), Encoding.UTF8);
            }
        }
    }
}
