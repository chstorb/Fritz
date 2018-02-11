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
    public class Webdav
    {
        #region SoapHttpClientProtocol
        [WebServiceBinding("urn:dslforum-org:service:X_AVM-DE_WebDAVClient:1", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        class x_webdav : SoapHttpClientProtocol
        {
            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_WebDAVClient:1#GetInfo", RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_WebDAVClient:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_WebDAVClient:1")]
            public void GetInfo([XmlElement("NewEnable", Namespace="")]out boolean Enable, [XmlElement("NewHostURL", Namespace="")]out string HostURL, [XmlElement("NewUsername", Namespace="")]out string Username, [XmlElement("NewMountpointName", Namespace="")]out string MountpointName)
            {
                object[] results = this.Invoke("GetInfo", new object[] {  });
                Enable = (boolean)results[0];
                HostURL = (string)results[1];
                Username = (string)results[2];
                MountpointName = (string)results[3];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_WebDAVClient:1#SetConfig", OneWay=true, RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_WebDAVClient:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_WebDAVClient:1")]
            public void SetConfig([XmlElement("NewEnable", Namespace="")]boolean Enable, [XmlElement("NewHostURL", Namespace="")]string HostURL, [XmlElement("NewUsername", Namespace="")]string Username, [XmlElement("NewPassword", Namespace="")]string Password, [XmlElement("NewMountpointName", Namespace="")]string MountpointName)
            {
                this.Invoke("SetConfig", new object[] { Enable, HostURL, Username, Password, MountpointName });
            }

        }
        #endregion

        public string ControlURL { get { return "/upnp/control/x_webdav"; } }
        public SoapHttpClientProtocol SoapHttpClientProtocol { get; set; }

        public Webdav(string url)
        {
            SoapHttpClientProtocol = new x_webdav()
            {
                Url = url + ControlURL
            };
        }

        public void GetInfo(out boolean Enable, out string HostURL, out string Username, out string MountpointName)
        {
            ((x_webdav)SoapHttpClientProtocol).GetInfo(out Enable, out HostURL, out Username, out MountpointName);
        }

        public void SetConfig(boolean Enable, string HostURL, string Username, string Password, string MountpointName)
        {
            ((x_webdav)SoapHttpClientProtocol).SetConfig(Enable, HostURL, Username, Password, MountpointName);
        }

    }
}
