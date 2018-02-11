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
    public class Userif
    {
        #region SoapHttpClientProtocol
        [WebServiceBinding("urn:dslforum-org:service:UserInterface:1", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        class userif : SoapHttpClientProtocol
        {
            [SoapDocumentMethod("urn:dslforum-org:service:UserInterface:1#GetInfo", RequestNamespace = "urn:dslforum-org:service:UserInterface:1", ResponseNamespace = "urn:dslforum-org:service:UserInterface:1")]
            public void GetInfo([XmlElement("NewUpgradeAvailable", Namespace="")]out boolean UpgradeAvailable, [XmlElement("NewPasswordRequired", Namespace="")]out boolean PasswordRequired, [XmlElement("NewPasswordUserSelectable", Namespace="")]out boolean PasswordUserSelectable, [XmlElement("NewWarrantyDate", Namespace="")]out dateTime WarrantyDate, [XmlElement("NewX_AVM-DE_Version", Namespace="")]out string Version, [XmlElement("NewX_AVM-DE_DownloadURL", Namespace="")]out string DownloadURL, [XmlElement("NewX_AVM-DE_InfoURL", Namespace="")]out string InfoURL, [XmlElement("NewX_AVM-DE_UpdateState", Namespace="")]out string UpdateState, [XmlElement("NewX_AVM-DE_LaborVersion", Namespace="")]out string LaborVersion)
            {
                object[] results = this.Invoke("GetInfo", new object[] {  });
                UpgradeAvailable = (boolean)results[0];
                PasswordRequired = (boolean)results[1];
                PasswordUserSelectable = (boolean)results[2];
                WarrantyDate = (dateTime)results[3];
                Version = (string)results[4];
                DownloadURL = (string)results[5];
                InfoURL = (string)results[6];
                UpdateState = (string)results[7];
                LaborVersion = (string)results[8];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:UserInterface:1#X_AVM-DE_CheckUpdate", OneWay=true, RequestElementName = "X_AVM-DE_CheckUpdate", ResponseElementName = "X_AVM-DE_CheckUpdateResponse", RequestNamespace = "urn:dslforum-org:service:UserInterface:1", ResponseNamespace = "urn:dslforum-org:service:UserInterface:1")]
            public void CheckUpdate([XmlElement("NewX_AVM-DE_LaborVersion", Namespace="")]string LaborVersion)
            {
                this.Invoke("CheckUpdate", new object[] { LaborVersion });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:UserInterface:1#X_AVM-DE_DoUpdate", RequestElementName = "X_AVM-DE_DoUpdate", ResponseElementName = "X_AVM-DE_DoUpdateResponse", RequestNamespace = "urn:dslforum-org:service:UserInterface:1", ResponseNamespace = "urn:dslforum-org:service:UserInterface:1")]
            public void DoUpdate([XmlElement("NewUpgradeAvailable", Namespace="")]out boolean UpgradeAvailable, [XmlElement("NewX_AVM-DE_UpdateState", Namespace="")]out string UpdateState)
            {
                object[] results = this.Invoke("DoUpdate", new object[] {  });
                UpgradeAvailable = (boolean)results[0];
                UpdateState = (string)results[1];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:UserInterface:1#X_AVM-DE_DoPrepareCGI", RequestElementName = "X_AVM-DE_DoPrepareCGI", ResponseElementName = "X_AVM-DE_DoPrepareCGIResponse", RequestNamespace = "urn:dslforum-org:service:UserInterface:1", ResponseNamespace = "urn:dslforum-org:service:UserInterface:1")]
            public void DoPrepareCGI([XmlElement("NewX_AVM-DE_CGI", Namespace="")]out string CGI, [XmlElement("NewX_AVM-DE_SessionID", Namespace="")]out string SessionID)
            {
                object[] results = this.Invoke("DoPrepareCGI", new object[] {  });
                CGI = (string)results[0];
                SessionID = (string)results[1];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:UserInterface:1#X_AVM-DE_DoManualUpdate", OneWay=true, RequestElementName = "X_AVM-DE_DoManualUpdate", ResponseElementName = "X_AVM-DE_DoManualUpdateResponse", RequestNamespace = "urn:dslforum-org:service:UserInterface:1", ResponseNamespace = "urn:dslforum-org:service:UserInterface:1")]
            public void DoManualUpdate([XmlElement("NewX_AVM-DE_AllowDowngrade", Namespace="")]boolean AllowDowngrade, [XmlElement("NewX_AVM-DE_DownloadURL", Namespace="")]string DownloadURL)
            {
                this.Invoke("DoManualUpdate", new object[] { AllowDowngrade, DownloadURL });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:UserInterface:1#X_AVM-DE_GetInternationalConfig", RequestElementName = "X_AVM-DE_GetInternationalConfig", ResponseElementName = "X_AVM-DE_GetInternationalConfigResponse", RequestNamespace = "urn:dslforum-org:service:UserInterface:1", ResponseNamespace = "urn:dslforum-org:service:UserInterface:1")]
            public void GetInternationalConfig([XmlElement("NewX_AVM-DE_Language", Namespace="")]out string Language, [XmlElement("NewX_AVM-DE_Country", Namespace="")]out string Country, [XmlElement("NewX_AVM-DE_Annex", Namespace="")]out string Annex, [XmlElement("NewX_AVM-DE_LanguageList", Namespace="")]out string LanguageList, [XmlElement("NewX_AVM-DE_CountryList", Namespace="")]out string CountryList, [XmlElement("NewX_AVM-DE_AnnexList", Namespace="")]out string AnnexList)
            {
                object[] results = this.Invoke("GetInternationalConfig", new object[] {  });
                Language = (string)results[0];
                Country = (string)results[1];
                Annex = (string)results[2];
                LanguageList = (string)results[3];
                CountryList = (string)results[4];
                AnnexList = (string)results[5];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:UserInterface:1#X_AVM-DE_SetInternationalConfig", OneWay=true, RequestElementName = "X_AVM-DE_SetInternationalConfig", ResponseElementName = "X_AVM-DE_SetInternationalConfigResponse", RequestNamespace = "urn:dslforum-org:service:UserInterface:1", ResponseNamespace = "urn:dslforum-org:service:UserInterface:1")]
            public void SetInternationalConfig([XmlElement("NewX_AVM-DE_Language", Namespace="")]string Language, [XmlElement("NewX_AVM-DE_Country", Namespace="")]string Country, [XmlElement("NewX_AVM-DE_Annex", Namespace="")]string Annex)
            {
                this.Invoke("SetInternationalConfig", new object[] { Language, Country, Annex });
            }

        }
        #endregion

        public string ControlURL { get { return "/upnp/control/userif"; } }
        public SoapHttpClientProtocol SoapHttpClientProtocol { get; set; }

        public Userif(string url)
        {
            SoapHttpClientProtocol = new userif()
            {
                Url = url + ControlURL
            };
        }

        public void GetInfo(out boolean UpgradeAvailable, out boolean PasswordRequired, out boolean PasswordUserSelectable, out dateTime WarrantyDate, out string Version, out string DownloadURL, out string InfoURL, out string UpdateState, out string LaborVersion)
        {
            ((userif)SoapHttpClientProtocol).GetInfo(out UpgradeAvailable, out PasswordRequired, out PasswordUserSelectable, out WarrantyDate, out Version, out DownloadURL, out InfoURL, out UpdateState, out LaborVersion);
        }

        public void CheckUpdate(string LaborVersion)
        {
            ((userif)SoapHttpClientProtocol).CheckUpdate(LaborVersion);
        }

        public void DoUpdate(out boolean UpgradeAvailable, out string UpdateState)
        {
            ((userif)SoapHttpClientProtocol).DoUpdate(out UpgradeAvailable, out UpdateState);
        }

        public void DoPrepareCGI(out string CGI, out string SessionID)
        {
            ((userif)SoapHttpClientProtocol).DoPrepareCGI(out CGI, out SessionID);
        }

        public void DoManualUpdate(boolean AllowDowngrade, string DownloadURL)
        {
            ((userif)SoapHttpClientProtocol).DoManualUpdate(AllowDowngrade, DownloadURL);
        }

        public void GetInternationalConfig(out string Language, out string Country, out string Annex, out string LanguageList, out string CountryList, out string AnnexList)
        {
            ((userif)SoapHttpClientProtocol).GetInternationalConfig(out Language, out Country, out Annex, out LanguageList, out CountryList, out AnnexList);
        }

        public void SetInternationalConfig(string Language, string Country, string Annex)
        {
            ((userif)SoapHttpClientProtocol).SetInternationalConfig(Language, Country, Annex);
        }

    }
}
