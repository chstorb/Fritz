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
    public class Myfritz
    {
        #region SoapHttpClientProtocol
        [WebServiceBinding("urn:dslforum-org:service:X_AVM-DE_MyFritz:1", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        class x_myfritz : SoapHttpClientProtocol
        {
            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_MyFritz:1#GetInfo", RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_MyFritz:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_MyFritz:1")]
            public void GetInfo([XmlElement("NewEnabled", Namespace="")]out boolean Enabled, [XmlElement("NewDeviceRegistered", Namespace="")]out boolean DeviceRegistered, [XmlElement("NewDynDNSName", Namespace="")]out string DynDNSName, [XmlElement("NewPort", Namespace="")]out string Port)
            {
                object[] results = this.Invoke("GetInfo", new object[] {  });
                Enabled = (boolean)results[0];
                DeviceRegistered = (boolean)results[1];
                DynDNSName = (string)results[2];
                Port = (string)results[3];
            }

        }
        #endregion

        public string ControlURL { get { return "/upnp/control/x_myfritz"; } }
        public SoapHttpClientProtocol SoapHttpClientProtocol { get; set; }

        public Myfritz(string url)
        {
            SoapHttpClientProtocol = new x_myfritz()
            {
                Url = url + ControlURL
            };
        }

        public void GetInfo(out boolean Enabled, out boolean DeviceRegistered, out string DynDNSName, out string Port)
        {
            ((x_myfritz)SoapHttpClientProtocol).GetInfo(out Enabled, out DeviceRegistered, out DynDNSName, out Port);
        }

    }
}
