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
    public class Mgmsrv
    {
        #region SoapHttpClientProtocol
        [WebServiceBinding("urn:dslforum-org:service:ManagementServer:1", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        class mgmsrv : SoapHttpClientProtocol
        {
            [SoapDocumentMethod("urn:dslforum-org:service:ManagementServer:1#GetInfo", RequestNamespace = "urn:dslforum-org:service:ManagementServer:1", ResponseNamespace = "urn:dslforum-org:service:ManagementServer:1")]
            public void GetInfo([XmlElement("NewURL", Namespace="")]out string URL, [XmlElement("NewUsername", Namespace="")]out string Username, [XmlElement("NewPeriodicInformEnable", Namespace="")]out boolean PeriodicInformEnable, [XmlElement("NewPeriodicInformInterval", Namespace="")]out ui4 PeriodicInformInterval, [XmlElement("NewPeriodicInformTime", Namespace="")]out dateTime PeriodicInformTime, [XmlElement("NewParameterKey", Namespace="")]out string ParameterKey, [XmlElement("NewParameterHash", Namespace="")]out string ParameterHash, [XmlElement("NewConnectionRequestURL", Namespace="")]out string ConnectionRequestURL, [XmlElement("NewConnectionRequestUsername", Namespace="")]out string ConnectionRequestUsername, [XmlElement("NewUpgradesManaged", Namespace="")]out boolean UpgradesManaged)
            {
                object[] results = this.Invoke("GetInfo", new object[] {  });
                URL = (string)results[0];
                Username = (string)results[1];
                PeriodicInformEnable = (boolean)results[2];
                PeriodicInformInterval = (ui4)results[3];
                PeriodicInformTime = (dateTime)results[4];
                ParameterKey = (string)results[5];
                ParameterHash = (string)results[6];
                ConnectionRequestURL = (string)results[7];
                ConnectionRequestUsername = (string)results[8];
                UpgradesManaged = (boolean)results[9];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:ManagementServer:1#SetManagementServerURL", OneWay=true, RequestNamespace = "urn:dslforum-org:service:ManagementServer:1", ResponseNamespace = "urn:dslforum-org:service:ManagementServer:1")]
            public void SetManagementServerURL([XmlElement("NewURL", Namespace="")]string URL)
            {
                this.Invoke("SetManagementServerURL", new object[] { URL });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:ManagementServer:1#SetManagementServerUsername", OneWay=true, RequestNamespace = "urn:dslforum-org:service:ManagementServer:1", ResponseNamespace = "urn:dslforum-org:service:ManagementServer:1")]
            public void SetManagementServerUsername([XmlElement("NewUsername", Namespace="")]string Username)
            {
                this.Invoke("SetManagementServerUsername", new object[] { Username });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:ManagementServer:1#SetManagementServerPassword", OneWay=true, RequestNamespace = "urn:dslforum-org:service:ManagementServer:1", ResponseNamespace = "urn:dslforum-org:service:ManagementServer:1")]
            public void SetManagementServerPassword([XmlElement("NewPassword", Namespace="")]string Password)
            {
                this.Invoke("SetManagementServerPassword", new object[] { Password });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:ManagementServer:1#SetPeriodicInform", OneWay=true, RequestNamespace = "urn:dslforum-org:service:ManagementServer:1", ResponseNamespace = "urn:dslforum-org:service:ManagementServer:1")]
            public void SetPeriodicInform([XmlElement("NewPeriodicInformEnable", Namespace="")]boolean PeriodicInformEnable, [XmlElement("NewPeriodicInformInterval", Namespace="")]ui4 PeriodicInformInterval, [XmlElement("NewPeriodicInformTime", Namespace="")]dateTime PeriodicInformTime)
            {
                this.Invoke("SetPeriodicInform", new object[] { PeriodicInformEnable, PeriodicInformInterval, PeriodicInformTime });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:ManagementServer:1#SetConnectionRequestAuthentication", OneWay=true, RequestNamespace = "urn:dslforum-org:service:ManagementServer:1", ResponseNamespace = "urn:dslforum-org:service:ManagementServer:1")]
            public void SetConnectionRequestAuthentication([XmlElement("NewConnectionRequestUsername", Namespace="")]string ConnectionRequestUsername, [XmlElement("NewConnectionRequestPassword", Namespace="")]string ConnectionRequestPassword)
            {
                this.Invoke("SetConnectionRequestAuthentication", new object[] { ConnectionRequestUsername, ConnectionRequestPassword });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:ManagementServer:1#SetUpgradeManagement", OneWay=true, RequestNamespace = "urn:dslforum-org:service:ManagementServer:1", ResponseNamespace = "urn:dslforum-org:service:ManagementServer:1")]
            public void SetUpgradeManagement([XmlElement("NewUpgradesManaged", Namespace="")]boolean UpgradesManaged)
            {
                this.Invoke("SetUpgradeManagement", new object[] { UpgradesManaged });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:ManagementServer:1#X_SetTR069Enable", OneWay=true, RequestElementName = "X_SetTR069Enable", ResponseElementName = "X_SetTR069EnableResponse", RequestNamespace = "urn:dslforum-org:service:ManagementServer:1", ResponseNamespace = "urn:dslforum-org:service:ManagementServer:1")]
            public void SetTR069Enable([XmlElement("NewTR069Enabled", Namespace="")]boolean TR069Enabled)
            {
                this.Invoke("SetTR069Enable", new object[] { TR069Enabled });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:ManagementServer:1#X_AVM-DE_GetTR069FirmwareDownloadEnabled", RequestElementName = "X_AVM-DE_GetTR069FirmwareDownloadEnabled", ResponseElementName = "X_AVM-DE_GetTR069FirmwareDownloadEnabledResponse", RequestNamespace = "urn:dslforum-org:service:ManagementServer:1", ResponseNamespace = "urn:dslforum-org:service:ManagementServer:1")]
            public void GetTR069FirmwareDownloadEnabled([XmlElement("NewTR069FirmwareDownloadEnabled", Namespace="")]out boolean TR069FirmwareDownloadEnabled)
            {
                object[] results = this.Invoke("GetTR069FirmwareDownloadEnabled", new object[] {  });
                TR069FirmwareDownloadEnabled = (boolean)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:ManagementServer:1#X_AVM-DE_SetTR069FirmwareDownloadEnabled", OneWay=true, RequestElementName = "X_AVM-DE_SetTR069FirmwareDownloadEnabled", ResponseElementName = "X_AVM-DE_SetTR069FirmwareDownloadEnabledResponse", RequestNamespace = "urn:dslforum-org:service:ManagementServer:1", ResponseNamespace = "urn:dslforum-org:service:ManagementServer:1")]
            public void SetTR069FirmwareDownloadEnabled([XmlElement("NewTR069FirmwareDownloadEnabled", Namespace="")]boolean TR069FirmwareDownloadEnabled)
            {
                this.Invoke("SetTR069FirmwareDownloadEnabled", new object[] { TR069FirmwareDownloadEnabled });
            }

        }
        #endregion

        public string ControlURL { get { return "/upnp/control/mgmsrv"; } }
        public SoapHttpClientProtocol SoapHttpClientProtocol { get; set; }

        public Mgmsrv(string url)
        {
            SoapHttpClientProtocol = new mgmsrv()
            {
                Url = url + ControlURL
            };
        }

        public void GetInfo(out string URL, out string Username, out boolean PeriodicInformEnable, out ui4 PeriodicInformInterval, out dateTime PeriodicInformTime, out string ParameterKey, out string ParameterHash, out string ConnectionRequestURL, out string ConnectionRequestUsername, out boolean UpgradesManaged)
        {
            ((mgmsrv)SoapHttpClientProtocol).GetInfo(out URL, out Username, out PeriodicInformEnable, out PeriodicInformInterval, out PeriodicInformTime, out ParameterKey, out ParameterHash, out ConnectionRequestURL, out ConnectionRequestUsername, out UpgradesManaged);
        }

        public void SetManagementServerURL(string URL)
        {
            ((mgmsrv)SoapHttpClientProtocol).SetManagementServerURL(URL);
        }

        public void SetManagementServerUsername(string Username)
        {
            ((mgmsrv)SoapHttpClientProtocol).SetManagementServerUsername(Username);
        }

        public void SetManagementServerPassword(string Password)
        {
            ((mgmsrv)SoapHttpClientProtocol).SetManagementServerPassword(Password);
        }

        public void SetPeriodicInform(boolean PeriodicInformEnable, ui4 PeriodicInformInterval, dateTime PeriodicInformTime)
        {
            ((mgmsrv)SoapHttpClientProtocol).SetPeriodicInform(PeriodicInformEnable, PeriodicInformInterval, PeriodicInformTime);
        }

        public void SetConnectionRequestAuthentication(string ConnectionRequestUsername, string ConnectionRequestPassword)
        {
            ((mgmsrv)SoapHttpClientProtocol).SetConnectionRequestAuthentication(ConnectionRequestUsername, ConnectionRequestPassword);
        }

        public void SetUpgradeManagement(boolean UpgradesManaged)
        {
            ((mgmsrv)SoapHttpClientProtocol).SetUpgradeManagement(UpgradesManaged);
        }

        public void SetTR069Enable(boolean TR069Enabled)
        {
            ((mgmsrv)SoapHttpClientProtocol).SetTR069Enable(TR069Enabled);
        }

        public void GetTR069FirmwareDownloadEnabled(out boolean TR069FirmwareDownloadEnabled)
        {
            ((mgmsrv)SoapHttpClientProtocol).GetTR069FirmwareDownloadEnabled(out TR069FirmwareDownloadEnabled);
        }

        public void SetTR069FirmwareDownloadEnabled(boolean TR069FirmwareDownloadEnabled)
        {
            ((mgmsrv)SoapHttpClientProtocol).SetTR069FirmwareDownloadEnabled(TR069FirmwareDownloadEnabled);
        }

    }
}
