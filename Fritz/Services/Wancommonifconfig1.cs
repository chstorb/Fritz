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
    public class Wancommonifconfig1
    {
        #region SoapHttpClientProtocol
        [WebServiceBinding("urn:dslforum-org:service:WANCommonInterfaceConfig:1", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        class wancommonifconfig1 : SoapHttpClientProtocol
        {
            [SoapDocumentMethod("urn:dslforum-org:service:WANCommonInterfaceConfig:1#GetCommonLinkProperties", RequestNamespace = "urn:dslforum-org:service:WANCommonInterfaceConfig:1", ResponseNamespace = "urn:dslforum-org:service:WANCommonInterfaceConfig:1")]
            public void GetCommonLinkProperties([XmlElement("NewWANAccessType", Namespace="")]out string WANAccessType, [XmlElement("NewLayer1UpstreamMaxBitRate", Namespace="")]out ui4 Layer1UpstreamMaxBitRate, [XmlElement("NewLayer1DownstreamMaxBitRate", Namespace="")]out ui4 Layer1DownstreamMaxBitRate, [XmlElement("NewPhysicalLinkStatus", Namespace="")]out string PhysicalLinkStatus)
            {
                object[] results = this.Invoke("GetCommonLinkProperties", new object[] {  });
                WANAccessType = (string)results[0];
                Layer1UpstreamMaxBitRate = (ui4)results[1];
                Layer1DownstreamMaxBitRate = (ui4)results[2];
                PhysicalLinkStatus = (string)results[3];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANCommonInterfaceConfig:1#GetTotalBytesSent", RequestNamespace = "urn:dslforum-org:service:WANCommonInterfaceConfig:1", ResponseNamespace = "urn:dslforum-org:service:WANCommonInterfaceConfig:1")]
            public void GetTotalBytesSent([XmlElement("NewTotalBytesSent", Namespace="")]out ui4 TotalBytesSent)
            {
                object[] results = this.Invoke("GetTotalBytesSent", new object[] {  });
                TotalBytesSent = (ui4)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANCommonInterfaceConfig:1#GetTotalBytesReceived", RequestNamespace = "urn:dslforum-org:service:WANCommonInterfaceConfig:1", ResponseNamespace = "urn:dslforum-org:service:WANCommonInterfaceConfig:1")]
            public void GetTotalBytesReceived([XmlElement("NewTotalBytesReceived", Namespace="")]out ui4 TotalBytesReceived)
            {
                object[] results = this.Invoke("GetTotalBytesReceived", new object[] {  });
                TotalBytesReceived = (ui4)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANCommonInterfaceConfig:1#GetTotalPacketsSent", RequestNamespace = "urn:dslforum-org:service:WANCommonInterfaceConfig:1", ResponseNamespace = "urn:dslforum-org:service:WANCommonInterfaceConfig:1")]
            public void GetTotalPacketsSent([XmlElement("NewTotalPacketsSent", Namespace="")]out ui4 TotalPacketsSent)
            {
                object[] results = this.Invoke("GetTotalPacketsSent", new object[] {  });
                TotalPacketsSent = (ui4)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANCommonInterfaceConfig:1#GetTotalPacketsReceived", RequestNamespace = "urn:dslforum-org:service:WANCommonInterfaceConfig:1", ResponseNamespace = "urn:dslforum-org:service:WANCommonInterfaceConfig:1")]
            public void GetTotalPacketsReceived([XmlElement("NewTotalPacketsReceived", Namespace="")]out ui4 TotalPacketsReceived)
            {
                object[] results = this.Invoke("GetTotalPacketsReceived", new object[] {  });
                TotalPacketsReceived = (ui4)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANCommonInterfaceConfig:1#X_AVM-DE_SetWANAccessType", OneWay=true, RequestElementName = "X_AVM-DE_SetWANAccessType", ResponseElementName = "X_AVM-DE_SetWANAccessTypeResponse", RequestNamespace = "urn:dslforum-org:service:WANCommonInterfaceConfig:1", ResponseNamespace = "urn:dslforum-org:service:WANCommonInterfaceConfig:1")]
            public void SetWANAccessType([XmlElement("NewAccessType", Namespace="")]string AccessType)
            {
                this.Invoke("SetWANAccessType", new object[] { AccessType });
            }

        }
        #endregion

        public string ControlURL { get { return "/upnp/control/wancommonifconfig1"; } }
        public SoapHttpClientProtocol SoapHttpClientProtocol { get; set; }

        public Wancommonifconfig1(string url)
        {
            SoapHttpClientProtocol = new wancommonifconfig1()
            {
                Url = url + ControlURL
            };
        }

        public void GetCommonLinkProperties(out string WANAccessType, out ui4 Layer1UpstreamMaxBitRate, out ui4 Layer1DownstreamMaxBitRate, out string PhysicalLinkStatus)
        {
            ((wancommonifconfig1)SoapHttpClientProtocol).GetCommonLinkProperties(out WANAccessType, out Layer1UpstreamMaxBitRate, out Layer1DownstreamMaxBitRate, out PhysicalLinkStatus);
        }

        public void GetTotalBytesSent(out ui4 TotalBytesSent)
        {
            ((wancommonifconfig1)SoapHttpClientProtocol).GetTotalBytesSent(out TotalBytesSent);
        }

        public void GetTotalBytesReceived(out ui4 TotalBytesReceived)
        {
            ((wancommonifconfig1)SoapHttpClientProtocol).GetTotalBytesReceived(out TotalBytesReceived);
        }

        public void GetTotalPacketsSent(out ui4 TotalPacketsSent)
        {
            ((wancommonifconfig1)SoapHttpClientProtocol).GetTotalPacketsSent(out TotalPacketsSent);
        }

        public void GetTotalPacketsReceived(out ui4 TotalPacketsReceived)
        {
            ((wancommonifconfig1)SoapHttpClientProtocol).GetTotalPacketsReceived(out TotalPacketsReceived);
        }

        public void SetWANAccessType(string AccessType)
        {
            ((wancommonifconfig1)SoapHttpClientProtocol).SetWANAccessType(AccessType);
        }

    }
}
