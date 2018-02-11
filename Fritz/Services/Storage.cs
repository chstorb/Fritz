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
    public class Storage
    {
        #region SoapHttpClientProtocol
        [WebServiceBinding("urn:dslforum-org:service:X_AVM-DE_Storage:1", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        class x_storage : SoapHttpClientProtocol
        {
            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_Storage:1#GetInfo", RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_Storage:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_Storage:1")]
            public void GetInfo([XmlElement("NewFTPEnable", Namespace="")]out boolean FTPEnable, [XmlElement("NewFTPStatus", Namespace="")]out string FTPStatus, [XmlElement("NewSMBEnable", Namespace="")]out boolean SMBEnable)
            {
                object[] results = this.Invoke("GetInfo", new object[] {  });
                FTPEnable = (boolean)results[0];
                FTPStatus = (string)results[1];
                SMBEnable = (boolean)results[2];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_Storage:1#SetFTPServer", OneWay=true, RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_Storage:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_Storage:1")]
            public void SetFTPServer([XmlElement("NewFTPEnable", Namespace="")]boolean FTPEnable)
            {
                this.Invoke("SetFTPServer", new object[] { FTPEnable });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_Storage:1#SetSMBServer", OneWay=true, RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_Storage:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_Storage:1")]
            public void SetSMBServer([XmlElement("NewSMBEnable", Namespace="")]boolean SMBEnable)
            {
                this.Invoke("SetSMBServer", new object[] { SMBEnable });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_Storage:1#GetUserInfo", RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_Storage:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_Storage:1")]
            public void GetUserInfo([XmlElement("NewEnable", Namespace="")]out boolean Enable, [XmlElement("NewUsername", Namespace="")]out string Username, [XmlElement("NewX_AVM-DE_NetworkAccessReadOnly", Namespace="")]out boolean NetworkAccessReadOnly)
            {
                object[] results = this.Invoke("GetUserInfo", new object[] {  });
                Enable = (boolean)results[0];
                Username = (string)results[1];
                NetworkAccessReadOnly = (boolean)results[2];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_Storage:1#SetUserConfig", OneWay=true, RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_Storage:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_Storage:1")]
            public void SetUserConfig([XmlElement("NewEnable", Namespace="")]boolean Enable, [XmlElement("NewPassword", Namespace="")]string Password, [XmlElement("NewX_AVM-DE_NetworkAccessReadOnly", Namespace="")]boolean NetworkAccessReadOnly)
            {
                this.Invoke("SetUserConfig", new object[] { Enable, Password, NetworkAccessReadOnly });
            }

        }
        #endregion

        public string ControlURL { get { return "/upnp/control/x_storage"; } }
        public SoapHttpClientProtocol SoapHttpClientProtocol { get; set; }

        public Storage(string url)
        {
            SoapHttpClientProtocol = new x_storage()
            {
                Url = url + ControlURL
            };
        }

        public void GetInfo(out boolean FTPEnable, out string FTPStatus, out boolean SMBEnable)
        {
            ((x_storage)SoapHttpClientProtocol).GetInfo(out FTPEnable, out FTPStatus, out SMBEnable);
        }

        public void SetFTPServer(boolean FTPEnable)
        {
            ((x_storage)SoapHttpClientProtocol).SetFTPServer(FTPEnable);
        }

        public void SetSMBServer(boolean SMBEnable)
        {
            ((x_storage)SoapHttpClientProtocol).SetSMBServer(SMBEnable);
        }

        public void GetUserInfo(out boolean Enable, out string Username, out boolean NetworkAccessReadOnly)
        {
            ((x_storage)SoapHttpClientProtocol).GetUserInfo(out Enable, out Username, out NetworkAccessReadOnly);
        }

        public void SetUserConfig(boolean Enable, string Password, boolean NetworkAccessReadOnly)
        {
            ((x_storage)SoapHttpClientProtocol).SetUserConfig(Enable, Password, NetworkAccessReadOnly);
        }

    }
}
