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
    public class Voip
    {
        #region SoapHttpClientProtocol
        [WebServiceBinding("urn:dslforum-org:service:X_VoIP:1", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        class x_voip : SoapHttpClientProtocol
        {
            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#GetInfoEx", RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void GetInfoEx([XmlElement("NewVoIPNumberMinChars", Namespace="")]out ui2 VoIPNumberMinChars, [XmlElement("NewVoIPNumberMaxChars", Namespace="")]out ui2 VoIPNumberMaxChars, [XmlElement("NewVoIPNumberAllowedChars", Namespace="")]out string VoIPNumberAllowedChars, [XmlElement("NewVoIPUsernameMinChars", Namespace="")]out ui2 VoIPUsernameMinChars, [XmlElement("NewVoIPUsernameMaxChars", Namespace="")]out ui2 VoIPUsernameMaxChars, [XmlElement("NewVoIPUsernameAllowedChars", Namespace="")]out string VoIPUsernameAllowedChars, [XmlElement("NewVoIPPasswordMinChars", Namespace="")]out ui2 VoIPPasswordMinChars, [XmlElement("NewVoIPPasswordMaxChars", Namespace="")]out ui2 VoIPPasswordMaxChars, [XmlElement("NewVoIPPasswordAllowedChars", Namespace="")]out string VoIPPasswordAllowedChars, [XmlElement("NewVoIPRegistrarMinChars", Namespace="")]out ui2 VoIPRegistrarMinChars, [XmlElement("NewVoIPRegistrarMaxChars", Namespace="")]out ui2 VoIPRegistrarMaxChars, [XmlElement("NewVoIPRegistrarAllowedChars", Namespace="")]out string VoIPRegistrarAllowedChars, [XmlElement("NewVoIPSTUNServerMinChars", Namespace="")]out ui2 VoIPSTUNServerMinChars, [XmlElement("NewVoIPSTUNServerMaxChars", Namespace="")]out ui2 VoIPSTUNServerMaxChars, [XmlElement("NewVoIPSTUNServerAllowedChars", Namespace="")]out string VoIPSTUNServerAllowedChars)
            {
                object[] results = this.Invoke("GetInfoEx", new object[] {  });
                VoIPNumberMinChars = (ui2)results[0];
                VoIPNumberMaxChars = (ui2)results[1];
                VoIPNumberAllowedChars = (string)results[2];
                VoIPUsernameMinChars = (ui2)results[3];
                VoIPUsernameMaxChars = (ui2)results[4];
                VoIPUsernameAllowedChars = (string)results[5];
                VoIPPasswordMinChars = (ui2)results[6];
                VoIPPasswordMaxChars = (ui2)results[7];
                VoIPPasswordAllowedChars = (string)results[8];
                VoIPRegistrarMinChars = (ui2)results[9];
                VoIPRegistrarMaxChars = (ui2)results[10];
                VoIPRegistrarAllowedChars = (string)results[11];
                VoIPSTUNServerMinChars = (ui2)results[12];
                VoIPSTUNServerMaxChars = (ui2)results[13];
                VoIPSTUNServerAllowedChars = (string)results[14];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#X_AVM-DE_AddVoIPAccount", OneWay=true, RequestElementName = "X_AVM-DE_AddVoIPAccount", ResponseElementName = "X_AVM-DE_AddVoIPAccountResponse", RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void AddVoIPAccount([XmlElement("NewVoIPAccountIndex", Namespace="")]ui2 VoIPAccountIndex, [XmlElement("NewVoIPRegistrar", Namespace="")]string VoIPRegistrar, [XmlElement("NewVoIPNumber", Namespace="")]string VoIPNumber, [XmlElement("NewVoIPUsername", Namespace="")]string VoIPUsername, [XmlElement("NewVoIPPassword", Namespace="")]string VoIPPassword, [XmlElement("NewVoIPOutboundProxy", Namespace="")]string VoIPOutboundProxy, [XmlElement("NewVoIPSTUNServer", Namespace="")]string VoIPSTUNServer)
            {
                this.Invoke("AddVoIPAccount", new object[] { VoIPAccountIndex, VoIPRegistrar, VoIPNumber, VoIPUsername, VoIPPassword, VoIPOutboundProxy, VoIPSTUNServer });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#X_AVM-DE_GetVoIPAccount", RequestElementName = "X_AVM-DE_GetVoIPAccount", ResponseElementName = "X_AVM-DE_GetVoIPAccountResponse", RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void GetVoIPAccount([XmlElement("NewVoIPAccountIndex", Namespace="")]ui2 VoIPAccountIndex, [XmlElement("NewVoIPRegistrar", Namespace="")]out string VoIPRegistrar, [XmlElement("NewVoIPNumber", Namespace="")]out string VoIPNumber, [XmlElement("NewVoIPUsername", Namespace="")]out string VoIPUsername, [XmlElement("NewVoIPPassword", Namespace="")]out string VoIPPassword, [XmlElement("NewVoIPOutboundProxy", Namespace="")]out string VoIPOutboundProxy, [XmlElement("NewVoIPSTUNServer", Namespace="")]out string VoIPSTUNServer)
            {
                object[] results = this.Invoke("GetVoIPAccount", new object[] { VoIPAccountIndex });
                VoIPRegistrar = (string)results[0];
                VoIPNumber = (string)results[1];
                VoIPUsername = (string)results[2];
                VoIPPassword = (string)results[3];
                VoIPOutboundProxy = (string)results[4];
                VoIPSTUNServer = (string)results[5];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#X_AVM-DE_DelVoIPAccount", OneWay=true, RequestElementName = "X_AVM-DE_DelVoIPAccount", ResponseElementName = "X_AVM-DE_DelVoIPAccountResponse", RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void DelVoIPAccount([XmlElement("NewVoIPAccountIndex", Namespace="")]ui2 VoIPAccountIndex)
            {
                this.Invoke("DelVoIPAccount", new object[] { VoIPAccountIndex });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#GetInfo", RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void GetInfo([XmlElement("NewFaxT38Enable", Namespace="")]out boolean FaxT38Enable, [XmlElement("NewVoiceCoding", Namespace="")]out string VoiceCoding)
            {
                object[] results = this.Invoke("GetInfo", new object[] {  });
                FaxT38Enable = (boolean)results[0];
                VoiceCoding = (string)results[1];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#SetConfig", OneWay=true, RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void SetConfig([XmlElement("NewFaxT38Enable", Namespace="")]boolean FaxT38Enable, [XmlElement("NewVoiceCoding", Namespace="")]string VoiceCoding)
            {
                this.Invoke("SetConfig", new object[] { FaxT38Enable, VoiceCoding });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#GetMaxVoIPNumbers", RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void GetMaxVoIPNumbers([XmlElement("NewMaxVoIPNumbers", Namespace="")]out ui2 MaxVoIPNumbers)
            {
                object[] results = this.Invoke("GetMaxVoIPNumbers", new object[] {  });
                MaxVoIPNumbers = (ui2)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#GetExistingVoIPNumbers", RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void GetExistingVoIPNumbers([XmlElement("NewExistingVoIPNumbers", Namespace="")]out ui2 ExistingVoIPNumbers)
            {
                object[] results = this.Invoke("GetExistingVoIPNumbers", new object[] {  });
                ExistingVoIPNumbers = (ui2)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#X_AVM-DE_GetNumberOfClients", RequestElementName = "X_AVM-DE_GetNumberOfClients", ResponseElementName = "X_AVM-DE_GetNumberOfClientsResponse", RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void GetNumberOfClients([XmlElement("NewX_AVM-DE_NumberOfClients", Namespace="")]out ui2 NumberOfClients)
            {
                object[] results = this.Invoke("GetNumberOfClients", new object[] {  });
                NumberOfClients = (ui2)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#X_AVM-DE_GetClient", RequestElementName = "X_AVM-DE_GetClient", ResponseElementName = "X_AVM-DE_GetClientResponse", RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void GetClient([XmlElement("NewX_AVM-DE_ClientIndex", Namespace="")]ui2 ClientIndex, [XmlElement("NewX_AVM-DE_ClientUsername", Namespace="")]out string ClientUsername, [XmlElement("NewX_AVM-DE_ClientRegistrar", Namespace="")]out string ClientRegistrar, [XmlElement("NewX_AVM-DE_PhoneName", Namespace="")]out string PhoneName, [XmlElement("NewX_AVM-DE_OutGoingNumber", Namespace="")]out string OutGoingNumber)
            {
                object[] results = this.Invoke("GetClient", new object[] { ClientIndex });
                ClientUsername = (string)results[0];
                ClientRegistrar = (string)results[1];
                PhoneName = (string)results[2];
                OutGoingNumber = (string)results[3];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#X_AVM-DE_GetClient2", RequestElementName = "X_AVM-DE_GetClient2", ResponseElementName = "X_AVM-DE_GetClient2Response", RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void GetClient2([XmlElement("NewX_AVM-DE_ClientIndex", Namespace="")]ui2 ClientIndex, [XmlElement("NewX_AVM-DE_ClientUsername", Namespace="")]out string ClientUsername, [XmlElement("NewX_AVM-DE_ClientRegistrar", Namespace="")]out string ClientRegistrar, [XmlElement("NewX_AVM-DE_PhoneName", Namespace="")]out string PhoneName, [XmlElement("NewX_AVM-DE_ClientId", Namespace="")]out string ClientId, [XmlElement("NewX_AVM-DE_OutGoingNumber", Namespace="")]out string OutGoingNumber)
            {
                object[] results = this.Invoke("GetClient2", new object[] { ClientIndex });
                ClientUsername = (string)results[0];
                ClientRegistrar = (string)results[1];
                PhoneName = (string)results[2];
                ClientId = (string)results[3];
                OutGoingNumber = (string)results[4];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#X_AVM-DE_SetClient", OneWay=true, RequestElementName = "X_AVM-DE_SetClient", ResponseElementName = "X_AVM-DE_SetClientResponse", RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void SetClient([XmlElement("NewX_AVM-DE_ClientIndex", Namespace="")]ui2 ClientIndex, [XmlElement("NewX_AVM-DE_ClientPassword", Namespace="")]string ClientPassword, [XmlElement("NewX_AVM-DE_PhoneName", Namespace="")]string PhoneName, [XmlElement("NewX_AVM-DE_OutGoingNumber", Namespace="")]string OutGoingNumber)
            {
                this.Invoke("SetClient", new object[] { ClientIndex, ClientPassword, PhoneName, OutGoingNumber });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#X_AVM-DE_SetClient2", OneWay=true, RequestElementName = "X_AVM-DE_SetClient2", ResponseElementName = "X_AVM-DE_SetClient2Response", RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void SetClient2([XmlElement("NewX_AVM-DE_ClientIndex", Namespace="")]ui2 ClientIndex, [XmlElement("NewX_AVM-DE_ClientPassword", Namespace="")]string ClientPassword, [XmlElement("NewX_AVM-DE_ClientId", Namespace="")]string ClientId, [XmlElement("NewX_AVM-DE_PhoneName", Namespace="")]string PhoneName, [XmlElement("NewX_AVM-DE_OutGoingNumber", Namespace="")]string OutGoingNumber)
            {
                this.Invoke("SetClient2", new object[] { ClientIndex, ClientPassword, ClientId, PhoneName, OutGoingNumber });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#X_AVM-DE_GetClient3", RequestElementName = "X_AVM-DE_GetClient3", ResponseElementName = "X_AVM-DE_GetClient3Response", RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void GetClient3([XmlElement("NewX_AVM-DE_ClientIndex", Namespace="")]ui2 ClientIndex, [XmlElement("NewX_AVM-DE_ClientUsername", Namespace="")]out string ClientUsername, [XmlElement("NewX_AVM-DE_ClientRegistrar", Namespace="")]out string ClientRegistrar, [XmlElement("NewX_AVM-DE_PhoneName", Namespace="")]out string PhoneName, [XmlElement("NewX_AVM-DE_ClientId", Namespace="")]out string ClientId, [XmlElement("NewX_AVM-DE_OutGoingNumber", Namespace="")]out string OutGoingNumber, [XmlElement("NewX_AVM-DE_InComingNumbers", Namespace="")]out string InComingNumbers, [XmlElement("NewX_AVM-DE_ExternalRegistration", Namespace="")]out boolean ExternalRegistration)
            {
                object[] results = this.Invoke("GetClient3", new object[] { ClientIndex });
                ClientUsername = (string)results[0];
                ClientRegistrar = (string)results[1];
                PhoneName = (string)results[2];
                ClientId = (string)results[3];
                OutGoingNumber = (string)results[4];
                InComingNumbers = (string)results[5];
                ExternalRegistration = (boolean)results[6];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#X_AVM-DE_SetClient3", OneWay=true, RequestElementName = "X_AVM-DE_SetClient3", ResponseElementName = "X_AVM-DE_SetClient3Response", RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void SetClient3([XmlElement("NewX_AVM-DE_ClientIndex", Namespace="")]ui2 ClientIndex, [XmlElement("NewX_AVM-DE_ClientPassword", Namespace="")]string ClientPassword, [XmlElement("NewX_AVM-DE_ClientId", Namespace="")]string ClientId, [XmlElement("NewX_AVM-DE_PhoneName", Namespace="")]string PhoneName, [XmlElement("NewX_AVM-DE_OutGoingNumber", Namespace="")]string OutGoingNumber, [XmlElement("NewX_AVM-DE_InComingNumbers", Namespace="")]string InComingNumbers, [XmlElement("NewX_AVM-DE_ExternalRegistration", Namespace="")]boolean ExternalRegistration)
            {
                this.Invoke("SetClient3", new object[] { ClientIndex, ClientPassword, ClientId, PhoneName, OutGoingNumber, InComingNumbers, ExternalRegistration });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#X_AVM-DE_GetClients", RequestElementName = "X_AVM-DE_GetClients", ResponseElementName = "X_AVM-DE_GetClientsResponse", RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void GetClients([XmlElement("NewX_AVM-DE_ClientList", Namespace="")]out string ClientList)
            {
                object[] results = this.Invoke("GetClients", new object[] {  });
                ClientList = (string)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#X_AVM-DE_GetNumberOfNumbers", RequestElementName = "X_AVM-DE_GetNumberOfNumbers", ResponseElementName = "X_AVM-DE_GetNumberOfNumbersResponse", RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void GetNumberOfNumbers([XmlElement("NewNumberOfNumbers", Namespace="")]out ui4 NumberOfNumbers)
            {
                object[] results = this.Invoke("GetNumberOfNumbers", new object[] {  });
                NumberOfNumbers = (ui4)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#X_AVM-DE_GetNumbers", RequestElementName = "X_AVM-DE_GetNumbers", ResponseElementName = "X_AVM-DE_GetNumbersResponse", RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void GetNumbers([XmlElement("NewNumberList", Namespace="")]out string NumberList)
            {
                object[] results = this.Invoke("GetNumbers", new object[] {  });
                NumberList = (string)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#X_AVM-DE_DeleteClient", OneWay=true, RequestElementName = "X_AVM-DE_DeleteClient", ResponseElementName = "X_AVM-DE_DeleteClientResponse", RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void DeleteClient([XmlElement("NewX_AVM-DE_ClientIndex", Namespace="")]ui2 ClientIndex)
            {
                this.Invoke("DeleteClient", new object[] { ClientIndex });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#X_AVM-DE_DialGetConfig", RequestElementName = "X_AVM-DE_DialGetConfig", ResponseElementName = "X_AVM-DE_DialGetConfigResponse", RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void DialGetConfig([XmlElement("NewX_AVM-DE_PhoneName", Namespace="")]out string PhoneName)
            {
                object[] results = this.Invoke("DialGetConfig", new object[] {  });
                PhoneName = (string)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#X_AVM-DE_DialSetConfig", OneWay=true, RequestElementName = "X_AVM-DE_DialSetConfig", ResponseElementName = "X_AVM-DE_DialSetConfigResponse", RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void DialSetConfig([XmlElement("NewX_AVM-DE_PhoneName", Namespace="")]string PhoneName)
            {
                this.Invoke("DialSetConfig", new object[] { PhoneName });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#X_AVM-DE_DialNumber", OneWay=true, RequestElementName = "X_AVM-DE_DialNumber", ResponseElementName = "X_AVM-DE_DialNumberResponse", RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void DialNumber([XmlElement("NewX_AVM-DE_PhoneNumber", Namespace="")]string PhoneNumber)
            {
                this.Invoke("DialNumber", new object[] { PhoneNumber });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#X_AVM-DE_DialHangup", OneWay=true, RequestElementName = "X_AVM-DE_DialHangup", ResponseElementName = "X_AVM-DE_DialHangupResponse", RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void DialHangup()
            {
                this.Invoke("DialHangup", new object[] {  });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#X_AVM-DE_GetPhonePort", RequestElementName = "X_AVM-DE_GetPhonePort", ResponseElementName = "X_AVM-DE_GetPhonePortResponse", RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void GetPhonePort([XmlElement("NewIndex", Namespace="")]ui2 Index, [XmlElement("NewX_AVM-DE_PhoneName", Namespace="")]out string PhoneName)
            {
                object[] results = this.Invoke("GetPhonePort", new object[] { Index });
                PhoneName = (string)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#GetVoIPCommonCountryCode", RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void GetVoIPCommonCountryCode([XmlElement("NewVoIPCountryCode", Namespace="")]out string VoIPCountryCode)
            {
                object[] results = this.Invoke("GetVoIPCommonCountryCode", new object[] {  });
                VoIPCountryCode = (string)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#SetVoIPCommonCountryCode", OneWay=true, RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void SetVoIPCommonCountryCode([XmlElement("NewVoIPCountryCode", Namespace="")]string VoIPCountryCode)
            {
                this.Invoke("SetVoIPCommonCountryCode", new object[] { VoIPCountryCode });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#GetVoIPEnableCountryCode", RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void GetVoIPEnableCountryCode([XmlElement("NewVoIPAccountIndex", Namespace="")]ui2 VoIPAccountIndex, [XmlElement("NewVoIPEnableCountryCode", Namespace="")]out boolean VoIPEnableCountryCode)
            {
                object[] results = this.Invoke("GetVoIPEnableCountryCode", new object[] { VoIPAccountIndex });
                VoIPEnableCountryCode = (boolean)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#SetVoIPEnableCountryCode", OneWay=true, RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void SetVoIPEnableCountryCode([XmlElement("NewVoIPAccountIndex", Namespace="")]ui2 VoIPAccountIndex, [XmlElement("NewVoIPEnableCountryCode", Namespace="")]boolean VoIPEnableCountryCode)
            {
                this.Invoke("SetVoIPEnableCountryCode", new object[] { VoIPAccountIndex, VoIPEnableCountryCode });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#GetVoIPCommonAreaCode", RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void GetVoIPCommonAreaCode([XmlElement("NewVoIPAreaCode", Namespace="")]out string VoIPAreaCode)
            {
                object[] results = this.Invoke("GetVoIPCommonAreaCode", new object[] {  });
                VoIPAreaCode = (string)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#SetVoIPCommonAreaCode", OneWay=true, RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void SetVoIPCommonAreaCode([XmlElement("NewVoIPAreaCode", Namespace="")]string VoIPAreaCode)
            {
                this.Invoke("SetVoIPCommonAreaCode", new object[] { VoIPAreaCode });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#GetVoIPEnableAreaCode", RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void GetVoIPEnableAreaCode([XmlElement("NewVoIPAccountIndex", Namespace="")]ui2 VoIPAccountIndex, [XmlElement("NewVoIPEnableAreaCode", Namespace="")]out boolean VoIPEnableAreaCode)
            {
                object[] results = this.Invoke("GetVoIPEnableAreaCode", new object[] { VoIPAccountIndex });
                VoIPEnableAreaCode = (boolean)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_VoIP:1#SetVoIPEnableAreaCode", OneWay=true, RequestNamespace = "urn:dslforum-org:service:X_VoIP:1", ResponseNamespace = "urn:dslforum-org:service:X_VoIP:1")]
            public void SetVoIPEnableAreaCode([XmlElement("NewVoIPAccountIndex", Namespace="")]ui2 VoIPAccountIndex, [XmlElement("NewVoIPEnableAreaCode", Namespace="")]boolean VoIPEnableAreaCode)
            {
                this.Invoke("SetVoIPEnableAreaCode", new object[] { VoIPAccountIndex, VoIPEnableAreaCode });
            }

        }
        #endregion

        public string ControlURL { get { return "/upnp/control/x_voip"; } }
        public SoapHttpClientProtocol SoapHttpClientProtocol { get; set; }

        public Voip(string url)
        {
            SoapHttpClientProtocol = new x_voip()
            {
                Url = url + ControlURL
            };
        }

        public void GetInfoEx(out ui2 VoIPNumberMinChars, out ui2 VoIPNumberMaxChars, out string VoIPNumberAllowedChars, out ui2 VoIPUsernameMinChars, out ui2 VoIPUsernameMaxChars, out string VoIPUsernameAllowedChars, out ui2 VoIPPasswordMinChars, out ui2 VoIPPasswordMaxChars, out string VoIPPasswordAllowedChars, out ui2 VoIPRegistrarMinChars, out ui2 VoIPRegistrarMaxChars, out string VoIPRegistrarAllowedChars, out ui2 VoIPSTUNServerMinChars, out ui2 VoIPSTUNServerMaxChars, out string VoIPSTUNServerAllowedChars)
        {
            ((x_voip)SoapHttpClientProtocol).GetInfoEx(out VoIPNumberMinChars, out VoIPNumberMaxChars, out VoIPNumberAllowedChars, out VoIPUsernameMinChars, out VoIPUsernameMaxChars, out VoIPUsernameAllowedChars, out VoIPPasswordMinChars, out VoIPPasswordMaxChars, out VoIPPasswordAllowedChars, out VoIPRegistrarMinChars, out VoIPRegistrarMaxChars, out VoIPRegistrarAllowedChars, out VoIPSTUNServerMinChars, out VoIPSTUNServerMaxChars, out VoIPSTUNServerAllowedChars);
        }

        public void AddVoIPAccount(ui2 VoIPAccountIndex, string VoIPRegistrar, string VoIPNumber, string VoIPUsername, string VoIPPassword, string VoIPOutboundProxy, string VoIPSTUNServer)
        {
            ((x_voip)SoapHttpClientProtocol).AddVoIPAccount(VoIPAccountIndex, VoIPRegistrar, VoIPNumber, VoIPUsername, VoIPPassword, VoIPOutboundProxy, VoIPSTUNServer);
        }

        public void GetVoIPAccount(ui2 VoIPAccountIndex, out string VoIPRegistrar, out string VoIPNumber, out string VoIPUsername, out string VoIPPassword, out string VoIPOutboundProxy, out string VoIPSTUNServer)
        {
            ((x_voip)SoapHttpClientProtocol).GetVoIPAccount(VoIPAccountIndex, out VoIPRegistrar, out VoIPNumber, out VoIPUsername, out VoIPPassword, out VoIPOutboundProxy, out VoIPSTUNServer);
        }

        public void DelVoIPAccount(ui2 VoIPAccountIndex)
        {
            ((x_voip)SoapHttpClientProtocol).DelVoIPAccount(VoIPAccountIndex);
        }

        public void GetInfo(out boolean FaxT38Enable, out string VoiceCoding)
        {
            ((x_voip)SoapHttpClientProtocol).GetInfo(out FaxT38Enable, out VoiceCoding);
        }

        public void SetConfig(boolean FaxT38Enable, string VoiceCoding)
        {
            ((x_voip)SoapHttpClientProtocol).SetConfig(FaxT38Enable, VoiceCoding);
        }

        public void GetMaxVoIPNumbers(out ui2 MaxVoIPNumbers)
        {
            ((x_voip)SoapHttpClientProtocol).GetMaxVoIPNumbers(out MaxVoIPNumbers);
        }

        public void GetExistingVoIPNumbers(out ui2 ExistingVoIPNumbers)
        {
            ((x_voip)SoapHttpClientProtocol).GetExistingVoIPNumbers(out ExistingVoIPNumbers);
        }

        public void GetNumberOfClients(out ui2 NumberOfClients)
        {
            ((x_voip)SoapHttpClientProtocol).GetNumberOfClients(out NumberOfClients);
        }

        public void GetClient(ui2 ClientIndex, out string ClientUsername, out string ClientRegistrar, out string PhoneName, out string OutGoingNumber)
        {
            ((x_voip)SoapHttpClientProtocol).GetClient(ClientIndex, out ClientUsername, out ClientRegistrar, out PhoneName, out OutGoingNumber);
        }

        public void GetClient2(ui2 ClientIndex, out string ClientUsername, out string ClientRegistrar, out string PhoneName, out string ClientId, out string OutGoingNumber)
        {
            ((x_voip)SoapHttpClientProtocol).GetClient2(ClientIndex, out ClientUsername, out ClientRegistrar, out PhoneName, out ClientId, out OutGoingNumber);
        }

        public void SetClient(ui2 ClientIndex, string ClientPassword, string PhoneName, string OutGoingNumber)
        {
            ((x_voip)SoapHttpClientProtocol).SetClient(ClientIndex, ClientPassword, PhoneName, OutGoingNumber);
        }

        public void SetClient2(ui2 ClientIndex, string ClientPassword, string ClientId, string PhoneName, string OutGoingNumber)
        {
            ((x_voip)SoapHttpClientProtocol).SetClient2(ClientIndex, ClientPassword, ClientId, PhoneName, OutGoingNumber);
        }

        public void GetClient3(ui2 ClientIndex, out string ClientUsername, out string ClientRegistrar, out string PhoneName, out string ClientId, out string OutGoingNumber, out string InComingNumbers, out boolean ExternalRegistration)
        {
            ((x_voip)SoapHttpClientProtocol).GetClient3(ClientIndex, out ClientUsername, out ClientRegistrar, out PhoneName, out ClientId, out OutGoingNumber, out InComingNumbers, out ExternalRegistration);
        }

        public void SetClient3(ui2 ClientIndex, string ClientPassword, string ClientId, string PhoneName, string OutGoingNumber, string InComingNumbers, boolean ExternalRegistration)
        {
            ((x_voip)SoapHttpClientProtocol).SetClient3(ClientIndex, ClientPassword, ClientId, PhoneName, OutGoingNumber, InComingNumbers, ExternalRegistration);
        }

        public void GetClients(out string ClientList)
        {
            ((x_voip)SoapHttpClientProtocol).GetClients(out ClientList);
        }

        public void GetNumberOfNumbers(out ui4 NumberOfNumbers)
        {
            ((x_voip)SoapHttpClientProtocol).GetNumberOfNumbers(out NumberOfNumbers);
        }

        public void GetNumbers(out string NumberList)
        {
            ((x_voip)SoapHttpClientProtocol).GetNumbers(out NumberList);
        }

        public void DeleteClient(ui2 ClientIndex)
        {
            ((x_voip)SoapHttpClientProtocol).DeleteClient(ClientIndex);
        }

        public void DialGetConfig(out string PhoneName)
        {
            ((x_voip)SoapHttpClientProtocol).DialGetConfig(out PhoneName);
        }

        public void DialSetConfig(string PhoneName)
        {
            ((x_voip)SoapHttpClientProtocol).DialSetConfig(PhoneName);
        }

        public void DialNumber(string PhoneNumber)
        {
            ((x_voip)SoapHttpClientProtocol).DialNumber(PhoneNumber);
        }

        public void DialHangup()
        {
            ((x_voip)SoapHttpClientProtocol).DialHangup();
        }

        public void GetPhonePort(ui2 Index, out string PhoneName)
        {
            ((x_voip)SoapHttpClientProtocol).GetPhonePort(Index, out PhoneName);
        }

        public void GetVoIPCommonCountryCode(out string VoIPCountryCode)
        {
            ((x_voip)SoapHttpClientProtocol).GetVoIPCommonCountryCode(out VoIPCountryCode);
        }

        public void SetVoIPCommonCountryCode(string VoIPCountryCode)
        {
            ((x_voip)SoapHttpClientProtocol).SetVoIPCommonCountryCode(VoIPCountryCode);
        }

        public void GetVoIPEnableCountryCode(ui2 VoIPAccountIndex, out boolean VoIPEnableCountryCode)
        {
            ((x_voip)SoapHttpClientProtocol).GetVoIPEnableCountryCode(VoIPAccountIndex, out VoIPEnableCountryCode);
        }

        public void SetVoIPEnableCountryCode(ui2 VoIPAccountIndex, boolean VoIPEnableCountryCode)
        {
            ((x_voip)SoapHttpClientProtocol).SetVoIPEnableCountryCode(VoIPAccountIndex, VoIPEnableCountryCode);
        }

        public void GetVoIPCommonAreaCode(out string VoIPAreaCode)
        {
            ((x_voip)SoapHttpClientProtocol).GetVoIPCommonAreaCode(out VoIPAreaCode);
        }

        public void SetVoIPCommonAreaCode(string VoIPAreaCode)
        {
            ((x_voip)SoapHttpClientProtocol).SetVoIPCommonAreaCode(VoIPAreaCode);
        }

        public void GetVoIPEnableAreaCode(ui2 VoIPAccountIndex, out boolean VoIPEnableAreaCode)
        {
            ((x_voip)SoapHttpClientProtocol).GetVoIPEnableAreaCode(VoIPAccountIndex, out VoIPEnableAreaCode);
        }

        public void SetVoIPEnableAreaCode(ui2 VoIPAccountIndex, boolean VoIPEnableAreaCode)
        {
            ((x_voip)SoapHttpClientProtocol).SetVoIPEnableAreaCode(VoIPAccountIndex, VoIPEnableAreaCode);
        }

    }
}
