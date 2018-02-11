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
    public class Wanethlinkconfig1
    {
        #region SoapHttpClientProtocol
        [WebServiceBinding("urn:dslforum-org:service:WANEthernetLinkConfig:1", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        class wanethlinkconfig1 : SoapHttpClientProtocol
        {
            [SoapDocumentMethod("urn:dslforum-org:service:WANEthernetLinkConfig:1#GetEthernetLinkStatus", RequestNamespace = "urn:dslforum-org:service:WANEthernetLinkConfig:1", ResponseNamespace = "urn:dslforum-org:service:WANEthernetLinkConfig:1")]
            public void GetEthernetLinkStatus([XmlElement("NewEthernetLinkStatus", Namespace="")]out string EthernetLinkStatus)
            {
                object[] results = this.Invoke("GetEthernetLinkStatus", new object[] {  });
                EthernetLinkStatus = (string)results[0];
            }

        }
        #endregion

        public string ControlURL { get { return "/upnp/control/wanethlinkconfig1"; } }
        public SoapHttpClientProtocol SoapHttpClientProtocol { get; set; }

        public Wanethlinkconfig1(string url)
        {
            SoapHttpClientProtocol = new wanethlinkconfig1()
            {
                Url = url + ControlURL
            };
        }

        public void GetEthernetLinkStatus(out string EthernetLinkStatus)
        {
            ((wanethlinkconfig1)SoapHttpClientProtocol).GetEthernetLinkStatus(out EthernetLinkStatus);
        }

    }
}
