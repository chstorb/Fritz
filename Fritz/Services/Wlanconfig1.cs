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
    public class Wlanconfig1
    {
        #region SoapHttpClientProtocol
        [WebServiceBinding("urn:dslforum-org:service:WLANConfiguration:1", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        class wlanconfig1 : SoapHttpClientProtocol
        {
            [SoapDocumentMethod("urn:dslforum-org:service:WLANConfiguration:1#SetEnable", OneWay=true, RequestNamespace = "urn:dslforum-org:service:WLANConfiguration:1", ResponseNamespace = "urn:dslforum-org:service:WLANConfiguration:1")]
            public void SetEnable([XmlElement("NewEnable", Namespace="")]boolean Enable)
            {
                this.Invoke("SetEnable", new object[] { Enable });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WLANConfiguration:1#GetInfo", RequestNamespace = "urn:dslforum-org:service:WLANConfiguration:1", ResponseNamespace = "urn:dslforum-org:service:WLANConfiguration:1")]
            public void GetInfo([XmlElement("NewEnable", Namespace="")]out boolean Enable, [XmlElement("NewStatus", Namespace="")]out string Status, [XmlElement("NewMaxBitRate", Namespace="")]out string MaxBitRate, [XmlElement("NewChannel", Namespace="")]out ui1 Channel, [XmlElement("NewSSID", Namespace="")]out string SSID, [XmlElement("NewBeaconType", Namespace="")]out string BeaconType, [XmlElement("NewMACAddressControlEnabled", Namespace="")]out boolean MACAddressControlEnabled, [XmlElement("NewStandard", Namespace="")]out string Standard, [XmlElement("NewBSSID", Namespace="")]out string BSSID, [XmlElement("NewBasicEncryptionModes", Namespace="")]out string BasicEncryptionModes, [XmlElement("NewBasicAuthenticationMode", Namespace="")]out string BasicAuthenticationMode, [XmlElement("NewMaxCharsSSID", Namespace="")]out ui1 MaxCharsSSID, [XmlElement("NewMinCharsSSID", Namespace="")]out ui1 MinCharsSSID, [XmlElement("NewAllowedCharsSSID", Namespace="")]out string AllowedCharsSSID, [XmlElement("NewMinCharsPSK", Namespace="")]out ui1 MinCharsPSK, [XmlElement("NewMaxCharsPSK", Namespace="")]out ui1 MaxCharsPSK, [XmlElement("NewAllowedCharsPSK", Namespace="")]out string AllowedCharsPSK)
            {
                object[] results = this.Invoke("GetInfo", new object[] {  });
                Enable = (boolean)results[0];
                Status = (string)results[1];
                MaxBitRate = (string)results[2];
                Channel = (ui1)results[3];
                SSID = (string)results[4];
                BeaconType = (string)results[5];
                MACAddressControlEnabled = (boolean)results[6];
                Standard = (string)results[7];
                BSSID = (string)results[8];
                BasicEncryptionModes = (string)results[9];
                BasicAuthenticationMode = (string)results[10];
                MaxCharsSSID = (ui1)results[11];
                MinCharsSSID = (ui1)results[12];
                AllowedCharsSSID = (string)results[13];
                MinCharsPSK = (ui1)results[14];
                MaxCharsPSK = (ui1)results[15];
                AllowedCharsPSK = (string)results[16];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WLANConfiguration:1#SetConfig", OneWay=true, RequestNamespace = "urn:dslforum-org:service:WLANConfiguration:1", ResponseNamespace = "urn:dslforum-org:service:WLANConfiguration:1")]
            public void SetConfig([XmlElement("NewMaxBitRate", Namespace="")]string MaxBitRate, [XmlElement("NewChannel", Namespace="")]ui1 Channel, [XmlElement("NewSSID", Namespace="")]string SSID, [XmlElement("NewBeaconType", Namespace="")]string BeaconType, [XmlElement("NewMACAddressControlEnabled", Namespace="")]boolean MACAddressControlEnabled, [XmlElement("NewBasicEncryptionModes", Namespace="")]string BasicEncryptionModes, [XmlElement("NewBasicAuthenticationMode", Namespace="")]string BasicAuthenticationMode)
            {
                this.Invoke("SetConfig", new object[] { MaxBitRate, Channel, SSID, BeaconType, MACAddressControlEnabled, BasicEncryptionModes, BasicAuthenticationMode });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WLANConfiguration:1#SetSecurityKeys", OneWay=true, RequestNamespace = "urn:dslforum-org:service:WLANConfiguration:1", ResponseNamespace = "urn:dslforum-org:service:WLANConfiguration:1")]
            public void SetSecurityKeys([XmlElement("NewWEPKey0", Namespace="")]string WEPKey0, [XmlElement("NewWEPKey1", Namespace="")]string WEPKey1, [XmlElement("NewWEPKey2", Namespace="")]string WEPKey2, [XmlElement("NewWEPKey3", Namespace="")]string WEPKey3, [XmlElement("NewPreSharedKey", Namespace="")]string PreSharedKey, [XmlElement("NewKeyPassphrase", Namespace="")]string KeyPassphrase)
            {
                this.Invoke("SetSecurityKeys", new object[] { WEPKey0, WEPKey1, WEPKey2, WEPKey3, PreSharedKey, KeyPassphrase });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WLANConfiguration:1#GetSecurityKeys", RequestNamespace = "urn:dslforum-org:service:WLANConfiguration:1", ResponseNamespace = "urn:dslforum-org:service:WLANConfiguration:1")]
            public void GetSecurityKeys([XmlElement("NewWEPKey0", Namespace="")]out string WEPKey0, [XmlElement("NewWEPKey1", Namespace="")]out string WEPKey1, [XmlElement("NewWEPKey2", Namespace="")]out string WEPKey2, [XmlElement("NewWEPKey3", Namespace="")]out string WEPKey3, [XmlElement("NewPreSharedKey", Namespace="")]out string PreSharedKey, [XmlElement("NewKeyPassphrase", Namespace="")]out string KeyPassphrase)
            {
                object[] results = this.Invoke("GetSecurityKeys", new object[] {  });
                WEPKey0 = (string)results[0];
                WEPKey1 = (string)results[1];
                WEPKey2 = (string)results[2];
                WEPKey3 = (string)results[3];
                PreSharedKey = (string)results[4];
                KeyPassphrase = (string)results[5];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WLANConfiguration:1#SetDefaultWEPKeyIndex", OneWay=true, RequestNamespace = "urn:dslforum-org:service:WLANConfiguration:1", ResponseNamespace = "urn:dslforum-org:service:WLANConfiguration:1")]
            public void SetDefaultWEPKeyIndex([XmlElement("NewDefaultWEPKeyIndex", Namespace="")]ui1 WEPKeyIndex)
            {
                this.Invoke("SetDefaultWEPKeyIndex", new object[] { WEPKeyIndex });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WLANConfiguration:1#GetDefaultWEPKeyIndex", RequestNamespace = "urn:dslforum-org:service:WLANConfiguration:1", ResponseNamespace = "urn:dslforum-org:service:WLANConfiguration:1")]
            public void GetDefaultWEPKeyIndex([XmlElement("NewDefaultWEPKeyIndex", Namespace="")]out ui1 WEPKeyIndex)
            {
                object[] results = this.Invoke("GetDefaultWEPKeyIndex", new object[] {  });
                WEPKeyIndex = (ui1)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WLANConfiguration:1#SetBasBeaconSecurityProperties", OneWay=true, RequestNamespace = "urn:dslforum-org:service:WLANConfiguration:1", ResponseNamespace = "urn:dslforum-org:service:WLANConfiguration:1")]
            public void SetBasBeaconSecurityProperties([XmlElement("NewBasicEncryptionModes", Namespace="")]string BasicEncryptionModes, [XmlElement("NewBasicAuthenticationMode", Namespace="")]string BasicAuthenticationMode)
            {
                this.Invoke("SetBasBeaconSecurityProperties", new object[] { BasicEncryptionModes, BasicAuthenticationMode });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WLANConfiguration:1#GetBasBeaconSecurityProperties", RequestNamespace = "urn:dslforum-org:service:WLANConfiguration:1", ResponseNamespace = "urn:dslforum-org:service:WLANConfiguration:1")]
            public void GetBasBeaconSecurityProperties([XmlElement("NewBasicEncryptionModes", Namespace="")]out string BasicEncryptionModes, [XmlElement("NewBasicAuthenticationMode", Namespace="")]out string BasicAuthenticationMode)
            {
                object[] results = this.Invoke("GetBasBeaconSecurityProperties", new object[] {  });
                BasicEncryptionModes = (string)results[0];
                BasicAuthenticationMode = (string)results[1];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WLANConfiguration:1#GetStatistics", RequestNamespace = "urn:dslforum-org:service:WLANConfiguration:1", ResponseNamespace = "urn:dslforum-org:service:WLANConfiguration:1")]
            public void GetStatistics([XmlElement("NewTotalPacketsSent", Namespace="")]out ui4 TotalPacketsSent, [XmlElement("NewTotalPacketsReceived", Namespace="")]out ui4 TotalPacketsReceived)
            {
                object[] results = this.Invoke("GetStatistics", new object[] {  });
                TotalPacketsSent = (ui4)results[0];
                TotalPacketsReceived = (ui4)results[1];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WLANConfiguration:1#GetPacketStatistics", RequestNamespace = "urn:dslforum-org:service:WLANConfiguration:1", ResponseNamespace = "urn:dslforum-org:service:WLANConfiguration:1")]
            public void GetPacketStatistics([XmlElement("NewTotalPacketsSent", Namespace="")]out ui4 TotalPacketsSent, [XmlElement("NewTotalPacketsReceived", Namespace="")]out ui4 TotalPacketsReceived)
            {
                object[] results = this.Invoke("GetPacketStatistics", new object[] {  });
                TotalPacketsSent = (ui4)results[0];
                TotalPacketsReceived = (ui4)results[1];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WLANConfiguration:1#GetBSSID", RequestNamespace = "urn:dslforum-org:service:WLANConfiguration:1", ResponseNamespace = "urn:dslforum-org:service:WLANConfiguration:1")]
            public void GetBSSID([XmlElement("NewBSSID", Namespace="")]out string BSSID)
            {
                object[] results = this.Invoke("GetBSSID", new object[] {  });
                BSSID = (string)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WLANConfiguration:1#GetSSID", RequestNamespace = "urn:dslforum-org:service:WLANConfiguration:1", ResponseNamespace = "urn:dslforum-org:service:WLANConfiguration:1")]
            public void GetSSID([XmlElement("NewSSID", Namespace="")]out string SSID)
            {
                object[] results = this.Invoke("GetSSID", new object[] {  });
                SSID = (string)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WLANConfiguration:1#SetSSID", OneWay=true, RequestNamespace = "urn:dslforum-org:service:WLANConfiguration:1", ResponseNamespace = "urn:dslforum-org:service:WLANConfiguration:1")]
            public void SetSSID([XmlElement("NewSSID", Namespace="")]string SSID)
            {
                this.Invoke("SetSSID", new object[] { SSID });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WLANConfiguration:1#GetBeaconType", RequestNamespace = "urn:dslforum-org:service:WLANConfiguration:1", ResponseNamespace = "urn:dslforum-org:service:WLANConfiguration:1")]
            public void GetBeaconType([XmlElement("NewBeaconType", Namespace="")]out string BeaconType)
            {
                object[] results = this.Invoke("GetBeaconType", new object[] {  });
                BeaconType = (string)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WLANConfiguration:1#SetBeaconType", OneWay=true, RequestNamespace = "urn:dslforum-org:service:WLANConfiguration:1", ResponseNamespace = "urn:dslforum-org:service:WLANConfiguration:1")]
            public void SetBeaconType([XmlElement("NewBeaconType", Namespace="")]string BeaconType)
            {
                this.Invoke("SetBeaconType", new object[] { BeaconType });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WLANConfiguration:1#GetChannelInfo", RequestNamespace = "urn:dslforum-org:service:WLANConfiguration:1", ResponseNamespace = "urn:dslforum-org:service:WLANConfiguration:1")]
            public void GetChannelInfo([XmlElement("NewChannel", Namespace="")]out ui1 Channel, [XmlElement("NewPossibleChannels", Namespace="")]out string PossibleChannels)
            {
                object[] results = this.Invoke("GetChannelInfo", new object[] {  });
                Channel = (ui1)results[0];
                PossibleChannels = (string)results[1];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WLANConfiguration:1#SetChannel", OneWay=true, RequestNamespace = "urn:dslforum-org:service:WLANConfiguration:1", ResponseNamespace = "urn:dslforum-org:service:WLANConfiguration:1")]
            public void SetChannel([XmlElement("NewChannel", Namespace="")]ui1 Channel)
            {
                this.Invoke("SetChannel", new object[] { Channel });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WLANConfiguration:1#GetBeaconAdvertisement", RequestNamespace = "urn:dslforum-org:service:WLANConfiguration:1", ResponseNamespace = "urn:dslforum-org:service:WLANConfiguration:1")]
            public void GetBeaconAdvertisement([XmlElement("NewBeaconAdvertisementEnabled", Namespace="")]out boolean BeaconAdvertisementEnabled)
            {
                object[] results = this.Invoke("GetBeaconAdvertisement", new object[] {  });
                BeaconAdvertisementEnabled = (boolean)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WLANConfiguration:1#SetBeaconAdvertisement", OneWay=true, RequestNamespace = "urn:dslforum-org:service:WLANConfiguration:1", ResponseNamespace = "urn:dslforum-org:service:WLANConfiguration:1")]
            public void SetBeaconAdvertisement([XmlElement("NewBeaconAdvertisementEnabled", Namespace="")]boolean BeaconAdvertisementEnabled)
            {
                this.Invoke("SetBeaconAdvertisement", new object[] { BeaconAdvertisementEnabled });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WLANConfiguration:1#GetTotalAssociations", RequestNamespace = "urn:dslforum-org:service:WLANConfiguration:1", ResponseNamespace = "urn:dslforum-org:service:WLANConfiguration:1")]
            public void GetTotalAssociations([XmlElement("NewTotalAssociations", Namespace="")]out ui2 TotalAssociations)
            {
                object[] results = this.Invoke("GetTotalAssociations", new object[] {  });
                TotalAssociations = (ui2)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WLANConfiguration:1#GetGenericAssociatedDeviceInfo", RequestNamespace = "urn:dslforum-org:service:WLANConfiguration:1", ResponseNamespace = "urn:dslforum-org:service:WLANConfiguration:1")]
            public void GetGenericAssociatedDeviceInfo([XmlElement("NewAssociatedDeviceIndex", Namespace="")]ui2 TotalAssociations, [XmlElement("NewAssociatedDeviceMACAddress", Namespace="")]out string AssociatedDeviceMACAddress, [XmlElement("NewAssociatedDeviceIPAddress", Namespace="")]out string AssociatedDeviceIPAddress, [XmlElement("NewAssociatedDeviceAuthState", Namespace="")]out boolean AssociatedDeviceAuthState, [XmlElement("NewX_AVM-DE_Speed", Namespace="")]out ui2 Speed, [XmlElement("NewX_AVM-DE_SignalStrength", Namespace="")]out ui1 SignalStrength)
            {
                object[] results = this.Invoke("GetGenericAssociatedDeviceInfo", new object[] { TotalAssociations });
                AssociatedDeviceMACAddress = (string)results[0];
                AssociatedDeviceIPAddress = (string)results[1];
                AssociatedDeviceAuthState = (boolean)results[2];
                Speed = (ui2)results[3];
                SignalStrength = (ui1)results[4];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WLANConfiguration:1#GetSpecificAssociatedDeviceInfo", RequestNamespace = "urn:dslforum-org:service:WLANConfiguration:1", ResponseNamespace = "urn:dslforum-org:service:WLANConfiguration:1")]
            public void GetSpecificAssociatedDeviceInfo([XmlElement("NewAssociatedDeviceMACAddress", Namespace="")]string AssociatedDeviceMACAddress, [XmlElement("NewAssociatedDeviceIPAddress", Namespace="")]out string AssociatedDeviceIPAddress, [XmlElement("NewAssociatedDeviceAuthState", Namespace="")]out boolean AssociatedDeviceAuthState, [XmlElement("NewX_AVM-DE_Speed", Namespace="")]out ui2 Speed, [XmlElement("NewX_AVM-DE_SignalStrength", Namespace="")]out ui1 SignalStrength)
            {
                object[] results = this.Invoke("GetSpecificAssociatedDeviceInfo", new object[] { AssociatedDeviceMACAddress });
                AssociatedDeviceIPAddress = (string)results[0];
                AssociatedDeviceAuthState = (boolean)results[1];
                Speed = (ui2)results[2];
                SignalStrength = (ui1)results[3];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WLANConfiguration:1#X_SetHighFrequencyBand", OneWay=true, RequestElementName = "X_SetHighFrequencyBand", ResponseElementName = "X_SetHighFrequencyBandResponse", RequestNamespace = "urn:dslforum-org:service:WLANConfiguration:1", ResponseNamespace = "urn:dslforum-org:service:WLANConfiguration:1")]
            public void SetHighFrequencyBand([XmlElement("NewEnableHighFrequency", Namespace="")]boolean EnableHighFrequency)
            {
                this.Invoke("SetHighFrequencyBand", new object[] { EnableHighFrequency });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WLANConfiguration:1#X_AVM-DE_SetStickSurfEnable", OneWay=true, RequestElementName = "X_AVM-DE_SetStickSurfEnable", ResponseElementName = "X_AVM-DE_SetStickSurfEnableResponse", RequestNamespace = "urn:dslforum-org:service:WLANConfiguration:1", ResponseNamespace = "urn:dslforum-org:service:WLANConfiguration:1")]
            public void SetStickSurfEnable([XmlElement("NewStickSurfEnable", Namespace="")]boolean StickSurfEnable)
            {
                this.Invoke("SetStickSurfEnable", new object[] { StickSurfEnable });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WLANConfiguration:1#X_AVM-DE_GetIPTVOptimized", RequestElementName = "X_AVM-DE_GetIPTVOptimized", ResponseElementName = "X_AVM-DE_GetIPTVOptimizedResponse", RequestNamespace = "urn:dslforum-org:service:WLANConfiguration:1", ResponseNamespace = "urn:dslforum-org:service:WLANConfiguration:1")]
            public void GetIPTVOptimized([XmlElement("NewX_AVM-DE_IPTVoptimize", Namespace="")]out boolean IPTVoptimize)
            {
                object[] results = this.Invoke("GetIPTVOptimized", new object[] {  });
                IPTVoptimize = (boolean)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WLANConfiguration:1#X_AVM-DE_SetIPTVOptimized", OneWay=true, RequestElementName = "X_AVM-DE_SetIPTVOptimized", ResponseElementName = "X_AVM-DE_SetIPTVOptimizedResponse", RequestNamespace = "urn:dslforum-org:service:WLANConfiguration:1", ResponseNamespace = "urn:dslforum-org:service:WLANConfiguration:1")]
            public void SetIPTVOptimized([XmlElement("NewX_AVM-DE_IPTVoptimize", Namespace="")]boolean IPTVoptimize)
            {
                this.Invoke("SetIPTVOptimized", new object[] { IPTVoptimize });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WLANConfiguration:1#X_AVM-DE_GetNightControl", RequestElementName = "X_AVM-DE_GetNightControl", ResponseElementName = "X_AVM-DE_GetNightControlResponse", RequestNamespace = "urn:dslforum-org:service:WLANConfiguration:1", ResponseNamespace = "urn:dslforum-org:service:WLANConfiguration:1")]
            public void GetNightControl([XmlElement("NewNightControl", Namespace="")]out string NightControl, [XmlElement("NewNightTimeControlNoForcedOff", Namespace="")]out boolean NightTimeControlNoForcedOff)
            {
                object[] results = this.Invoke("GetNightControl", new object[] {  });
                NightControl = (string)results[0];
                NightTimeControlNoForcedOff = (boolean)results[1];
            }

        }
        #endregion

        public string ControlURL { get { return "/upnp/control/wlanconfig1"; } }
        public SoapHttpClientProtocol SoapHttpClientProtocol { get; set; }

        public Wlanconfig1(string url)
        {
            SoapHttpClientProtocol = new wlanconfig1()
            {
                Url = url + ControlURL
            };
        }

        public void SetEnable(boolean Enable)
        {
            ((wlanconfig1)SoapHttpClientProtocol).SetEnable(Enable);
        }

        public void GetInfo(out boolean Enable, out string Status, out string MaxBitRate, out ui1 Channel, out string SSID, out string BeaconType, out boolean MACAddressControlEnabled, out string Standard, out string BSSID, out string BasicEncryptionModes, out string BasicAuthenticationMode, out ui1 MaxCharsSSID, out ui1 MinCharsSSID, out string AllowedCharsSSID, out ui1 MinCharsPSK, out ui1 MaxCharsPSK, out string AllowedCharsPSK)
        {
            ((wlanconfig1)SoapHttpClientProtocol).GetInfo(out Enable, out Status, out MaxBitRate, out Channel, out SSID, out BeaconType, out MACAddressControlEnabled, out Standard, out BSSID, out BasicEncryptionModes, out BasicAuthenticationMode, out MaxCharsSSID, out MinCharsSSID, out AllowedCharsSSID, out MinCharsPSK, out MaxCharsPSK, out AllowedCharsPSK);
        }

        public void SetConfig(string MaxBitRate, ui1 Channel, string SSID, string BeaconType, boolean MACAddressControlEnabled, string BasicEncryptionModes, string BasicAuthenticationMode)
        {
            ((wlanconfig1)SoapHttpClientProtocol).SetConfig(MaxBitRate, Channel, SSID, BeaconType, MACAddressControlEnabled, BasicEncryptionModes, BasicAuthenticationMode);
        }

        public void SetSecurityKeys(string WEPKey0, string WEPKey1, string WEPKey2, string WEPKey3, string PreSharedKey, string KeyPassphrase)
        {
            ((wlanconfig1)SoapHttpClientProtocol).SetSecurityKeys(WEPKey0, WEPKey1, WEPKey2, WEPKey3, PreSharedKey, KeyPassphrase);
        }

        public void GetSecurityKeys(out string WEPKey0, out string WEPKey1, out string WEPKey2, out string WEPKey3, out string PreSharedKey, out string KeyPassphrase)
        {
            ((wlanconfig1)SoapHttpClientProtocol).GetSecurityKeys(out WEPKey0, out WEPKey1, out WEPKey2, out WEPKey3, out PreSharedKey, out KeyPassphrase);
        }

        public void SetDefaultWEPKeyIndex(ui1 WEPKeyIndex)
        {
            ((wlanconfig1)SoapHttpClientProtocol).SetDefaultWEPKeyIndex(WEPKeyIndex);
        }

        public void GetDefaultWEPKeyIndex(out ui1 WEPKeyIndex)
        {
            ((wlanconfig1)SoapHttpClientProtocol).GetDefaultWEPKeyIndex(out WEPKeyIndex);
        }

        public void SetBasBeaconSecurityProperties(string BasicEncryptionModes, string BasicAuthenticationMode)
        {
            ((wlanconfig1)SoapHttpClientProtocol).SetBasBeaconSecurityProperties(BasicEncryptionModes, BasicAuthenticationMode);
        }

        public void GetBasBeaconSecurityProperties(out string BasicEncryptionModes, out string BasicAuthenticationMode)
        {
            ((wlanconfig1)SoapHttpClientProtocol).GetBasBeaconSecurityProperties(out BasicEncryptionModes, out BasicAuthenticationMode);
        }

        public void GetStatistics(out ui4 TotalPacketsSent, out ui4 TotalPacketsReceived)
        {
            ((wlanconfig1)SoapHttpClientProtocol).GetStatistics(out TotalPacketsSent, out TotalPacketsReceived);
        }

        public void GetPacketStatistics(out ui4 TotalPacketsSent, out ui4 TotalPacketsReceived)
        {
            ((wlanconfig1)SoapHttpClientProtocol).GetPacketStatistics(out TotalPacketsSent, out TotalPacketsReceived);
        }

        public void GetBSSID(out string BSSID)
        {
            ((wlanconfig1)SoapHttpClientProtocol).GetBSSID(out BSSID);
        }

        public void GetSSID(out string SSID)
        {
            ((wlanconfig1)SoapHttpClientProtocol).GetSSID(out SSID);
        }

        public void SetSSID(string SSID)
        {
            ((wlanconfig1)SoapHttpClientProtocol).SetSSID(SSID);
        }

        public void GetBeaconType(out string BeaconType)
        {
            ((wlanconfig1)SoapHttpClientProtocol).GetBeaconType(out BeaconType);
        }

        public void SetBeaconType(string BeaconType)
        {
            ((wlanconfig1)SoapHttpClientProtocol).SetBeaconType(BeaconType);
        }

        public void GetChannelInfo(out ui1 Channel, out string PossibleChannels)
        {
            ((wlanconfig1)SoapHttpClientProtocol).GetChannelInfo(out Channel, out PossibleChannels);
        }

        public void SetChannel(ui1 Channel)
        {
            ((wlanconfig1)SoapHttpClientProtocol).SetChannel(Channel);
        }

        public void GetBeaconAdvertisement(out boolean BeaconAdvertisementEnabled)
        {
            ((wlanconfig1)SoapHttpClientProtocol).GetBeaconAdvertisement(out BeaconAdvertisementEnabled);
        }

        public void SetBeaconAdvertisement(boolean BeaconAdvertisementEnabled)
        {
            ((wlanconfig1)SoapHttpClientProtocol).SetBeaconAdvertisement(BeaconAdvertisementEnabled);
        }

        public void GetTotalAssociations(out ui2 TotalAssociations)
        {
            ((wlanconfig1)SoapHttpClientProtocol).GetTotalAssociations(out TotalAssociations);
        }

        public void GetGenericAssociatedDeviceInfo(ui2 TotalAssociations, out string AssociatedDeviceMACAddress, out string AssociatedDeviceIPAddress, out boolean AssociatedDeviceAuthState, out ui2 Speed, out ui1 SignalStrength)
        {
            ((wlanconfig1)SoapHttpClientProtocol).GetGenericAssociatedDeviceInfo(TotalAssociations, out AssociatedDeviceMACAddress, out AssociatedDeviceIPAddress, out AssociatedDeviceAuthState, out Speed, out SignalStrength);
        }

        public void GetSpecificAssociatedDeviceInfo(string AssociatedDeviceMACAddress, out string AssociatedDeviceIPAddress, out boolean AssociatedDeviceAuthState, out ui2 Speed, out ui1 SignalStrength)
        {
            ((wlanconfig1)SoapHttpClientProtocol).GetSpecificAssociatedDeviceInfo(AssociatedDeviceMACAddress, out AssociatedDeviceIPAddress, out AssociatedDeviceAuthState, out Speed, out SignalStrength);
        }

        public void SetHighFrequencyBand(boolean EnableHighFrequency)
        {
            ((wlanconfig1)SoapHttpClientProtocol).SetHighFrequencyBand(EnableHighFrequency);
        }

        public void SetStickSurfEnable(boolean StickSurfEnable)
        {
            ((wlanconfig1)SoapHttpClientProtocol).SetStickSurfEnable(StickSurfEnable);
        }

        public void GetIPTVOptimized(out boolean IPTVoptimize)
        {
            ((wlanconfig1)SoapHttpClientProtocol).GetIPTVOptimized(out IPTVoptimize);
        }

        public void SetIPTVOptimized(boolean IPTVoptimize)
        {
            ((wlanconfig1)SoapHttpClientProtocol).SetIPTVOptimized(IPTVoptimize);
        }

        public void GetNightControl(out string NightControl, out boolean NightTimeControlNoForcedOff)
        {
            ((wlanconfig1)SoapHttpClientProtocol).GetNightControl(out NightControl, out NightTimeControlNoForcedOff);
        }

    }
}
