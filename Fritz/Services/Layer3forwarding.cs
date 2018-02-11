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
    public class Layer3forwarding
    {
        #region SoapHttpClientProtocol
        [WebServiceBinding("urn:dslforum-org:service:Layer3Forwarding:1", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        class layer3forwarding : SoapHttpClientProtocol
        {
            [SoapDocumentMethod("urn:dslforum-org:service:Layer3Forwarding:1#SetDefaultConnectionService", OneWay=true, RequestNamespace = "urn:dslforum-org:service:Layer3Forwarding:1", ResponseNamespace = "urn:dslforum-org:service:Layer3Forwarding:1")]
            public void SetDefaultConnectionService([XmlElement("NewDefaultConnectionService", Namespace="")]string DefaultConnectionService)
            {
                this.Invoke("SetDefaultConnectionService", new object[] { DefaultConnectionService });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:Layer3Forwarding:1#GetDefaultConnectionService", RequestNamespace = "urn:dslforum-org:service:Layer3Forwarding:1", ResponseNamespace = "urn:dslforum-org:service:Layer3Forwarding:1")]
            public void GetDefaultConnectionService([XmlElement("NewDefaultConnectionService", Namespace="")]out string DefaultConnectionService)
            {
                object[] results = this.Invoke("GetDefaultConnectionService", new object[] {  });
                DefaultConnectionService = (string)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:Layer3Forwarding:1#GetForwardNumberOfEntries", RequestNamespace = "urn:dslforum-org:service:Layer3Forwarding:1", ResponseNamespace = "urn:dslforum-org:service:Layer3Forwarding:1")]
            public void GetForwardNumberOfEntries([XmlElement("NewForwardNumberOfEntries", Namespace="")]out ui2 ForwardNumberOfEntries)
            {
                object[] results = this.Invoke("GetForwardNumberOfEntries", new object[] {  });
                ForwardNumberOfEntries = (ui2)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:Layer3Forwarding:1#AddForwardingEntry", OneWay=true, RequestNamespace = "urn:dslforum-org:service:Layer3Forwarding:1", ResponseNamespace = "urn:dslforum-org:service:Layer3Forwarding:1")]
            public void AddForwardingEntry([XmlElement("NewType", Namespace="")]string Type, [XmlElement("NewDestIPAddress", Namespace="")]string DestIPAddress, [XmlElement("NewDestSubnetMask", Namespace="")]string DestSubnetMask, [XmlElement("NewSourceIPAddress", Namespace="")]string SourceIPAddress, [XmlElement("NewSourceSubnetMask", Namespace="")]string SourceSubnetMask, [XmlElement("NewGatewayIPAddress", Namespace="")]string GatewayIPAddress, [XmlElement("NewInterface", Namespace="")]string Interface, [XmlElement("NewForwardingMetric", Namespace="")]i4 ForwardingMetric)
            {
                this.Invoke("AddForwardingEntry", new object[] { Type, DestIPAddress, DestSubnetMask, SourceIPAddress, SourceSubnetMask, GatewayIPAddress, Interface, ForwardingMetric });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:Layer3Forwarding:1#DeleteForwardingEntry", OneWay=true, RequestNamespace = "urn:dslforum-org:service:Layer3Forwarding:1", ResponseNamespace = "urn:dslforum-org:service:Layer3Forwarding:1")]
            public void DeleteForwardingEntry([XmlElement("NewDestIPAddress", Namespace="")]string DestIPAddress, [XmlElement("NewDestSubnetMask", Namespace="")]string DestSubnetMask, [XmlElement("NewSourceIPAddress", Namespace="")]string SourceIPAddress, [XmlElement("NewSourceSubnetMask", Namespace="")]string SourceSubnetMask)
            {
                this.Invoke("DeleteForwardingEntry", new object[] { DestIPAddress, DestSubnetMask, SourceIPAddress, SourceSubnetMask });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:Layer3Forwarding:1#GetSpecificForwardingEntry", RequestNamespace = "urn:dslforum-org:service:Layer3Forwarding:1", ResponseNamespace = "urn:dslforum-org:service:Layer3Forwarding:1")]
            public void GetSpecificForwardingEntry([XmlElement("NewDestIPAddress", Namespace="")]string DestIPAddress, [XmlElement("NewDestSubnetMask", Namespace="")]string DestSubnetMask, [XmlElement("NewSourceIPAddress", Namespace="")]string SourceIPAddress, [XmlElement("NewSourceSubnetMask", Namespace="")]string SourceSubnetMask, [XmlElement("NewGatewayIPAddress", Namespace="")]out string GatewayIPAddress, [XmlElement("NewEnable", Namespace="")]out boolean Enable, [XmlElement("NewStatus", Namespace="")]out string Status, [XmlElement("NewType", Namespace="")]out string Type, [XmlElement("NewInterface", Namespace="")]out string Interface, [XmlElement("NewForwardingMetric", Namespace="")]out i4 ForwardingMetric)
            {
                object[] results = this.Invoke("GetSpecificForwardingEntry", new object[] { DestIPAddress, DestSubnetMask, SourceIPAddress, SourceSubnetMask });
                GatewayIPAddress = (string)results[0];
                Enable = (boolean)results[1];
                Status = (string)results[2];
                Type = (string)results[3];
                Interface = (string)results[4];
                ForwardingMetric = (i4)results[5];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:Layer3Forwarding:1#GetGenericForwardingEntry", RequestNamespace = "urn:dslforum-org:service:Layer3Forwarding:1", ResponseNamespace = "urn:dslforum-org:service:Layer3Forwarding:1")]
            public void GetGenericForwardingEntry([XmlElement("NewForwardingIndex", Namespace="")]ui2 ForwardNumberOfEntries, [XmlElement("NewEnable", Namespace="")]out boolean Enable, [XmlElement("NewStatus", Namespace="")]out string Status, [XmlElement("NewType", Namespace="")]out string Type, [XmlElement("NewDestIPAddress", Namespace="")]out string DestIPAddress, [XmlElement("NewDestSubnetMask", Namespace="")]out string DestSubnetMask, [XmlElement("NewSourceIPAddress", Namespace="")]out string SourceIPAddress, [XmlElement("NewSourceSubnetMask", Namespace="")]out string SourceSubnetMask, [XmlElement("NewGatewayIPAddress", Namespace="")]out string GatewayIPAddress, [XmlElement("NewInterface", Namespace="")]out string Interface, [XmlElement("NewForwardingMetric", Namespace="")]out i4 ForwardingMetric)
            {
                object[] results = this.Invoke("GetGenericForwardingEntry", new object[] { ForwardNumberOfEntries });
                Enable = (boolean)results[0];
                Status = (string)results[1];
                Type = (string)results[2];
                DestIPAddress = (string)results[3];
                DestSubnetMask = (string)results[4];
                SourceIPAddress = (string)results[5];
                SourceSubnetMask = (string)results[6];
                GatewayIPAddress = (string)results[7];
                Interface = (string)results[8];
                ForwardingMetric = (i4)results[9];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:Layer3Forwarding:1#SetForwardingEntryEnable", OneWay=true, RequestNamespace = "urn:dslforum-org:service:Layer3Forwarding:1", ResponseNamespace = "urn:dslforum-org:service:Layer3Forwarding:1")]
            public void SetForwardingEntryEnable([XmlElement("NewDestIPAddress", Namespace="")]string DestIPAddress, [XmlElement("NewDestSubnetMask", Namespace="")]string DestSubnetMask, [XmlElement("NewSourceIPAddress", Namespace="")]string SourceIPAddress, [XmlElement("NewSourceSubnetMask", Namespace="")]string SourceSubnetMask, [XmlElement("NewEnable", Namespace="")]boolean Enable)
            {
                this.Invoke("SetForwardingEntryEnable", new object[] { DestIPAddress, DestSubnetMask, SourceIPAddress, SourceSubnetMask, Enable });
            }

        }
        #endregion

        public string ControlURL { get { return "/upnp/control/layer3forwarding"; } }
        public SoapHttpClientProtocol SoapHttpClientProtocol { get; set; }

        public Layer3forwarding(string url)
        {
            SoapHttpClientProtocol = new layer3forwarding()
            {
                Url = url + ControlURL
            };
        }

        public void SetDefaultConnectionService(string DefaultConnectionService)
        {
            ((layer3forwarding)SoapHttpClientProtocol).SetDefaultConnectionService(DefaultConnectionService);
        }

        public void GetDefaultConnectionService(out string DefaultConnectionService)
        {
            ((layer3forwarding)SoapHttpClientProtocol).GetDefaultConnectionService(out DefaultConnectionService);
        }

        public void GetForwardNumberOfEntries(out ui2 ForwardNumberOfEntries)
        {
            ((layer3forwarding)SoapHttpClientProtocol).GetForwardNumberOfEntries(out ForwardNumberOfEntries);
        }

        public void AddForwardingEntry(string Type, string DestIPAddress, string DestSubnetMask, string SourceIPAddress, string SourceSubnetMask, string GatewayIPAddress, string Interface, i4 ForwardingMetric)
        {
            ((layer3forwarding)SoapHttpClientProtocol).AddForwardingEntry(Type, DestIPAddress, DestSubnetMask, SourceIPAddress, SourceSubnetMask, GatewayIPAddress, Interface, ForwardingMetric);
        }

        public void DeleteForwardingEntry(string DestIPAddress, string DestSubnetMask, string SourceIPAddress, string SourceSubnetMask)
        {
            ((layer3forwarding)SoapHttpClientProtocol).DeleteForwardingEntry(DestIPAddress, DestSubnetMask, SourceIPAddress, SourceSubnetMask);
        }

        public void GetSpecificForwardingEntry(string DestIPAddress, string DestSubnetMask, string SourceIPAddress, string SourceSubnetMask, out string GatewayIPAddress, out boolean Enable, out string Status, out string Type, out string Interface, out i4 ForwardingMetric)
        {
            ((layer3forwarding)SoapHttpClientProtocol).GetSpecificForwardingEntry(DestIPAddress, DestSubnetMask, SourceIPAddress, SourceSubnetMask, out GatewayIPAddress, out Enable, out Status, out Type, out Interface, out ForwardingMetric);
        }

        public void GetGenericForwardingEntry(ui2 ForwardNumberOfEntries, out boolean Enable, out string Status, out string Type, out string DestIPAddress, out string DestSubnetMask, out string SourceIPAddress, out string SourceSubnetMask, out string GatewayIPAddress, out string Interface, out i4 ForwardingMetric)
        {
            ((layer3forwarding)SoapHttpClientProtocol).GetGenericForwardingEntry(ForwardNumberOfEntries, out Enable, out Status, out Type, out DestIPAddress, out DestSubnetMask, out SourceIPAddress, out SourceSubnetMask, out GatewayIPAddress, out Interface, out ForwardingMetric);
        }

        public void SetForwardingEntryEnable(string DestIPAddress, string DestSubnetMask, string SourceIPAddress, string SourceSubnetMask, boolean Enable)
        {
            ((layer3forwarding)SoapHttpClientProtocol).SetForwardingEntryEnable(DestIPAddress, DestSubnetMask, SourceIPAddress, SourceSubnetMask, Enable);
        }

    }
}
