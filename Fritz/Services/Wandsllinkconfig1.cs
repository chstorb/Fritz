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
    public class Wandsllinkconfig1
    {
        #region SoapHttpClientProtocol
        [WebServiceBinding("urn:dslforum-org:service:WANDSLLinkConfig:1", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        class wandsllinkconfig1 : SoapHttpClientProtocol
        {
            [SoapDocumentMethod("urn:dslforum-org:service:WANDSLLinkConfig:1#GetInfo", RequestNamespace = "urn:dslforum-org:service:WANDSLLinkConfig:1", ResponseNamespace = "urn:dslforum-org:service:WANDSLLinkConfig:1")]
            public void GetInfo([XmlElement("NewEnable", Namespace="")]out boolean Enable, [XmlElement("NewLinkStatus", Namespace="")]out string LinkStatus, [XmlElement("NewLinkType", Namespace="")]out string LinkType, [XmlElement("NewDestinationAddress", Namespace="")]out string DestinationAddress, [XmlElement("NewATMEncapsulation", Namespace="")]out string ATMEncapsulation, [XmlElement("NewAutoConfig", Namespace="")]out boolean AutoConfig, [XmlElement("NewATMQoS", Namespace="")]out string ATMQoS, [XmlElement("NewATMPeakCellRate", Namespace="")]out ui4 ATMPeakCellRate, [XmlElement("NewATMSustainableCellRate", Namespace="")]out ui4 ATMSustainableCellRate)
            {
                object[] results = this.Invoke("GetInfo", new object[] {  });
                Enable = (boolean)results[0];
                LinkStatus = (string)results[1];
                LinkType = (string)results[2];
                DestinationAddress = (string)results[3];
                ATMEncapsulation = (string)results[4];
                AutoConfig = (boolean)results[5];
                ATMQoS = (string)results[6];
                ATMPeakCellRate = (ui4)results[7];
                ATMSustainableCellRate = (ui4)results[8];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANDSLLinkConfig:1#SetEnable", OneWay=true, RequestNamespace = "urn:dslforum-org:service:WANDSLLinkConfig:1", ResponseNamespace = "urn:dslforum-org:service:WANDSLLinkConfig:1")]
            public void SetEnable([XmlElement("NewEnable", Namespace="")]boolean Enable)
            {
                this.Invoke("SetEnable", new object[] { Enable });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANDSLLinkConfig:1#GetAutoConfig", RequestNamespace = "urn:dslforum-org:service:WANDSLLinkConfig:1", ResponseNamespace = "urn:dslforum-org:service:WANDSLLinkConfig:1")]
            public void GetAutoConfig([XmlElement("NewAutoConfig", Namespace="")]out boolean AutoConfig)
            {
                object[] results = this.Invoke("GetAutoConfig", new object[] {  });
                AutoConfig = (boolean)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANDSLLinkConfig:1#SetDSLLinkType", OneWay=true, RequestNamespace = "urn:dslforum-org:service:WANDSLLinkConfig:1", ResponseNamespace = "urn:dslforum-org:service:WANDSLLinkConfig:1")]
            public void SetDSLLinkType([XmlElement("NewLinkType", Namespace="")]string LinkType)
            {
                this.Invoke("SetDSLLinkType", new object[] { LinkType });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANDSLLinkConfig:1#GetDSLLinkInfo", RequestNamespace = "urn:dslforum-org:service:WANDSLLinkConfig:1", ResponseNamespace = "urn:dslforum-org:service:WANDSLLinkConfig:1")]
            public void GetDSLLinkInfo([XmlElement("NewLinkType", Namespace="")]out string LinkType, [XmlElement("NewLinkStatus", Namespace="")]out string LinkStatus)
            {
                object[] results = this.Invoke("GetDSLLinkInfo", new object[] {  });
                LinkType = (string)results[0];
                LinkStatus = (string)results[1];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANDSLLinkConfig:1#SetDestinationAddress", OneWay=true, RequestNamespace = "urn:dslforum-org:service:WANDSLLinkConfig:1", ResponseNamespace = "urn:dslforum-org:service:WANDSLLinkConfig:1")]
            public void SetDestinationAddress([XmlElement("NewDestinationAddress", Namespace="")]string DestinationAddress)
            {
                this.Invoke("SetDestinationAddress", new object[] { DestinationAddress });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANDSLLinkConfig:1#GetDestinationAddress", RequestNamespace = "urn:dslforum-org:service:WANDSLLinkConfig:1", ResponseNamespace = "urn:dslforum-org:service:WANDSLLinkConfig:1")]
            public void GetDestinationAddress([XmlElement("NewDestinationAddress", Namespace="")]out string DestinationAddress)
            {
                object[] results = this.Invoke("GetDestinationAddress", new object[] {  });
                DestinationAddress = (string)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANDSLLinkConfig:1#SetATMEncapsulation", OneWay=true, RequestNamespace = "urn:dslforum-org:service:WANDSLLinkConfig:1", ResponseNamespace = "urn:dslforum-org:service:WANDSLLinkConfig:1")]
            public void SetATMEncapsulation([XmlElement("NewATMEncapsulation", Namespace="")]string ATMEncapsulation)
            {
                this.Invoke("SetATMEncapsulation", new object[] { ATMEncapsulation });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANDSLLinkConfig:1#GetATMEncapsulation", RequestNamespace = "urn:dslforum-org:service:WANDSLLinkConfig:1", ResponseNamespace = "urn:dslforum-org:service:WANDSLLinkConfig:1")]
            public void GetATMEncapsulation([XmlElement("NewATMEncapsulation", Namespace="")]out string ATMEncapsulation)
            {
                object[] results = this.Invoke("GetATMEncapsulation", new object[] {  });
                ATMEncapsulation = (string)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANDSLLinkConfig:1#GetStatistics", RequestNamespace = "urn:dslforum-org:service:WANDSLLinkConfig:1", ResponseNamespace = "urn:dslforum-org:service:WANDSLLinkConfig:1")]
            public void GetStatistics([XmlElement("NewATMTransmittedBlocks", Namespace="")]out ui4 ATMTransmittedBlocks, [XmlElement("NewATMReceivedBlocks", Namespace="")]out ui4 ATMReceivedBlocks, [XmlElement("NewAAL5CRCErrors", Namespace="")]out ui4 AAL5CRCErrors, [XmlElement("NewATMCRCErrors", Namespace="")]out ui4 ATMCRCErrors)
            {
                object[] results = this.Invoke("GetStatistics", new object[] {  });
                ATMTransmittedBlocks = (ui4)results[0];
                ATMReceivedBlocks = (ui4)results[1];
                AAL5CRCErrors = (ui4)results[2];
                ATMCRCErrors = (ui4)results[3];
            }

        }
        #endregion

        public string ControlURL { get { return "/upnp/control/wandsllinkconfig1"; } }
        public SoapHttpClientProtocol SoapHttpClientProtocol { get; set; }

        public Wandsllinkconfig1(string url)
        {
            SoapHttpClientProtocol = new wandsllinkconfig1()
            {
                Url = url + ControlURL
            };
        }

        public void GetInfo(out boolean Enable, out string LinkStatus, out string LinkType, out string DestinationAddress, out string ATMEncapsulation, out boolean AutoConfig, out string ATMQoS, out ui4 ATMPeakCellRate, out ui4 ATMSustainableCellRate)
        {
            ((wandsllinkconfig1)SoapHttpClientProtocol).GetInfo(out Enable, out LinkStatus, out LinkType, out DestinationAddress, out ATMEncapsulation, out AutoConfig, out ATMQoS, out ATMPeakCellRate, out ATMSustainableCellRate);
        }

        public void SetEnable(boolean Enable)
        {
            ((wandsllinkconfig1)SoapHttpClientProtocol).SetEnable(Enable);
        }

        public void GetAutoConfig(out boolean AutoConfig)
        {
            ((wandsllinkconfig1)SoapHttpClientProtocol).GetAutoConfig(out AutoConfig);
        }

        public void SetDSLLinkType(string LinkType)
        {
            ((wandsllinkconfig1)SoapHttpClientProtocol).SetDSLLinkType(LinkType);
        }

        public void GetDSLLinkInfo(out string LinkType, out string LinkStatus)
        {
            ((wandsllinkconfig1)SoapHttpClientProtocol).GetDSLLinkInfo(out LinkType, out LinkStatus);
        }

        public void SetDestinationAddress(string DestinationAddress)
        {
            ((wandsllinkconfig1)SoapHttpClientProtocol).SetDestinationAddress(DestinationAddress);
        }

        public void GetDestinationAddress(out string DestinationAddress)
        {
            ((wandsllinkconfig1)SoapHttpClientProtocol).GetDestinationAddress(out DestinationAddress);
        }

        public void SetATMEncapsulation(string ATMEncapsulation)
        {
            ((wandsllinkconfig1)SoapHttpClientProtocol).SetATMEncapsulation(ATMEncapsulation);
        }

        public void GetATMEncapsulation(out string ATMEncapsulation)
        {
            ((wandsllinkconfig1)SoapHttpClientProtocol).GetATMEncapsulation(out ATMEncapsulation);
        }

        public void GetStatistics(out ui4 ATMTransmittedBlocks, out ui4 ATMReceivedBlocks, out ui4 AAL5CRCErrors, out ui4 ATMCRCErrors)
        {
            ((wandsllinkconfig1)SoapHttpClientProtocol).GetStatistics(out ATMTransmittedBlocks, out ATMReceivedBlocks, out AAL5CRCErrors, out ATMCRCErrors);
        }

    }
}
