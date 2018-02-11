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
    public class Deviceconfig
    {
        #region SoapHttpClientProtocol
        [WebServiceBinding("urn:dslforum-org:service:DeviceConfig:1", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        class deviceconfig : SoapHttpClientProtocol
        {
            [SoapDocumentMethod("urn:dslforum-org:service:DeviceConfig:1#GetPersistentData", RequestNamespace = "urn:dslforum-org:service:DeviceConfig:1", ResponseNamespace = "urn:dslforum-org:service:DeviceConfig:1")]
            public void GetPersistentData([XmlElement("NewPersistentData", Namespace="")]out string PersistentData)
            {
                object[] results = this.Invoke("GetPersistentData", new object[] {  });
                PersistentData = (string)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:DeviceConfig:1#SetPersistentData", OneWay=true, RequestNamespace = "urn:dslforum-org:service:DeviceConfig:1", ResponseNamespace = "urn:dslforum-org:service:DeviceConfig:1")]
            public void SetPersistentData([XmlElement("NewPersistentData", Namespace="")]string PersistentData)
            {
                this.Invoke("SetPersistentData", new object[] { PersistentData });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:DeviceConfig:1#ConfigurationStarted", OneWay=true, RequestNamespace = "urn:dslforum-org:service:DeviceConfig:1", ResponseNamespace = "urn:dslforum-org:service:DeviceConfig:1")]
            public void ConfigurationStarted([XmlElement("NewSessionID", Namespace="")]string UUID)
            {
                this.Invoke("ConfigurationStarted", new object[] { UUID });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:DeviceConfig:1#ConfigurationFinished", RequestNamespace = "urn:dslforum-org:service:DeviceConfig:1", ResponseNamespace = "urn:dslforum-org:service:DeviceConfig:1")]
            public void ConfigurationFinished([XmlElement("NewStatus", Namespace="")]out string Status)
            {
                object[] results = this.Invoke("ConfigurationFinished", new object[] {  });
                Status = (string)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:DeviceConfig:1#FactoryReset", OneWay=true, RequestNamespace = "urn:dslforum-org:service:DeviceConfig:1", ResponseNamespace = "urn:dslforum-org:service:DeviceConfig:1")]
            public void FactoryReset()
            {
                this.Invoke("FactoryReset", new object[] {  });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:DeviceConfig:1#Reboot", OneWay=true, RequestNamespace = "urn:dslforum-org:service:DeviceConfig:1", ResponseNamespace = "urn:dslforum-org:service:DeviceConfig:1")]
            public void Reboot()
            {
                this.Invoke("Reboot", new object[] {  });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:DeviceConfig:1#X_GenerateUUID", RequestElementName = "X_GenerateUUID", ResponseElementName = "X_GenerateUUIDResponse", RequestNamespace = "urn:dslforum-org:service:DeviceConfig:1", ResponseNamespace = "urn:dslforum-org:service:DeviceConfig:1")]
            public void GenerateUUID([XmlElement("NewUUID", Namespace="")]out uuid UUID)
            {
                object[] results = this.Invoke("GenerateUUID", new object[] {  });
                UUID = (uuid)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:DeviceConfig:1#X_AVM-DE_GetConfigFile", RequestElementName = "X_AVM-DE_GetConfigFile", ResponseElementName = "X_AVM-DE_GetConfigFileResponse", RequestNamespace = "urn:dslforum-org:service:DeviceConfig:1", ResponseNamespace = "urn:dslforum-org:service:DeviceConfig:1")]
            public void GetConfigFile([XmlElement("NewX_AVM-DE_Password", Namespace="")]string Password, [XmlElement("NewX_AVM-DE_ConfigFileUrl", Namespace="")]out string ConfigFileUrl)
            {
                object[] results = this.Invoke("GetConfigFile", new object[] { Password });
                ConfigFileUrl = (string)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:DeviceConfig:1#X_AVM-DE_SetConfigFile", OneWay=true, RequestElementName = "X_AVM-DE_SetConfigFile", ResponseElementName = "X_AVM-DE_SetConfigFileResponse", RequestNamespace = "urn:dslforum-org:service:DeviceConfig:1", ResponseNamespace = "urn:dslforum-org:service:DeviceConfig:1")]
            public void SetConfigFile([XmlElement("NewX_AVM-DE_Password", Namespace="")]string Password, [XmlElement("NewX_AVM-DE_ConfigFileUrl", Namespace="")]string ConfigFileUrl)
            {
                this.Invoke("SetConfigFile", new object[] { Password, ConfigFileUrl });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:DeviceConfig:1#X_AVM-DE_CreateUrlSID", RequestElementName = "X_AVM-DE_CreateUrlSID", ResponseElementName = "X_AVM-DE_CreateUrlSIDResponse", RequestNamespace = "urn:dslforum-org:service:DeviceConfig:1", ResponseNamespace = "urn:dslforum-org:service:DeviceConfig:1")]
            public void CreateUrlSID([XmlElement("NewX_AVM-DE_UrlSID", Namespace="")]out string UrlSID)
            {
                object[] results = this.Invoke("CreateUrlSID", new object[] {  });
                UrlSID = (string)results[0];
            }

        }
        #endregion

        public string ControlURL { get { return "/upnp/control/deviceconfig"; } }
        public SoapHttpClientProtocol SoapHttpClientProtocol { get; set; }

        public Deviceconfig(string url)
        {
            SoapHttpClientProtocol = new deviceconfig()
            {
                Url = url + ControlURL
            };
        }

        public void GetPersistentData(out string PersistentData)
        {
            ((deviceconfig)SoapHttpClientProtocol).GetPersistentData(out PersistentData);
        }

        public void SetPersistentData(string PersistentData)
        {
            ((deviceconfig)SoapHttpClientProtocol).SetPersistentData(PersistentData);
        }

        public void ConfigurationStarted(string UUID)
        {
            ((deviceconfig)SoapHttpClientProtocol).ConfigurationStarted(UUID);
        }

        public void ConfigurationFinished(out string Status)
        {
            ((deviceconfig)SoapHttpClientProtocol).ConfigurationFinished(out Status);
        }

        public void FactoryReset()
        {
            ((deviceconfig)SoapHttpClientProtocol).FactoryReset();
        }

        public void Reboot()
        {
            ((deviceconfig)SoapHttpClientProtocol).Reboot();
        }

        public void GenerateUUID(out uuid UUID)
        {
            ((deviceconfig)SoapHttpClientProtocol).GenerateUUID(out UUID);
        }

        public void GetConfigFile(string Password, out string ConfigFileUrl)
        {
            ((deviceconfig)SoapHttpClientProtocol).GetConfigFile(Password, out ConfigFileUrl);
        }

        public void SetConfigFile(string Password, string ConfigFileUrl)
        {
            ((deviceconfig)SoapHttpClientProtocol).SetConfigFile(Password, ConfigFileUrl);
        }

        public void CreateUrlSID(out string UrlSID)
        {
            ((deviceconfig)SoapHttpClientProtocol).CreateUrlSID(out UrlSID);
        }
    }
}
