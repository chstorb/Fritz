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
    public class Remote
    {
        #region SoapHttpClientProtocol
        [WebServiceBinding("urn:dslforum-org:service:X_AVM-DE_RemoteAccess:1", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        class x_remote : SoapHttpClientProtocol
        {
            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_RemoteAccess:1#GetInfo", RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_RemoteAccess:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_RemoteAccess:1")]
            public void GetInfo([XmlElement("NewEnabled", Namespace="")]out boolean Enabled, [XmlElement("NewPort", Namespace="")]out string Port, [XmlElement("NewUsername", Namespace="")]out string Username)
            {
                object[] results = this.Invoke("GetInfo", new object[] {  });
                Enabled = (boolean)results[0];
                Port = (string)results[1];
                Username = (string)results[2];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_RemoteAccess:1#SetConfig", OneWay=true, RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_RemoteAccess:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_RemoteAccess:1")]
            public void SetConfig([XmlElement("NewEnabled", Namespace="")]boolean Enabled, [XmlElement("NewPort", Namespace="")]string Port, [XmlElement("NewUsername", Namespace="")]string Username, [XmlElement("NewPassword", Namespace="")]string Password)
            {
                this.Invoke("SetConfig", new object[] { Enabled, Port, Username, Password });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_RemoteAccess:1#GetDDNSInfo", RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_RemoteAccess:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_RemoteAccess:1")]
            public void GetDDNSInfo([XmlElement("NewEnabled", Namespace="")]out boolean Enabled, [XmlElement("NewProviderName", Namespace="")]out string ProviderName, [XmlElement("NewUpdateURL", Namespace="")]out string UpdateURL, [XmlElement("NewDomain", Namespace="")]out string Domain, [XmlElement("NewStatusIPv4", Namespace="")]out string StatusIPv4, [XmlElement("NewStatusIPv6", Namespace="")]out string StatusIPv6, [XmlElement("NewUsername", Namespace="")]out string Username, [XmlElement("NewMode", Namespace="")]out string Mode, [XmlElement("NewServerIPv4", Namespace="")]out string ServerIPv4, [XmlElement("NewServerIPv6", Namespace="")]out string ServerIPv6)
            {
                object[] results = this.Invoke("GetDDNSInfo", new object[] {  });
                Enabled = (boolean)results[0];
                ProviderName = (string)results[1];
                UpdateURL = (string)results[2];
                Domain = (string)results[3];
                StatusIPv4 = (string)results[4];
                StatusIPv6 = (string)results[5];
                Username = (string)results[6];
                Mode = (string)results[7];
                ServerIPv4 = (string)results[8];
                ServerIPv6 = (string)results[9];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_RemoteAccess:1#GetDDNSProviders", RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_RemoteAccess:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_RemoteAccess:1")]
            public void GetDDNSProviders([XmlElement("NewProviderList", Namespace="")]out string ProviderList)
            {
                object[] results = this.Invoke("GetDDNSProviders", new object[] {  });
                ProviderList = (string)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_RemoteAccess:1#SetDDNSConfig", OneWay=true, RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_RemoteAccess:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_RemoteAccess:1")]
            public void SetDDNSConfig([XmlElement("NewEnabled", Namespace="")]boolean Enabled, [XmlElement("NewProviderName", Namespace="")]string ProviderName, [XmlElement("NewUpdateURL", Namespace="")]string UpdateURL, [XmlElement("NewDomain", Namespace="")]string Domain, [XmlElement("NewUsername", Namespace="")]string Username, [XmlElement("NewMode", Namespace="")]string Mode, [XmlElement("NewServerIPv4", Namespace="")]string ServerIPv4, [XmlElement("NewServerIPv6", Namespace="")]string ServerIPv6, [XmlElement("NewPassword", Namespace="")]string Password)
            {
                this.Invoke("SetDDNSConfig", new object[] { Enabled, ProviderName, UpdateURL, Domain, Username, Mode, ServerIPv4, ServerIPv6, Password });
            }

        }
        #endregion

        public string ControlURL { get { return "/upnp/control/x_remote"; } }
        public SoapHttpClientProtocol SoapHttpClientProtocol { get; set; }

        public Remote(string url)
        {
            SoapHttpClientProtocol = new x_remote()
            {
                Url = url + ControlURL
            };
        }

        public void GetInfo(out boolean Enabled, out string Port, out string Username)
        {
            ((x_remote)SoapHttpClientProtocol).GetInfo(out Enabled, out Port, out Username);
        }

        public void SetConfig(boolean Enabled, string Port, string Username, string Password)
        {
            ((x_remote)SoapHttpClientProtocol).SetConfig(Enabled, Port, Username, Password);
        }

        public void GetDDNSInfo(out boolean Enabled, out string ProviderName, out string UpdateURL, out string Domain, out string StatusIPv4, out string StatusIPv6, out string Username, out string Mode, out string ServerIPv4, out string ServerIPv6)
        {
            ((x_remote)SoapHttpClientProtocol).GetDDNSInfo(out Enabled, out ProviderName, out UpdateURL, out Domain, out StatusIPv4, out StatusIPv6, out Username, out Mode, out ServerIPv4, out ServerIPv6);
        }

        public void GetDDNSProviders(out string ProviderList)
        {
            ((x_remote)SoapHttpClientProtocol).GetDDNSProviders(out ProviderList);
        }

        public void SetDDNSConfig(boolean Enabled, string ProviderName, string UpdateURL, string Domain, string Username, string Mode, string ServerIPv4, string ServerIPv6, string Password)
        {
            ((x_remote)SoapHttpClientProtocol).SetDDNSConfig(Enabled, ProviderName, UpdateURL, Domain, Username, Mode, ServerIPv4, ServerIPv6, Password);
        }

    }
}
