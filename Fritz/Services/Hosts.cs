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
    public class Hosts
    {
        #region SoapHttpClientProtocol
        [WebServiceBinding("urn:dslforum-org:service:Hosts:1", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        class hosts : SoapHttpClientProtocol
        {
            [SoapDocumentMethod("urn:dslforum-org:service:Hosts:1#GetHostNumberOfEntries", RequestNamespace = "urn:dslforum-org:service:Hosts:1", ResponseNamespace = "urn:dslforum-org:service:Hosts:1")]
            public void GetHostNumberOfEntries([XmlElement("NewHostNumberOfEntries", Namespace="")]out ui2 HostNumberOfEntries)
            {
                object[] results = this.Invoke("GetHostNumberOfEntries", new object[] {  });
                HostNumberOfEntries = (ui2)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:Hosts:1#GetSpecificHostEntry", RequestNamespace = "urn:dslforum-org:service:Hosts:1", ResponseNamespace = "urn:dslforum-org:service:Hosts:1")]
            public void GetSpecificHostEntry([XmlElement("NewMACAddress", Namespace="")]string MACAddress, [XmlElement("NewIPAddress", Namespace="")]out string IPAddress, [XmlElement("NewAddressSource", Namespace="")]out string AddressSource, [XmlElement("NewLeaseTimeRemaining", Namespace="")]out i4 LeaseTimeRemaining, [XmlElement("NewInterfaceType", Namespace="")]out string InterfaceType, [XmlElement("NewActive", Namespace="")]out boolean Active, [XmlElement("NewHostName", Namespace="")]out string HostName)
            {
                object[] results = this.Invoke("GetSpecificHostEntry", new object[] { MACAddress });
                IPAddress = (string)results[0];
                AddressSource = (string)results[1];
                LeaseTimeRemaining = (i4)results[2];
                InterfaceType = (string)results[3];
                Active = (boolean)results[4];
                HostName = (string)results[5];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:Hosts:1#GetGenericHostEntry", RequestNamespace = "urn:dslforum-org:service:Hosts:1", ResponseNamespace = "urn:dslforum-org:service:Hosts:1")]
            public void GetGenericHostEntry([XmlElement("NewIndex", Namespace="")]ui2 HostNumberOfEntries, [XmlElement("NewIPAddress", Namespace="")]out string IPAddress, [XmlElement("NewAddressSource", Namespace="")]out string AddressSource, [XmlElement("NewLeaseTimeRemaining", Namespace="")]out i4 LeaseTimeRemaining, [XmlElement("NewMACAddress", Namespace="")]out string MACAddress, [XmlElement("NewInterfaceType", Namespace="")]out string InterfaceType, [XmlElement("NewActive", Namespace="")]out boolean Active, [XmlElement("NewHostName", Namespace="")]out string HostName)
            {
                object[] results = this.Invoke("GetGenericHostEntry", new object[] { HostNumberOfEntries });
                IPAddress = (string)results[0];
                AddressSource = (string)results[1];
                LeaseTimeRemaining = (i4)results[2];
                MACAddress = (string)results[3];
                InterfaceType = (string)results[4];
                Active = (boolean)results[5];
                HostName = (string)results[6];
            }

        }
        #endregion

        public string ControlURL { get { return "/upnp/control/hosts"; } }
        public SoapHttpClientProtocol SoapHttpClientProtocol { get; set; }

        public Hosts(string url)
        {
            SoapHttpClientProtocol = new hosts()
            {
                Url = url + ControlURL
            };
        }

        public void GetHostNumberOfEntries(out ui2 HostNumberOfEntries)
        {
            ((hosts)SoapHttpClientProtocol).GetHostNumberOfEntries(out HostNumberOfEntries);
        }

        public void GetSpecificHostEntry(string MACAddress, out string IPAddress, out string AddressSource, out i4 LeaseTimeRemaining, out string InterfaceType, out boolean Active, out string HostName)
        {
            ((hosts)SoapHttpClientProtocol).GetSpecificHostEntry(MACAddress, out IPAddress, out AddressSource, out LeaseTimeRemaining, out InterfaceType, out Active, out HostName);
        }

        public void GetGenericHostEntry(ui2 HostNumberOfEntries, out string IPAddress, out string AddressSource, out i4 LeaseTimeRemaining, out string MACAddress, out string InterfaceType, out boolean Active, out string HostName)
        {
            ((hosts)SoapHttpClientProtocol).GetGenericHostEntry(HostNumberOfEntries, out IPAddress, out AddressSource, out LeaseTimeRemaining, out MACAddress, out InterfaceType, out Active, out HostName);
        }

    }
}
