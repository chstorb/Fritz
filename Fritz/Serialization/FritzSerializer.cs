using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Fritz.Serialization
{
    /// <summary>
    /// FritzConvert class
    /// </summary>
    public static class FritzSerializer
    {
        public static phonebooks DeserializePhonebookXml(string phonebookUrl)
        {
            var uri = new Uri(phonebookUrl);

            var factory = new XmlSerializerFactory();
            var ser = factory.CreateSerializer(typeof(phonebooks));
            var request = (HttpWebRequest)WebRequest.Create(uri);
            var response = (HttpWebResponse)request.GetResponse();
            var responseStream = response.GetResponseStream();
            phonebooks pbooks = (phonebooks)ser.Deserialize(responseStream);
            responseStream.Close();
            return pbooks;
        }

        public static contact DeserializePhonebookEntry(string xml)
        {
            var serializer = new XmlSerializer(typeof(contact));
            contact result;
            using (TextReader reader = new StringReader(xml))
            {
                result = (contact)serializer.Deserialize(reader);
            }
            return result;
        }
    }
}
