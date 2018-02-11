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
    public class Wandslifconfig1
    {
        #region SoapHttpClientProtocol
        [WebServiceBinding("urn:dslforum-org:service:WANDSLInterfaceConfig:1", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        class wandslifconfig1 : SoapHttpClientProtocol
        {
            [SoapDocumentMethod("urn:dslforum-org:service:WANDSLInterfaceConfig:1#GetInfo", RequestNamespace = "urn:dslforum-org:service:WANDSLInterfaceConfig:1", ResponseNamespace = "urn:dslforum-org:service:WANDSLInterfaceConfig:1")]
            public void GetInfo([XmlElement("NewEnable", Namespace="")]out boolean Enable, [XmlElement("NewStatus", Namespace="")]out string Status, [XmlElement("NewDataPath", Namespace="")]out string DataPath, [XmlElement("NewUpstreamCurrRate", Namespace="")]out i4 UpstreamCurrRate, [XmlElement("NewDownstreamCurrRate", Namespace="")]out ui4 DownstreamCurrRate, [XmlElement("NewUpstreamMaxRate", Namespace="")]out ui4 UpstreamMaxRate, [XmlElement("NewDownstreamMaxRate", Namespace="")]out ui4 DownstreamMaxRate, [XmlElement("NewUpstreamNoiseMargin", Namespace="")]out ui4 UpstreamNoiseMargin, [XmlElement("NewDownstreamNoiseMargin", Namespace="")]out ui4 DownstreamNoiseMargin, [XmlElement("NewUpstreamAttenuation", Namespace="")]out ui4 UpstreamAttenuation, [XmlElement("NewDownstreamAttenuation", Namespace="")]out ui4 DownstreamAttenuation, [XmlElement("NewATURVendor", Namespace="")]out string ATURVendor, [XmlElement("NewATURCountry", Namespace="")]out string ATURCountry, [XmlElement("NewUpstreamPower", Namespace="")]out ui2 UpstreamPower, [XmlElement("NewDownstreamPower", Namespace="")]out ui2 DownstreamPower)
            {
                object[] results = this.Invoke("GetInfo", new object[] {  });
                Enable = (boolean)results[0];
                Status = (string)results[1];
                DataPath = (string)results[2];
                UpstreamCurrRate = (i4)results[3];
                DownstreamCurrRate = (ui4)results[4];
                UpstreamMaxRate = (ui4)results[5];
                DownstreamMaxRate = (ui4)results[6];
                UpstreamNoiseMargin = (ui4)results[7];
                DownstreamNoiseMargin = (ui4)results[8];
                UpstreamAttenuation = (ui4)results[9];
                DownstreamAttenuation = (ui4)results[10];
                ATURVendor = (string)results[11];
                ATURCountry = (string)results[12];
                UpstreamPower = (ui2)results[13];
                DownstreamPower = (ui2)results[14];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANDSLInterfaceConfig:1#GetStatisticsTotal", RequestNamespace = "urn:dslforum-org:service:WANDSLInterfaceConfig:1", ResponseNamespace = "urn:dslforum-org:service:WANDSLInterfaceConfig:1")]
            public void GetStatisticsTotal([XmlElement("NewReceiveBlocks", Namespace="")]out ui4 Stats_Total_ReceiveBlocks, [XmlElement("NewTransmitBlocks", Namespace="")]out ui4 Stats_Total_TransmitBlocks, [XmlElement("NewCellDelin", Namespace="")]out ui4 Stats_Total_CellDelin, [XmlElement("NewLinkRetrain", Namespace="")]out ui4 Stats_Total_LinkRetrain, [XmlElement("NewInitErrors", Namespace="")]out ui4 Stats_Total_InitErrors, [XmlElement("NewInitTimeouts", Namespace="")]out ui4 Stats_Total_InitTimeouts, [XmlElement("NewLossOfFraming", Namespace="")]out ui4 Stats_Total_LossOfFraming, [XmlElement("NewErroredSecs", Namespace="")]out ui4 Stats_Total_ErroredSecs, [XmlElement("NewSeverelyErroredSecs", Namespace="")]out ui4 Stats_Total_SeverelyErroredSecs, [XmlElement("NewFECErrors", Namespace="")]out ui4 Stats_Total_FECErrors, [XmlElement("NewATUCFECErrors", Namespace="")]out ui4 Stats_Total_ATUCFECErrors, [XmlElement("NewHECErrors", Namespace="")]out ui4 Stats_Total_HECErrors, [XmlElement("NewATUCHECErrors", Namespace="")]out ui4 Stats_Total_ATUCHECErrors, [XmlElement("NewCRCErrors", Namespace="")]out ui4 Stats_Total_CRCErrors, [XmlElement("NewATUCCRCErrors", Namespace="")]out ui4 Stats_Total_ATUCCRCErrors)
            {
                object[] results = this.Invoke("GetStatisticsTotal", new object[] {  });
                Stats_Total_ReceiveBlocks = (ui4)results[0];
                Stats_Total_TransmitBlocks = (ui4)results[1];
                Stats_Total_CellDelin = (ui4)results[2];
                Stats_Total_LinkRetrain = (ui4)results[3];
                Stats_Total_InitErrors = (ui4)results[4];
                Stats_Total_InitTimeouts = (ui4)results[5];
                Stats_Total_LossOfFraming = (ui4)results[6];
                Stats_Total_ErroredSecs = (ui4)results[7];
                Stats_Total_SeverelyErroredSecs = (ui4)results[8];
                Stats_Total_FECErrors = (ui4)results[9];
                Stats_Total_ATUCFECErrors = (ui4)results[10];
                Stats_Total_HECErrors = (ui4)results[11];
                Stats_Total_ATUCHECErrors = (ui4)results[12];
                Stats_Total_CRCErrors = (ui4)results[13];
                Stats_Total_ATUCCRCErrors = (ui4)results[14];
            }

        }
        #endregion

        public string ControlURL { get { return "/upnp/control/wandslifconfig1"; } }
        public SoapHttpClientProtocol SoapHttpClientProtocol { get; set; }

        public Wandslifconfig1(string url)
        {
            SoapHttpClientProtocol = new wandslifconfig1()
            {
                Url = url + ControlURL
            };
        }

        public void GetInfo(out boolean Enable, out string Status, out string DataPath, out i4 UpstreamCurrRate, out ui4 DownstreamCurrRate, out ui4 UpstreamMaxRate, out ui4 DownstreamMaxRate, out ui4 UpstreamNoiseMargin, out ui4 DownstreamNoiseMargin, out ui4 UpstreamAttenuation, out ui4 DownstreamAttenuation, out string ATURVendor, out string ATURCountry, out ui2 UpstreamPower, out ui2 DownstreamPower)
        {
            ((wandslifconfig1)SoapHttpClientProtocol).GetInfo(out Enable, out Status, out DataPath, out UpstreamCurrRate, out DownstreamCurrRate, out UpstreamMaxRate, out DownstreamMaxRate, out UpstreamNoiseMargin, out DownstreamNoiseMargin, out UpstreamAttenuation, out DownstreamAttenuation, out ATURVendor, out ATURCountry, out UpstreamPower, out DownstreamPower);
        }

        public void GetStatisticsTotal(out ui4 Stats_Total_ReceiveBlocks, out ui4 Stats_Total_TransmitBlocks, out ui4 Stats_Total_CellDelin, out ui4 Stats_Total_LinkRetrain, out ui4 Stats_Total_InitErrors, out ui4 Stats_Total_InitTimeouts, out ui4 Stats_Total_LossOfFraming, out ui4 Stats_Total_ErroredSecs, out ui4 Stats_Total_SeverelyErroredSecs, out ui4 Stats_Total_FECErrors, out ui4 Stats_Total_ATUCFECErrors, out ui4 Stats_Total_HECErrors, out ui4 Stats_Total_ATUCHECErrors, out ui4 Stats_Total_CRCErrors, out ui4 Stats_Total_ATUCCRCErrors)
        {
            ((wandslifconfig1)SoapHttpClientProtocol).GetStatisticsTotal(out Stats_Total_ReceiveBlocks, out Stats_Total_TransmitBlocks, out Stats_Total_CellDelin, out Stats_Total_LinkRetrain, out Stats_Total_InitErrors, out Stats_Total_InitTimeouts, out Stats_Total_LossOfFraming, out Stats_Total_ErroredSecs, out Stats_Total_SeverelyErroredSecs, out Stats_Total_FECErrors, out Stats_Total_ATUCFECErrors, out Stats_Total_HECErrors, out Stats_Total_ATUCHECErrors, out Stats_Total_CRCErrors, out Stats_Total_ATUCCRCErrors);
        }

    }
}
