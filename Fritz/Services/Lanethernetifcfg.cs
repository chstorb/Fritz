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
    public class Lanethernetifcfg
    {
        #region SoapHttpClientProtocol
        [WebServiceBinding("urn:dslforum-org:service:LANEthernetInterfaceConfig:1", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        class lanethernetifcfg : SoapHttpClientProtocol
        {
            [SoapDocumentMethod("urn:dslforum-org:service:LANEthernetInterfaceConfig:1#SetEnable", OneWay=true, RequestNamespace = "urn:dslforum-org:service:LANEthernetInterfaceConfig:1", ResponseNamespace = "urn:dslforum-org:service:LANEthernetInterfaceConfig:1")]
            public void SetEnable([XmlElement("NewEnable", Namespace="")]boolean Enable)
            {
                this.Invoke("SetEnable", new object[] { Enable });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:LANEthernetInterfaceConfig:1#GetInfo", RequestNamespace = "urn:dslforum-org:service:LANEthernetInterfaceConfig:1", ResponseNamespace = "urn:dslforum-org:service:LANEthernetInterfaceConfig:1")]
            public void GetInfo([XmlElement("NewEnable", Namespace="")]out boolean Enable, [XmlElement("NewStatus", Namespace="")]out string Status, [XmlElement("NewMACAddress", Namespace="")]out string MACAddress, [XmlElement("NewMaxBitRate", Namespace="")]out string MaxBitRate, [XmlElement("NewDuplexMode", Namespace="")]out string DuplexMode)
            {
                object[] results = this.Invoke("GetInfo", new object[] {  });
                Enable = (boolean)results[0];
                Status = (string)results[1];
                MACAddress = (string)results[2];
                MaxBitRate = (string)results[3];
                DuplexMode = (string)results[4];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:LANEthernetInterfaceConfig:1#GetStatistics", RequestNamespace = "urn:dslforum-org:service:LANEthernetInterfaceConfig:1", ResponseNamespace = "urn:dslforum-org:service:LANEthernetInterfaceConfig:1")]
            public void GetStatistics([XmlElement("NewBytesSent", Namespace="")]out ui4 Stats_BytesSent, [XmlElement("NewBytesReceived", Namespace="")]out ui4 Stats_BytesReceived, [XmlElement("NewPacketsSent", Namespace="")]out ui4 Stats_PacketsSent, [XmlElement("NewPacketsReceived", Namespace="")]out ui4 Stats_PacketsReceived)
            {
                object[] results = this.Invoke("GetStatistics", new object[] {  });
                Stats_BytesSent = (ui4)results[0];
                Stats_BytesReceived = (ui4)results[1];
                Stats_PacketsSent = (ui4)results[2];
                Stats_PacketsReceived = (ui4)results[3];
            }

        }
        #endregion

        public string ControlURL { get { return "/upnp/control/lanethernetifcfg"; } }
        public SoapHttpClientProtocol SoapHttpClientProtocol { get; set; }

        public Lanethernetifcfg(string url)
        {
            SoapHttpClientProtocol = new lanethernetifcfg()
            {
                Url = url + ControlURL
            };
        }

        public void SetEnable(boolean Enable)
        {
            ((lanethernetifcfg)SoapHttpClientProtocol).SetEnable(Enable);
        }

        public void GetInfo(out boolean Enable, out string Status, out string MACAddress, out string MaxBitRate, out string DuplexMode)
        {
            ((lanethernetifcfg)SoapHttpClientProtocol).GetInfo(out Enable, out Status, out MACAddress, out MaxBitRate, out DuplexMode);
        }

        public void GetStatistics(out ui4 Stats_BytesSent, out ui4 Stats_BytesReceived, out ui4 Stats_PacketsSent, out ui4 Stats_PacketsReceived)
        {
            ((lanethernetifcfg)SoapHttpClientProtocol).GetStatistics(out Stats_BytesSent, out Stats_BytesReceived, out Stats_PacketsSent, out Stats_PacketsReceived);
        }

    }
}
