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
    public class Deviceinfo
    {
        #region SoapHttpClientProtocol
        [WebServiceBinding("urn:dslforum-org:service:DeviceInfo:1", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        class deviceinfo : SoapHttpClientProtocol
        {
            [SoapDocumentMethod("urn:dslforum-org:service:DeviceInfo:1#GetInfo", RequestNamespace = "urn:dslforum-org:service:DeviceInfo:1", ResponseNamespace = "urn:dslforum-org:service:DeviceInfo:1")]
            public void GetInfo([XmlElement("NewManufacturerName", Namespace="")]out string ManufacturerName, [XmlElement("NewManufacturerOUI", Namespace="")]out string ManufacturerOUI, [XmlElement("NewModelName", Namespace="")]out string ModelName, [XmlElement("NewDescription", Namespace="")]out string Description, [XmlElement("NewProductClass", Namespace="")]out string ProductClass, [XmlElement("NewSerialNumber", Namespace="")]out string SerialNumber, [XmlElement("NewSoftwareVersion", Namespace="")]out string SoftwareVersion, [XmlElement("NewHardwareVersion", Namespace="")]out string HardwareVersion, [XmlElement("NewSpecVersion", Namespace="")]out string SpecVersion, [XmlElement("NewProvisioningCode", Namespace="")]out string ProvisioningCode, [XmlElement("NewUpTime", Namespace="")]out ui4 UpTime, [XmlElement("NewDeviceLog", Namespace="")]out string DeviceLog)
            {
                object[] results = this.Invoke("GetInfo", new object[] {  });
                ManufacturerName = (string)results[0];
                ManufacturerOUI = (string)results[1];
                ModelName = (string)results[2];
                Description = (string)results[3];
                ProductClass = (string)results[4];
                SerialNumber = (string)results[5];
                SoftwareVersion = (string)results[6];
                HardwareVersion = (string)results[7];
                SpecVersion = (string)results[8];
                ProvisioningCode = (string)results[9];
                UpTime = (ui4)results[10];
                DeviceLog = (string)results[11];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:DeviceInfo:1#SetProvisioningCode", OneWay=true, RequestNamespace = "urn:dslforum-org:service:DeviceInfo:1", ResponseNamespace = "urn:dslforum-org:service:DeviceInfo:1")]
            public void SetProvisioningCode([XmlElement("NewProvisioningCode", Namespace="")]string ProvisioningCode)
            {
                this.Invoke("SetProvisioningCode", new object[] { ProvisioningCode });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:DeviceInfo:1#GetDeviceLog", RequestNamespace = "urn:dslforum-org:service:DeviceInfo:1", ResponseNamespace = "urn:dslforum-org:service:DeviceInfo:1")]
            public void GetDeviceLog([XmlElement("NewDeviceLog", Namespace="")]out string DeviceLog)
            {
                object[] results = this.Invoke("GetDeviceLog", new object[] {  });
                DeviceLog = (string)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:DeviceInfo:1#GetSecurityPort", RequestNamespace = "urn:dslforum-org:service:DeviceInfo:1", ResponseNamespace = "urn:dslforum-org:service:DeviceInfo:1")]
            public void GetSecurityPort([XmlElement("NewSecurityPort", Namespace="")]out ui2 SecurityPort)
            {
                object[] results = this.Invoke("GetSecurityPort", new object[] {  });
                SecurityPort = (ui2)results[0];
            }

        }
        #endregion

        public string ControlURL { get { return "/upnp/control/deviceinfo"; } }
        public SoapHttpClientProtocol SoapHttpClientProtocol { get; set; }

        public Deviceinfo(string url)
        {
            SoapHttpClientProtocol = new deviceinfo()
            {
                Url = url + ControlURL
            };
        }

        public void GetInfo(out string ManufacturerName, out string ManufacturerOUI, out string ModelName, out string Description, out string ProductClass, out string SerialNumber, out string SoftwareVersion, out string HardwareVersion, out string SpecVersion, out string ProvisioningCode, out ui4 UpTime, out string DeviceLog)
        {
            ((deviceinfo)SoapHttpClientProtocol).GetInfo(out ManufacturerName, out ManufacturerOUI, out ModelName, out Description, out ProductClass, out SerialNumber, out SoftwareVersion, out HardwareVersion, out SpecVersion, out ProvisioningCode, out UpTime, out DeviceLog);
        }

        public void SetProvisioningCode(string ProvisioningCode)
        {
            ((deviceinfo)SoapHttpClientProtocol).SetProvisioningCode(ProvisioningCode);
        }

        public void GetDeviceLog(out string DeviceLog)
        {
            ((deviceinfo)SoapHttpClientProtocol).GetDeviceLog(out DeviceLog);
        }

        public void GetSecurityPort(out ui2 SecurityPort)
        {
            ((deviceinfo)SoapHttpClientProtocol).GetSecurityPort(out SecurityPort);
        }

    }
}
