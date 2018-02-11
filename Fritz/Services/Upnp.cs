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
    public class Upnp
    {
        #region SoapHttpClientProtocol
        [WebServiceBinding("urn:dslforum-org:service:X_AVM-DE_UPnP:1", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        class x_upnp : SoapHttpClientProtocol
        {
            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_UPnP:1#GetInfo", RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_UPnP:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_UPnP:1")]
            public void GetInfo([XmlElement("NewEnable", Namespace="")]out boolean Enable, [XmlElement("NewUPnPMediaServer", Namespace="")]out boolean UPnPMediaServer)
            {
                object[] results = this.Invoke("GetInfo", new object[] {  });
                Enable = (boolean)results[0];
                UPnPMediaServer = (boolean)results[1];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_UPnP:1#SetConfig", OneWay=true, RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_UPnP:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_UPnP:1")]
            public void SetConfig([XmlElement("NewEnable", Namespace="")]boolean Enable, [XmlElement("NewUPnPMediaServer", Namespace="")]boolean UPnPMediaServer)
            {
                this.Invoke("SetConfig", new object[] { Enable, UPnPMediaServer });
            }

        }
        #endregion

        public string ControlURL { get { return "/upnp/control/x_upnp"; } }
        public SoapHttpClientProtocol SoapHttpClientProtocol { get; set; }

        public Upnp(string url)
        {
            SoapHttpClientProtocol = new x_upnp()
            {
                Url = url + ControlURL
            };
        }

        public void GetInfo(out boolean Enable, out boolean UPnPMediaServer)
        {
            ((x_upnp)SoapHttpClientProtocol).GetInfo(out Enable, out UPnPMediaServer);
        }

        public void SetConfig(boolean Enable, boolean UPnPMediaServer)
        {
            ((x_upnp)SoapHttpClientProtocol).SetConfig(Enable, UPnPMediaServer);
        }

    }
}
