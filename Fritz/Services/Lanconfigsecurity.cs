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
    public class Lanconfigsecurity
    {
        #region SoapHttpClientProtocol
        [WebServiceBinding("urn:dslforum-org:service:LANConfigSecurity:1", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        class lanconfigsecurity : SoapHttpClientProtocol
        {
            [SoapDocumentMethod("urn:dslforum-org:service:LANConfigSecurity:1#GetInfo", RequestNamespace = "urn:dslforum-org:service:LANConfigSecurity:1", ResponseNamespace = "urn:dslforum-org:service:LANConfigSecurity:1")]
            public void GetInfo([XmlElement("NewMaxCharsPassword", Namespace="")]out ui2 MaxCharsPassword, [XmlElement("NewMinCharsPassword", Namespace="")]out ui2 MinCharsPassword, [XmlElement("NewAllowedCharsPassword", Namespace="")]out string AllowedCharsPassword)
            {
                object[] results = this.Invoke("GetInfo", new object[] {  });
                MaxCharsPassword = (ui2)results[0];
                MinCharsPassword = (ui2)results[1];
                AllowedCharsPassword = (string)results[2];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:LANConfigSecurity:1#X_AVM-DE_GetCurrentUser", RequestElementName = "X_AVM-DE_GetCurrentUser", ResponseElementName = "X_AVM-DE_GetCurrentUserResponse", RequestNamespace = "urn:dslforum-org:service:LANConfigSecurity:1", ResponseNamespace = "urn:dslforum-org:service:LANConfigSecurity:1")]
            public void GetCurrentUser([XmlElement("NewX_AVM-DE_CurrentUsername", Namespace="")]out string CurrentUsername)
            {
                object[] results = this.Invoke("GetCurrentUser", new object[] {  });
                CurrentUsername = (string)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:LANConfigSecurity:1#X_AVM-DE_GetAnonymousLogin", RequestElementName = "X_AVM-DE_GetAnonymousLogin", ResponseElementName = "X_AVM-DE_GetAnonymousLoginResponse", RequestNamespace = "urn:dslforum-org:service:LANConfigSecurity:1", ResponseNamespace = "urn:dslforum-org:service:LANConfigSecurity:1")]
            public void GetAnonymousLogin([XmlElement("NewX_AVM-DE_AnonymousLoginEnabled", Namespace="")]out boolean AnonymousLoginEnabled)
            {
                object[] results = this.Invoke("GetAnonymousLogin", new object[] {  });
                AnonymousLoginEnabled = (boolean)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:LANConfigSecurity:1#SetConfigPassword", OneWay=true, RequestNamespace = "urn:dslforum-org:service:LANConfigSecurity:1", ResponseNamespace = "urn:dslforum-org:service:LANConfigSecurity:1")]
            public void SetConfigPassword([XmlElement("NewPassword", Namespace="")]string ConfigPassword)
            {
                this.Invoke("SetConfigPassword", new object[] { ConfigPassword });
            }

        }
        #endregion

        public string ControlURL { get { return "/upnp/control/lanconfigsecurity"; } }
        public SoapHttpClientProtocol SoapHttpClientProtocol { get; set; }

        public Lanconfigsecurity(string url)
        {
            SoapHttpClientProtocol = new lanconfigsecurity()
            {
                Url = url + ControlURL
            };
        }

        public void GetInfo(out ui2 MaxCharsPassword, out ui2 MinCharsPassword, out string AllowedCharsPassword)
        {
            ((lanconfigsecurity)SoapHttpClientProtocol).GetInfo(out MaxCharsPassword, out MinCharsPassword, out AllowedCharsPassword);
        }

        public void GetCurrentUser(out string CurrentUsername)
        {
            ((lanconfigsecurity)SoapHttpClientProtocol).GetCurrentUser(out CurrentUsername);
        }

        public void GetAnonymousLogin(out boolean AnonymousLoginEnabled)
        {
            ((lanconfigsecurity)SoapHttpClientProtocol).GetAnonymousLogin(out AnonymousLoginEnabled);
        }

        public void SetConfigPassword(string ConfigPassword)
        {
            ((lanconfigsecurity)SoapHttpClientProtocol).SetConfigPassword(ConfigPassword);
        }

    }
}
