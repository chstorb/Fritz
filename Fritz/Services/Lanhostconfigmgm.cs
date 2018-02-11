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
    public class Lanhostconfigmgm
    {
        #region SoapHttpClientProtocol
        [WebServiceBinding("urn:dslforum-org:service:LANHostConfigManagement:1", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        class lanhostconfigmgm : SoapHttpClientProtocol
        {
            [SoapDocumentMethod("urn:dslforum-org:service:LANHostConfigManagement:1#GetInfo", RequestNamespace = "urn:dslforum-org:service:LANHostConfigManagement:1", ResponseNamespace = "urn:dslforum-org:service:LANHostConfigManagement:1")]
            public void GetInfo([XmlElement("NewDHCPServerConfigurable", Namespace="")]out boolean DHCPServerConfigurable, [XmlElement("NewDHCPRelay", Namespace="")]out boolean DHCPRelay, [XmlElement("NewMinAddress", Namespace="")]out string MinAddress, [XmlElement("NewMaxAddress", Namespace="")]out string MaxAddress, [XmlElement("NewReservedAddresses", Namespace="")]out string ReservedAddresses, [XmlElement("NewDHCPServerEnable", Namespace="")]out boolean DHCPServerEnable, [XmlElement("NewDNSServers", Namespace="")]out string DNSServers, [XmlElement("NewDomainName", Namespace="")]out string DomainName, [XmlElement("NewIPRouters", Namespace="")]out string IPRouters, [XmlElement("NewSubnetMask", Namespace="")]out string SubnetMask)
            {
                object[] results = this.Invoke("GetInfo", new object[] {  });
                DHCPServerConfigurable = (boolean)results[0];
                DHCPRelay = (boolean)results[1];
                MinAddress = (string)results[2];
                MaxAddress = (string)results[3];
                ReservedAddresses = (string)results[4];
                DHCPServerEnable = (boolean)results[5];
                DNSServers = (string)results[6];
                DomainName = (string)results[7];
                IPRouters = (string)results[8];
                SubnetMask = (string)results[9];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:LANHostConfigManagement:1#SetDHCPServerEnable", OneWay=true, RequestNamespace = "urn:dslforum-org:service:LANHostConfigManagement:1", ResponseNamespace = "urn:dslforum-org:service:LANHostConfigManagement:1")]
            public void SetDHCPServerEnable([XmlElement("NewDHCPServerEnable", Namespace="")]boolean DHCPServerEnable)
            {
                this.Invoke("SetDHCPServerEnable", new object[] { DHCPServerEnable });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:LANHostConfigManagement:1#SetIPInterface", OneWay=true, RequestNamespace = "urn:dslforum-org:service:LANHostConfigManagement:1", ResponseNamespace = "urn:dslforum-org:service:LANHostConfigManagement:1")]
            public void SetIPInterface([XmlElement("NewEnable", Namespace="")]boolean Enable, [XmlElement("NewIPAddress", Namespace="")]string IPInterfaceIPAddress, [XmlElement("NewSubnetMask", Namespace="")]string IPInterfaceSubnetMask, [XmlElement("NewIPAddressingType", Namespace="")]string IPInterfaceIPAddressingType)
            {
                this.Invoke("SetIPInterface", new object[] { Enable, IPInterfaceIPAddress, IPInterfaceSubnetMask, IPInterfaceIPAddressingType });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:LANHostConfigManagement:1#GetAddressRange", RequestNamespace = "urn:dslforum-org:service:LANHostConfigManagement:1", ResponseNamespace = "urn:dslforum-org:service:LANHostConfigManagement:1")]
            public void GetAddressRange([XmlElement("NewMinAddress", Namespace="")]out string MinAddress, [XmlElement("NewMaxAddress", Namespace="")]out string MaxAddress)
            {
                object[] results = this.Invoke("GetAddressRange", new object[] {  });
                MinAddress = (string)results[0];
                MaxAddress = (string)results[1];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:LANHostConfigManagement:1#SetAddressRange", OneWay=true, RequestNamespace = "urn:dslforum-org:service:LANHostConfigManagement:1", ResponseNamespace = "urn:dslforum-org:service:LANHostConfigManagement:1")]
            public void SetAddressRange([XmlElement("NewMinAddress", Namespace="")]string MinAddress, [XmlElement("NewMaxAddress", Namespace="")]string MaxAddress)
            {
                this.Invoke("SetAddressRange", new object[] { MinAddress, MaxAddress });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:LANHostConfigManagement:1#GetIPRoutersList", RequestNamespace = "urn:dslforum-org:service:LANHostConfigManagement:1", ResponseNamespace = "urn:dslforum-org:service:LANHostConfigManagement:1")]
            public void GetIPRoutersList([XmlElement("NewIPRouters", Namespace="")]out string IPRouters)
            {
                object[] results = this.Invoke("GetIPRoutersList", new object[] {  });
                IPRouters = (string)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:LANHostConfigManagement:1#SetIPRouter", OneWay=true, RequestNamespace = "urn:dslforum-org:service:LANHostConfigManagement:1", ResponseNamespace = "urn:dslforum-org:service:LANHostConfigManagement:1")]
            public void SetIPRouter([XmlElement("NewIPRouters", Namespace="")]string IPRouters)
            {
                this.Invoke("SetIPRouter", new object[] { IPRouters });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:LANHostConfigManagement:1#GetSubnetMask", RequestNamespace = "urn:dslforum-org:service:LANHostConfigManagement:1", ResponseNamespace = "urn:dslforum-org:service:LANHostConfigManagement:1")]
            public void GetSubnetMask([XmlElement("NewSubnetMask", Namespace="")]out string SubnetMask)
            {
                object[] results = this.Invoke("GetSubnetMask", new object[] {  });
                SubnetMask = (string)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:LANHostConfigManagement:1#SetSubnetMask", OneWay=true, RequestNamespace = "urn:dslforum-org:service:LANHostConfigManagement:1", ResponseNamespace = "urn:dslforum-org:service:LANHostConfigManagement:1")]
            public void SetSubnetMask([XmlElement("NewSubnetMask", Namespace="")]string SubnetMask)
            {
                this.Invoke("SetSubnetMask", new object[] { SubnetMask });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:LANHostConfigManagement:1#GetDNSServers", RequestNamespace = "urn:dslforum-org:service:LANHostConfigManagement:1", ResponseNamespace = "urn:dslforum-org:service:LANHostConfigManagement:1")]
            public void GetDNSServers([XmlElement("NewDNSServers", Namespace="")]out string DNSServers)
            {
                object[] results = this.Invoke("GetDNSServers", new object[] {  });
                DNSServers = (string)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:LANHostConfigManagement:1#GetIPInterfaceNumberOfEntries", RequestNamespace = "urn:dslforum-org:service:LANHostConfigManagement:1", ResponseNamespace = "urn:dslforum-org:service:LANHostConfigManagement:1")]
            public void GetIPInterfaceNumberOfEntries([XmlElement("NewIPInterfaceNumberOfEntries", Namespace="")]out ui2 IPInterfaceNumberOfEntries)
            {
                object[] results = this.Invoke("GetIPInterfaceNumberOfEntries", new object[] {  });
                IPInterfaceNumberOfEntries = (ui2)results[0];
            }

        }
        #endregion

        public string ControlURL { get { return "/upnp/control/lanhostconfigmgm"; } }
        public SoapHttpClientProtocol SoapHttpClientProtocol { get; set; }

        public Lanhostconfigmgm(string url)
        {
            SoapHttpClientProtocol = new lanhostconfigmgm()
            {
                Url = url + ControlURL
            };
        }

        public void GetInfo(out boolean DHCPServerConfigurable, out boolean DHCPRelay, out string MinAddress, out string MaxAddress, out string ReservedAddresses, out boolean DHCPServerEnable, out string DNSServers, out string DomainName, out string IPRouters, out string SubnetMask)
        {
            ((lanhostconfigmgm)SoapHttpClientProtocol).GetInfo(out DHCPServerConfigurable, out DHCPRelay, out MinAddress, out MaxAddress, out ReservedAddresses, out DHCPServerEnable, out DNSServers, out DomainName, out IPRouters, out SubnetMask);
        }

        public void SetDHCPServerEnable(boolean DHCPServerEnable)
        {
            ((lanhostconfigmgm)SoapHttpClientProtocol).SetDHCPServerEnable(DHCPServerEnable);
        }

        public void SetIPInterface(boolean Enable, string IPInterfaceIPAddress, string IPInterfaceSubnetMask, string IPInterfaceIPAddressingType)
        {
            ((lanhostconfigmgm)SoapHttpClientProtocol).SetIPInterface(Enable, IPInterfaceIPAddress, IPInterfaceSubnetMask, IPInterfaceIPAddressingType);
        }

        public void GetAddressRange(out string MinAddress, out string MaxAddress)
        {
            ((lanhostconfigmgm)SoapHttpClientProtocol).GetAddressRange(out MinAddress, out MaxAddress);
        }

        public void SetAddressRange(string MinAddress, string MaxAddress)
        {
            ((lanhostconfigmgm)SoapHttpClientProtocol).SetAddressRange(MinAddress, MaxAddress);
        }

        public void GetIPRoutersList(out string IPRouters)
        {
            ((lanhostconfigmgm)SoapHttpClientProtocol).GetIPRoutersList(out IPRouters);
        }

        public void SetIPRouter(string IPRouters)
        {
            ((lanhostconfigmgm)SoapHttpClientProtocol).SetIPRouter(IPRouters);
        }

        public void GetSubnetMask(out string SubnetMask)
        {
            ((lanhostconfigmgm)SoapHttpClientProtocol).GetSubnetMask(out SubnetMask);
        }

        public void SetSubnetMask(string SubnetMask)
        {
            ((lanhostconfigmgm)SoapHttpClientProtocol).SetSubnetMask(SubnetMask);
        }

        public void GetDNSServers(out string DNSServers)
        {
            ((lanhostconfigmgm)SoapHttpClientProtocol).GetDNSServers(out DNSServers);
        }

        public void GetIPInterfaceNumberOfEntries(out ui2 IPInterfaceNumberOfEntries)
        {
            ((lanhostconfigmgm)SoapHttpClientProtocol).GetIPInterfaceNumberOfEntries(out IPInterfaceNumberOfEntries);
        }

    }
}
