using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using i4 = System.UInt32;
using ui1 = System.Byte;
using ui2 = System.UInt16;
using ui4 = System.UInt32;
using boolean = System.Boolean;
using uuid = System.String;
using dateTime = System.DateTime;

namespace Fritz.Services
{
    public class Time
    {
        #region SoapHttpClientProtocol
        [WebServiceBinding("urn:dslforum-org:service:Time:1", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        class time : SoapHttpClientProtocol
        {
            [SoapDocumentMethod("urn:dslforum-org:service:Time:1#GetInfo", RequestNamespace = "urn:dslforum-org:service:Time:1", ResponseNamespace = "urn:dslforum-org:service:Time:1")]
            public void GetInfo([XmlElement("NewNTPServer1", Namespace="")]out string NTPServer1, [XmlElement("NewNTPServer2", Namespace="")]out string NTPServer2, [XmlElement("NewCurrentLocalTime", Namespace="")]out dateTime CurrentLocalTime, [XmlElement("NewLocalTimeZone", Namespace="")]out string LocalTimeZone, [XmlElement("NewLocalTimeZoneName", Namespace="")]out string LocalTimeZoneName, [XmlElement("NewDaylightSavingsUsed", Namespace="")]out boolean DaylightSavingsUsed, [XmlElement("NewDaylightSavingsStart", Namespace="")]out dateTime DaylightSavingsStart, [XmlElement("NewDaylightSavingsEnd", Namespace="")]out dateTime DaylightSavingsEnd)
            {
                object[] results = this.Invoke("GetInfo", new object[] {  });
                NTPServer1 = (string)results[0];
                NTPServer2 = (string)results[1];
                CurrentLocalTime = (dateTime)results[2];
                LocalTimeZone = (string)results[3];
                LocalTimeZoneName = (string)results[4];
                DaylightSavingsUsed = (boolean)results[5];
                DaylightSavingsStart = (dateTime)results[6];
                DaylightSavingsEnd = (dateTime)results[7];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:Time:1#SetNTPServers", OneWay=true, RequestNamespace = "urn:dslforum-org:service:Time:1", ResponseNamespace = "urn:dslforum-org:service:Time:1")]
            public void SetNTPServers([XmlElement("NewNTPServer1", Namespace="")]string NTPServer1, [XmlElement("NewNTPServer2", Namespace="")]string NTPServer2)
            {
                this.Invoke("SetNTPServers", new object[] { NTPServer1, NTPServer2 });
            }

        }
        #endregion

        public string ControlURL { get { return "/upnp/control/time"; } }
        public SoapHttpClientProtocol SoapHttpClientProtocol { get; set; }

        public Time(string url)
        {
            SoapHttpClientProtocol = new time()
            {
                Url = url + ControlURL
            };
        }

        public void GetInfo(out string NTPServer1, out string NTPServer2, out dateTime CurrentLocalTime, out string LocalTimeZone, out string LocalTimeZoneName, out boolean DaylightSavingsUsed, out dateTime DaylightSavingsStart, out dateTime DaylightSavingsEnd)
        {
            ((time)SoapHttpClientProtocol).GetInfo(out NTPServer1, out NTPServer2, out CurrentLocalTime, out LocalTimeZone, out LocalTimeZoneName, out DaylightSavingsUsed, out DaylightSavingsStart, out DaylightSavingsEnd);
        }

        public void SetNTPServers(string NTPServer1, string NTPServer2)
        {
            ((time)SoapHttpClientProtocol).SetNTPServers(NTPServer1, NTPServer2);
        }

    }
}
