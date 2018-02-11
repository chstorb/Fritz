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
    public class Tam
    {
        #region SoapHttpClientProtocol
        [WebServiceBinding("urn:dslforum-org:service:X_AVM-DE_TAM:1", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        class x_tam : SoapHttpClientProtocol
        {
            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_TAM:1#GetInfo", RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_TAM:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_TAM:1")]
            public void GetInfo([XmlElement("NewIndex", Namespace="")]ui2 Index, [XmlElement("NewEnable", Namespace="")]out boolean Enable, [XmlElement("NewName", Namespace="")]out string Name, [XmlElement("NewTAMRunning", Namespace="")]out boolean TAMRunning, [XmlElement("NewStick", Namespace="")]out ui2 Stick, [XmlElement("NewStatus", Namespace="")]out ui2 Status)
            {
                object[] results = this.Invoke("GetInfo", new object[] { Index });
                Enable = (boolean)results[0];
                Name = (string)results[1];
                TAMRunning = (boolean)results[2];
                Stick = (ui2)results[3];
                Status = (ui2)results[4];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_TAM:1#SetEnable", OneWay=true, RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_TAM:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_TAM:1")]
            public void SetEnable([XmlElement("NewIndex", Namespace="")]ui2 Index, [XmlElement("NewEnable", Namespace="")]boolean Enable)
            {
                this.Invoke("SetEnable", new object[] { Index, Enable });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_TAM:1#GetMessageList", RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_TAM:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_TAM:1")]
            public void GetMessageList([XmlElement("NewIndex", Namespace="")]ui2 Index, [XmlElement("NewURL", Namespace="")]out string URL)
            {
                object[] results = this.Invoke("GetMessageList", new object[] { Index });
                URL = (string)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_TAM:1#MarkMessage", OneWay=true, RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_TAM:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_TAM:1")]
            public void MarkMessage([XmlElement("NewIndex", Namespace="")]ui2 Index, [XmlElement("NewMesageIndex", Namespace="")]ui2 MessageIndex)
            {
                this.Invoke("MarkMessage", new object[] { Index, MessageIndex });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_TAM:1#DeleteMessage", OneWay=true, RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_TAM:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_TAM:1")]
            public void DeleteMessage([XmlElement("NewIndex", Namespace="")]ui2 Index, [XmlElement("NewMesageIndex", Namespace="")]ui2 MessageIndex)
            {
                this.Invoke("DeleteMessage", new object[] { Index, MessageIndex });
            }

        }
        #endregion

        public string ControlURL { get { return "/upnp/control/x_tam"; } }
        public SoapHttpClientProtocol SoapHttpClientProtocol { get; set; }

        public Tam(string url)
        {
            SoapHttpClientProtocol = new x_tam()
            {
                Url = url + ControlURL
            };
        }

        public void GetInfo(ui2 Index, out boolean Enable, out string Name, out boolean TAMRunning, out ui2 Stick, out ui2 Status)
        {
            ((x_tam)SoapHttpClientProtocol).GetInfo(Index, out Enable, out Name, out TAMRunning, out Stick, out Status);
        }

        public void SetEnable(ui2 Index, boolean Enable)
        {
            ((x_tam)SoapHttpClientProtocol).SetEnable(Index, Enable);
        }

        public void GetMessageList(ui2 Index, out string URL)
        {
            ((x_tam)SoapHttpClientProtocol).GetMessageList(Index, out URL);
        }

        public void MarkMessage(ui2 Index, ui2 MessageIndex)
        {
            ((x_tam)SoapHttpClientProtocol).MarkMessage(Index, MessageIndex);
        }

        public void DeleteMessage(ui2 Index, ui2 MessageIndex)
        {
            ((x_tam)SoapHttpClientProtocol).DeleteMessage(Index, MessageIndex);
        }

    }
}
