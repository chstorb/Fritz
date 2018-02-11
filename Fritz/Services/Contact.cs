using System;
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
    public class Contact
    {
        #region SoapHttpClientProtocol
        [WebServiceBinding("urn:dslforum-org:service:X_AVM-DE_OnTel:1", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        class x_contact : SoapHttpClientProtocol
        {            
            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_OnTel:1#GetInfo", RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1")]            
            public void GetInfo([XmlElement("NewEnable", Namespace="")]out boolean Enable, [XmlElement("NewStatus", Namespace="")]out string Status, [XmlElement("NewLastConnect", Namespace="")]out string LastConnect, [XmlElement("NewUrl", Namespace="")]out string Url, [XmlElement("NewServiceId", Namespace="")]out string ServiceId, [XmlElement("NewUsername", Namespace="")]out string Username, [XmlElement("NewName", Namespace="")]out string Name)
            {
                object[] results = this.Invoke("GetInfo", new object[] {  });
                Enable = (boolean)results[0];
                Status = (string)results[1];
                LastConnect = (string)results[2];
                Url = (string)results[3];
                ServiceId = (string)results[4];
                Username = (string)results[5];
                Name = (string)results[6];
            }
                        
            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_OnTel:1#SetEnable", OneWay=true, RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1")]
            public void SetEnable([XmlElement("NewEnable", Namespace="")]boolean Enable)
            {
                this.Invoke("SetEnable", new object[] { Enable });
            }
                        
            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_OnTel:1#SetConfig", OneWay=true, RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1")]
            public void SetConfig([XmlElement("NewEnable", Namespace="")]boolean Enable, [XmlElement("NewUrl", Namespace="")]string Url, [XmlElement("NewServiceId", Namespace="")]string ServiceId, [XmlElement("NewUsername", Namespace="")]string Username, [XmlElement("NewPassword", Namespace="")]string Password, [XmlElement("NewName", Namespace="")]string Name)
            {
                this.Invoke("SetConfig", new object[] { Enable, Url, ServiceId, Username, Password, Name });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_OnTel:1#GetInfoByIndex", RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1")]
            public void GetInfoByIndex([XmlElement("NewIndex", Namespace="")]ui2 Index, [XmlElement("NewEnable", Namespace="")]out boolean Enable, [XmlElement("NewStatus", Namespace="")]out string Status, [XmlElement("NewLastConnect", Namespace="")]out string LastConnect, [XmlElement("NewUrl", Namespace="")]out string Url, [XmlElement("NewServiceId", Namespace="")]out string ServiceId, [XmlElement("NewUsername", Namespace="")]out string Username, [XmlElement("NewName", Namespace="")]out string Name)
            {
                object[] results = this.Invoke("GetInfoByIndex", new object[] { Index });
                Enable = (boolean)results[0];
                Status = (string)results[1];
                LastConnect = (string)results[2];
                Url = (string)results[3];
                ServiceId = (string)results[4];
                Username = (string)results[5];
                Name = (string)results[6];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_OnTel:1#SetEnableByIndex", OneWay=true, RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1")]
            public void SetEnableByIndex([XmlElement("NewIndex", Namespace="")]ui2 Index, [XmlElement("NewEnable", Namespace="")]boolean Enable)
            {
                this.Invoke("SetEnableByIndex", new object[] { Index, Enable });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_OnTel:1#SetConfigByIndex", OneWay=true, RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1")]
            public void SetConfigByIndex([XmlElement("NewIndex", Namespace="")]ui2 Index, [XmlElement("NewEnable", Namespace="")]boolean Enable, [XmlElement("NewUrl", Namespace="")]string Url, [XmlElement("NewServiceId", Namespace="")]string ServiceId, [XmlElement("NewUsername", Namespace="")]string Username, [XmlElement("NewPassword", Namespace="")]string Password, [XmlElement("NewName", Namespace="")]string Name)
            {
                this.Invoke("SetConfigByIndex", new object[] { Index, Enable, Url, ServiceId, Username, Password, Name });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_OnTel:1#DeleteByIndex", OneWay=true, RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1")]
            public void DeleteByIndex([XmlElement("NewIndex", Namespace="")]ui2 Index)
            {
                this.Invoke("DeleteByIndex", new object[] { Index });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_OnTel:1#GetNumberOfEntries", RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1")]
            public void GetNumberOfEntries([XmlElement("NewOnTelNumberOfEntries", Namespace="")]out ui2 OnTelNumberOfEntries)
            {
                object[] results = this.Invoke("GetNumberOfEntries", new object[] {  });
                OnTelNumberOfEntries = (ui2)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_OnTel:1#GetCallList", RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1")]
            public void GetCallList([XmlElement("NewCallListURL", Namespace="")]out string CallListURL)
            {
                object[] results = this.Invoke("GetCallList", new object[] {  });
                CallListURL = (string)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_OnTel:1#GetPhonebookList", RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1")]
            public void GetPhonebookList([XmlElement("NewPhonebookList", Namespace="")]out string PhonebookList)
            {
                object[] results = this.Invoke("GetPhonebookList", new object[] {  });
                PhonebookList = (string)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_OnTel:1#GetPhonebook", RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1")]
            public void GetPhonebook([XmlElement("NewPhonebookID", Namespace="")]ui2 PhonebookID, [XmlElement("NewPhonebookName", Namespace="")]out string PhonebookName, [XmlElement("NewPhonebookExtraID", Namespace="")]out string PhonebookExtraID, [XmlElement("NewPhonebookURL", Namespace="")]out string PhonebookURL)
            {
                object[] results = this.Invoke("GetPhonebook", new object[] { PhonebookID });
                PhonebookName = (string)results[0];
                PhonebookExtraID = (string)results[1];
                PhonebookURL = (string)results[2];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_OnTel:1#AddPhonebook", OneWay=true, RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1")]
            public void AddPhonebook([XmlElement("NewPhonebookExtraID", Namespace="")]string PhonebookExtraID, [XmlElement("NewPhonebookName", Namespace="")]string PhonebookName)
            {
                this.Invoke("AddPhonebook", new object[] { PhonebookExtraID, PhonebookName });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_OnTel:1#DeletePhonebook", OneWay=true, RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1")]
            public void DeletePhonebook([XmlElement("NewPhonebookID", Namespace="")]ui2 PhonebookID, [XmlElement("NewPhonebookExtraID", Namespace="")]string PhonebookExtraID)
            {
                this.Invoke("DeletePhonebook", new object[] { PhonebookID, PhonebookExtraID });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_OnTel:1#GetPhonebookEntry", RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1")]
            public void GetPhonebookEntry([XmlElement("NewPhonebookID", Namespace="")]ui2 PhonebookID, [XmlElement("NewPhonebookEntryID", Namespace="")]ui4 PhonebookEntryID, [XmlElement("NewPhonebookEntryData", Namespace="")]out string PhonebookEntryData)
            {
                object[] results = this.Invoke("GetPhonebookEntry", new object[] { PhonebookID, PhonebookEntryID });
                PhonebookEntryData = (string)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_OnTel:1#SetPhonebookEntry", OneWay=true, RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1")]
            public void SetPhonebookEntry([XmlElement("NewPhonebookID", Namespace="")]ui2 PhonebookID, [XmlElement("NewPhonebookEntryID", Namespace="")]ui4 PhonebookEntryID, [XmlElement("NewPhonebookEntryData", Namespace="")]string PhonebookEntryData)
            {
                this.Invoke("SetPhonebookEntry", new object[] { PhonebookID, PhonebookEntryID, PhonebookEntryData });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_OnTel:1#DeletePhonebookEntry", OneWay=true, RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1")]
            public void DeletePhonebookEntry([XmlElement("NewPhonebookID", Namespace="")]ui2 PhonebookID, [XmlElement("NewPhonebookEntryID", Namespace="")]ui4 PhonebookEntryID)
            {
                this.Invoke("DeletePhonebookEntry", new object[] { PhonebookID, PhonebookEntryID });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_OnTel:1#GetDECTHandsetList", RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1")]
            public void GetDECTHandsetList([XmlElement("NewDectIDList", Namespace="")]out string DectIDList)
            {
                object[] results = this.Invoke("GetDECTHandsetList", new object[] {  });
                DectIDList = (string)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_OnTel:1#GetDECTHandsetInfo", RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1")]
            public void GetDECTHandsetInfo([XmlElement("NewDectID", Namespace="")]ui2 DectID, [XmlElement("NewHandsetName", Namespace="")]out string HandsetName, [XmlElement("NewPhonebookID", Namespace="")]out ui2 PhonebookID)
            {
                object[] results = this.Invoke("GetDECTHandsetInfo", new object[] { DectID });
                HandsetName = (string)results[0];
                PhonebookID = (ui2)results[1];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:X_AVM-DE_OnTel:1#SetDECTHandsetPhonebook", OneWay=true, RequestNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1", ResponseNamespace = "urn:dslforum-org:service:X_AVM-DE_OnTel:1")]
            public void SetDECTHandsetPhonebook([XmlElement("NewDectID", Namespace="")]ui2 DectID, [XmlElement("NewPhonebookID", Namespace="")]ui2 PhonebookID)
            {
                this.Invoke("SetDECTHandsetPhonebook", new object[] { DectID, PhonebookID });
            }

        }
        #endregion

        public string ControlURL { get { return "/upnp/control/x_contact"; } }
        public SoapHttpClientProtocol SoapHttpClientProtocol { get; set; }

        public Contact(string url)
        {
            SoapHttpClientProtocol = new x_contact()
            {
                Url = url + ControlURL
            };
        }

        [Obsolete("This action is obsolete and shall not be used any more.")]
        public void GetInfo(out boolean Enable, out string Status, out string LastConnect, out string Url, out string ServiceId, out string Username, out string Name)
        {
            ((x_contact)SoapHttpClientProtocol).GetInfo(out Enable, out Status, out LastConnect, out Url, out ServiceId, out Username, out Name);
        }

        [Obsolete("This action is obsolete and shall not be used any more.")]
        public void SetEnable(boolean Enable)
        {
            ((x_contact)SoapHttpClientProtocol).SetEnable(Enable);
        }

        [Obsolete("This action is obsolete and shall not be used any more.")]
        public void SetConfig(boolean Enable, string Url, string ServiceId, string Username, string Password, string Name)
        {
            ((x_contact)SoapHttpClientProtocol).SetConfig(Enable, Url, ServiceId, Username, Password, Name);
        }

        public void GetInfoByIndex(ui2 Index, out boolean Enable, out string Status, out string LastConnect, out string Url, out string ServiceId, out string Username, out string Name)
        {
            ((x_contact)SoapHttpClientProtocol).GetInfoByIndex(Index, out Enable, out Status, out LastConnect, out Url, out ServiceId, out Username, out Name);
        }

        /// <summary>
        /// The action is used to trigger the telephone book synchronization manually. The synchronization starts if switching from false to true. After enabling, the synchronization is automatically started periodically once within 24 hours. All accounts are triggered to check for updates on COMS by invoking this action. If the revision has not increased, no synchronization will be made.
        /// </summary>
        /// <param name="Index"></param>
        /// <param name="Enable"></param>
        public void SetEnableByIndex(ui2 Index, boolean Enable)
        {
            ((x_contact)SoapHttpClientProtocol).SetEnableByIndex(Index, Enable);
        }

        /// <summary>
        /// If the given index addresses an existing account the configuration is changed. If the index addresses  a new account and the index is OntelNumberOfEntries + 1 then a new account is generated.
        /// </summary>
        /// <param name="Index"></param>
        /// <param name="Enable"></param>
        /// <param name="Url"></param>
        /// <param name="ServiceId"></param>
        /// <param name="Username"></param>
        /// <param name="Password"></param>
        /// <param name="Name"></param>
        public void SetConfigByIndex(ui2 Index, boolean Enable, string Url, string ServiceId, string Username, string Password, string Name)
        {
            ((x_contact)SoapHttpClientProtocol).SetConfigByIndex(Index, Enable, Url, ServiceId, Username, Password, Name);
        }

        public void DeleteByIndex(ui2 Index)
        {
            ((x_contact)SoapHttpClientProtocol).DeleteByIndex(Index);
        }

        public void GetNumberOfEntries(out ui2 OnTelNumberOfEntries)
        {
            ((x_contact)SoapHttpClientProtocol).GetNumberOfEntries(out OnTelNumberOfEntries);
        }

        /// <summary>
        /// The URL can be extended to limit the number of entries in the XML call list file. E.g. max=42 would limit to 42 calls in the list. If the parameter is not set or the value is 0 all calls will be inserted into the call list file. The URL can be extended to fetch a limited number of entries using the parameter days. E.g. days=7 would fetch the calls from now until 7 days in the past. If the parameter is not set or the value is 0 all calls will be inserted into the call list file. 
        /// </summary>
        /// <param name="CallListURL"></param>
        public void GetCallList(out string CallListURL)
        {
            ((x_contact)SoapHttpClientProtocol).GetCallList(out CallListURL);
        }

        public void GetPhonebookList(out string PhonebookList)
        {
            ((x_contact)SoapHttpClientProtocol).GetPhonebookList(out PhonebookList);
        }

        /// <summary>
        /// GetPhonebook
        /// </summary>
        /// <param name="PhonebookID"></param>
        /// <param name="PhonebookName"></param>
        /// <param name="PhonebookExtraID">The value of PhonebookExtraID may be an empty string. </param>
        /// <param name="PhonebookURL"></param>
        public void GetPhonebook(ui2 PhonebookID, out string PhonebookName, out string PhonebookExtraID, out string PhonebookURL)
        {
            ((x_contact)SoapHttpClientProtocol).GetPhonebook(PhonebookID, out PhonebookName, out PhonebookExtraID, out PhonebookURL);
        }

        public void AddPhonebook(string PhonebookExtraID, string PhonebookName)
        {
            ((x_contact)SoapHttpClientProtocol).AddPhonebook(PhonebookExtraID, PhonebookName);
        }

        public void DeletePhonebook(ui2 PhonebookID, string PhonebookExtraID)
        {
            ((x_contact)SoapHttpClientProtocol).DeletePhonebook(PhonebookID, PhonebookExtraID);
        }

        public void GetPhonebookEntry(ui2 PhonebookID, ui4 PhonebookEntryID, out string PhonebookEntryData)
        {
            ((x_contact)SoapHttpClientProtocol).GetPhonebookEntry(PhonebookID, PhonebookEntryID, out PhonebookEntryData);
        }

        /// <summary>
        /// Add new entries with “” as value for PhonebookEntryID. Change existing entries with a value used for PhonebookEntryID with GetPhonebookEntry. The variable PhonebookEntryData may contain a unique ID.
        /// </summary>
        /// <param name="PhonebookID"></param>
        /// <param name="PhonebookEntryID"></param>
        /// <param name="PhonebookEntryData"></param>
        public void SetPhonebookEntry(ui2 PhonebookID, ui4 PhonebookEntryID, string PhonebookEntryData)
        {
            ((x_contact)SoapHttpClientProtocol).SetPhonebookEntry(PhonebookID, PhonebookEntryID, PhonebookEntryData);
        }

        public void DeletePhonebookEntry(ui2 PhonebookID, ui4 PhonebookEntryID)
        {
            ((x_contact)SoapHttpClientProtocol).DeletePhonebookEntry(PhonebookID, PhonebookEntryID);
        }

        public void GetDECTHandsetList(out string DectIDList)
        {
            ((x_contact)SoapHttpClientProtocol).GetDECTHandsetList(out DectIDList);
        }

        public void GetDECTHandsetInfo(ui2 DectID, out string HandsetName, out ui2 PhonebookID)
        {
            ((x_contact)SoapHttpClientProtocol).GetDECTHandsetInfo(DectID, out HandsetName, out PhonebookID);
        }

        public void SetDECTHandsetPhonebook(ui2 DectID, ui2 PhonebookID)
        {
            ((x_contact)SoapHttpClientProtocol).SetDECTHandsetPhonebook(DectID, PhonebookID);
        }

    }
}
