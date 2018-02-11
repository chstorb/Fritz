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
    public class Wanpppconn1
    {
        #region SoapHttpClientProtocol
        [WebServiceBinding("urn:dslforum-org:service:WANPPPConnection:1", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        class wanpppconn1 : SoapHttpClientProtocol
        {
            [SoapDocumentMethod("urn:dslforum-org:service:WANPPPConnection:1#GetInfo", RequestNamespace = "urn:dslforum-org:service:WANPPPConnection:1", ResponseNamespace = "urn:dslforum-org:service:WANPPPConnection:1")]
            public void GetInfo([XmlElement("NewEnable", Namespace="")]out boolean Enable, [XmlElement("NewConnectionStatus", Namespace="")]out string ConnectionStatus, [XmlElement("NewPossibleConnectionTypes", Namespace="")]out string PossibleConnectionTypes, [XmlElement("NewConnectionType", Namespace="")]out string ConnectionType, [XmlElement("NewName", Namespace="")]out string Name, [XmlElement("NewUptime", Namespace="")]out ui4 Uptime, [XmlElement("NewUpstreamMaxBitRate", Namespace="")]out ui4 UpstreamMaxBitRate, [XmlElement("NewDownstreamMaxBitRate", Namespace="")]out ui4 DownstreamMaxBitRate, [XmlElement("NewLastConnectionError", Namespace="")]out string LastConnectionError, [XmlElement("NewIdleDisconnectTime", Namespace="")]out ui4 IdleDisconnectTime, [XmlElement("NewRSIPAvailable", Namespace="")]out boolean RSIPAvailable, [XmlElement("NewUserName", Namespace="")]out string UserName, [XmlElement("NewNATEnabled", Namespace="")]out boolean NATEnabled, [XmlElement("NewExternalIPAddress", Namespace="")]out string ExternalIPAddress, [XmlElement("NewDNSServers", Namespace="")]out string DNSServers, [XmlElement("NewMACAddress", Namespace="")]out string MACAddress, [XmlElement("NewConnectionTrigger", Namespace="")]out string ConnectionTrigger, [XmlElement("NewLastAuthErrorInfo", Namespace="")]out string LastAuthErrorInfo, [XmlElement("NewMaxCharsUsername", Namespace="")]out ui2 MaxCharsUsername, [XmlElement("NewMinCharsUsername", Namespace="")]out ui2 MinCharsUsername, [XmlElement("NewAllowedCharsUsername", Namespace="")]out string AllowedCharsUsername, [XmlElement("NewMaxCharsPassword", Namespace="")]out ui2 MaxCharsPassword, [XmlElement("NewMinCharsPassword", Namespace="")]out ui2 MinCharsPassword, [XmlElement("NewAllowedCharsPassword", Namespace="")]out string AllowedCharsPassword, [XmlElement("NewTransportType", Namespace="")]out string TransportType, [XmlElement("NewRouteProtocolRx", Namespace="")]out string RouteProtocolRx, [XmlElement("NewPPPoEServiceName", Namespace="")]out string PPPoEServiceName, [XmlElement("NewRemoteIPAddress", Namespace="")]out string RemoteIPAddress, [XmlElement("NewPPPoEACName", Namespace="")]out string PPPoEACName, [XmlElement("NewDNSEnabled", Namespace="")]out boolean DNSEnabled, [XmlElement("NewDNSOverrideAllowed", Namespace="")]out boolean DNSOverrideAllowed)
            {
                object[] results = this.Invoke("GetInfo", new object[] {  });
                Enable = (boolean)results[0];
                ConnectionStatus = (string)results[1];
                PossibleConnectionTypes = (string)results[2];
                ConnectionType = (string)results[3];
                Name = (string)results[4];
                Uptime = (ui4)results[5];
                UpstreamMaxBitRate = (ui4)results[6];
                DownstreamMaxBitRate = (ui4)results[7];
                LastConnectionError = (string)results[8];
                IdleDisconnectTime = (ui4)results[9];
                RSIPAvailable = (boolean)results[10];
                UserName = (string)results[11];
                NATEnabled = (boolean)results[12];
                ExternalIPAddress = (string)results[13];
                DNSServers = (string)results[14];
                MACAddress = (string)results[15];
                ConnectionTrigger = (string)results[16];
                LastAuthErrorInfo = (string)results[17];
                MaxCharsUsername = (ui2)results[18];
                MinCharsUsername = (ui2)results[19];
                AllowedCharsUsername = (string)results[20];
                MaxCharsPassword = (ui2)results[21];
                MinCharsPassword = (ui2)results[22];
                AllowedCharsPassword = (string)results[23];
                TransportType = (string)results[24];
                RouteProtocolRx = (string)results[25];
                PPPoEServiceName = (string)results[26];
                RemoteIPAddress = (string)results[27];
                PPPoEACName = (string)results[28];
                DNSEnabled = (boolean)results[29];
                DNSOverrideAllowed = (boolean)results[30];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANPPPConnection:1#GetConnectionTypeInfo", RequestNamespace = "urn:dslforum-org:service:WANPPPConnection:1", ResponseNamespace = "urn:dslforum-org:service:WANPPPConnection:1")]
            public void GetConnectionTypeInfo([XmlElement("NewConnectionType", Namespace="")]out string ConnectionType, [XmlElement("NewPossibleConnectionTypes", Namespace="")]out string PossibleConnectionTypes)
            {
                object[] results = this.Invoke("GetConnectionTypeInfo", new object[] {  });
                ConnectionType = (string)results[0];
                PossibleConnectionTypes = (string)results[1];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANPPPConnection:1#SetConnectionType", OneWay=true, RequestNamespace = "urn:dslforum-org:service:WANPPPConnection:1", ResponseNamespace = "urn:dslforum-org:service:WANPPPConnection:1")]
            public void SetConnectionType([XmlElement("NewConnectionType", Namespace="")]string ConnectionType)
            {
                this.Invoke("SetConnectionType", new object[] { ConnectionType });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANPPPConnection:1#GetStatusInfo", RequestNamespace = "urn:dslforum-org:service:WANPPPConnection:1", ResponseNamespace = "urn:dslforum-org:service:WANPPPConnection:1")]
            public void GetStatusInfo([XmlElement("NewConnectionStatus", Namespace="")]out string ConnectionStatus, [XmlElement("NewLastConnectionError", Namespace="")]out string LastConnectionError, [XmlElement("NewUptime", Namespace="")]out ui4 Uptime)
            {
                object[] results = this.Invoke("GetStatusInfo", new object[] {  });
                ConnectionStatus = (string)results[0];
                LastConnectionError = (string)results[1];
                Uptime = (ui4)results[2];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANPPPConnection:1#GetUserName", RequestNamespace = "urn:dslforum-org:service:WANPPPConnection:1", ResponseNamespace = "urn:dslforum-org:service:WANPPPConnection:1")]
            public void GetUserName([XmlElement("NewUserName", Namespace="")]out string UserName)
            {
                object[] results = this.Invoke("GetUserName", new object[] {  });
                UserName = (string)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANPPPConnection:1#SetUserName", OneWay=true, RequestNamespace = "urn:dslforum-org:service:WANPPPConnection:1", ResponseNamespace = "urn:dslforum-org:service:WANPPPConnection:1")]
            public void SetUserName([XmlElement("NewUserName", Namespace="")]string UserName)
            {
                this.Invoke("SetUserName", new object[] { UserName });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANPPPConnection:1#SetPassword", OneWay=true, RequestNamespace = "urn:dslforum-org:service:WANPPPConnection:1", ResponseNamespace = "urn:dslforum-org:service:WANPPPConnection:1")]
            public void SetPassword([XmlElement("NewPassword", Namespace="")]string Password)
            {
                this.Invoke("SetPassword", new object[] { Password });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANPPPConnection:1#GetNATRSIPStatus", RequestNamespace = "urn:dslforum-org:service:WANPPPConnection:1", ResponseNamespace = "urn:dslforum-org:service:WANPPPConnection:1")]
            public void GetNATRSIPStatus([XmlElement("NewRSIPAvailable", Namespace="")]out boolean RSIPAvailable, [XmlElement("NewNATEnabled", Namespace="")]out boolean NATEnabled)
            {
                object[] results = this.Invoke("GetNATRSIPStatus", new object[] {  });
                RSIPAvailable = (boolean)results[0];
                NATEnabled = (boolean)results[1];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANPPPConnection:1#SetConnectionTrigger", OneWay=true, RequestNamespace = "urn:dslforum-org:service:WANPPPConnection:1", ResponseNamespace = "urn:dslforum-org:service:WANPPPConnection:1")]
            public void SetConnectionTrigger([XmlElement("NewConnectionTrigger", Namespace="")]string ConnectionTrigger)
            {
                this.Invoke("SetConnectionTrigger", new object[] { ConnectionTrigger });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANPPPConnection:1#ForceTermination", OneWay=true, RequestNamespace = "urn:dslforum-org:service:WANPPPConnection:1", ResponseNamespace = "urn:dslforum-org:service:WANPPPConnection:1")]
            public void ForceTermination()
            {
                this.Invoke("ForceTermination", new object[] {  });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANPPPConnection:1#RequestConnection", OneWay=true, RequestNamespace = "urn:dslforum-org:service:WANPPPConnection:1", ResponseNamespace = "urn:dslforum-org:service:WANPPPConnection:1")]
            public void RequestConnection()
            {
                this.Invoke("RequestConnection", new object[] {  });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANPPPConnection:1#GetGenericPortMappingEntry", RequestNamespace = "urn:dslforum-org:service:WANPPPConnection:1", ResponseNamespace = "urn:dslforum-org:service:WANPPPConnection:1")]
            public void GetGenericPortMappingEntry([XmlElement("NewPortMappingIndex", Namespace="")]ui2 PortMappingNumberOfEntries, [XmlElement("NewRemoteHost", Namespace="")]out string RemoteHost, [XmlElement("NewExternalPort", Namespace="")]out ui2 ExternalPort, [XmlElement("NewProtocol", Namespace="")]out string PortMappingProtocol, [XmlElement("NewInternalPort", Namespace="")]out ui2 InternalPort, [XmlElement("NewInternalClient", Namespace="")]out string InternalClient, [XmlElement("NewEnabled", Namespace="")]out boolean PortMappingEnabled, [XmlElement("NewPortMappingDescription", Namespace="")]out string PortMappingDescription, [XmlElement("NewLeaseDuration", Namespace="")]out ui4 PortMappingLeaseDuration)
            {
                object[] results = this.Invoke("GetGenericPortMappingEntry", new object[] { PortMappingNumberOfEntries });
                RemoteHost = (string)results[0];
                ExternalPort = (ui2)results[1];
                PortMappingProtocol = (string)results[2];
                InternalPort = (ui2)results[3];
                InternalClient = (string)results[4];
                PortMappingEnabled = (boolean)results[5];
                PortMappingDescription = (string)results[6];
                PortMappingLeaseDuration = (ui4)results[7];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANPPPConnection:1#GetSpecificPortMappingEntry", RequestNamespace = "urn:dslforum-org:service:WANPPPConnection:1", ResponseNamespace = "urn:dslforum-org:service:WANPPPConnection:1")]
            public void GetSpecificPortMappingEntry([XmlElement("NewRemoteHost", Namespace="")]string RemoteHost, [XmlElement("NewExternalPort", Namespace="")]ui2 ExternalPort, [XmlElement("NewProtocol", Namespace="")]string PortMappingProtocol, [XmlElement("NewInternalPort", Namespace="")]out ui2 InternalPort, [XmlElement("NewInternalClient", Namespace="")]out string InternalClient, [XmlElement("NewEnabled", Namespace="")]out boolean PortMappingEnabled, [XmlElement("NewPortMappingDescription", Namespace="")]out string PortMappingDescription, [XmlElement("NewLeaseDuration", Namespace="")]out ui4 PortMappingLeaseDuration)
            {
                object[] results = this.Invoke("GetSpecificPortMappingEntry", new object[] { RemoteHost, ExternalPort, PortMappingProtocol });
                InternalPort = (ui2)results[0];
                InternalClient = (string)results[1];
                PortMappingEnabled = (boolean)results[2];
                PortMappingDescription = (string)results[3];
                PortMappingLeaseDuration = (ui4)results[4];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANPPPConnection:1#AddPortMapping", OneWay=true, RequestNamespace = "urn:dslforum-org:service:WANPPPConnection:1", ResponseNamespace = "urn:dslforum-org:service:WANPPPConnection:1")]
            public void AddPortMapping([XmlElement("NewRemoteHost", Namespace="")]string RemoteHost, [XmlElement("NewExternalPort", Namespace="")]ui2 ExternalPort, [XmlElement("NewProtocol", Namespace="")]string PortMappingProtocol, [XmlElement("NewInternalPort", Namespace="")]ui2 InternalPort, [XmlElement("NewInternalClient", Namespace="")]string InternalClient, [XmlElement("NewEnabled", Namespace="")]boolean PortMappingEnabled, [XmlElement("NewPortMappingDescription", Namespace="")]string PortMappingDescription, [XmlElement("NewLeaseDuration", Namespace="")]ui4 PortMappingLeaseDuration)
            {
                this.Invoke("AddPortMapping", new object[] { RemoteHost, ExternalPort, PortMappingProtocol, InternalPort, InternalClient, PortMappingEnabled, PortMappingDescription, PortMappingLeaseDuration });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANPPPConnection:1#DeletePortMapping", OneWay=true, RequestNamespace = "urn:dslforum-org:service:WANPPPConnection:1", ResponseNamespace = "urn:dslforum-org:service:WANPPPConnection:1")]
            public void DeletePortMapping([XmlElement("NewRemoteHost", Namespace="")]string RemoteHost, [XmlElement("NewExternalPort", Namespace="")]ui2 ExternalPort, [XmlElement("NewProtocol", Namespace="")]string PortMappingProtocol)
            {
                this.Invoke("DeletePortMapping", new object[] { RemoteHost, ExternalPort, PortMappingProtocol });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANPPPConnection:1#GetExternalIPAddress", RequestNamespace = "urn:dslforum-org:service:WANPPPConnection:1", ResponseNamespace = "urn:dslforum-org:service:WANPPPConnection:1")]
            public void GetExternalIPAddress([XmlElement("NewExternalIPAddress", Namespace="")]out string ExternalIPAddress)
            {
                object[] results = this.Invoke("GetExternalIPAddress", new object[] {  });
                ExternalIPAddress = (string)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANPPPConnection:1#X_GetDNSServers", RequestElementName = "X_GetDNSServers", ResponseElementName = "X_GetDNSServersResponse", RequestNamespace = "urn:dslforum-org:service:WANPPPConnection:1", ResponseNamespace = "urn:dslforum-org:service:WANPPPConnection:1")]
            public void GetDNSServers([XmlElement("NewDNSServers", Namespace="")]out string DNSServers)
            {
                object[] results = this.Invoke("GetDNSServers", new object[] {  });
                DNSServers = (string)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANPPPConnection:1#X_SetDNSServers", OneWay=true, RequestElementName = "X_SetDNSServers", ResponseElementName = "X_SetDNSServersResponse", RequestNamespace = "urn:dslforum-org:service:WANPPPConnection:1", ResponseNamespace = "urn:dslforum-org:service:WANPPPConnection:1")]
            public void SetDNSServers([XmlElement("NewDNSServers", Namespace="")]string DNSServers)
            {
                this.Invoke("SetDNSServers", new object[] { DNSServers });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANPPPConnection:1#GetLinkLayerMaxBitRates", RequestNamespace = "urn:dslforum-org:service:WANPPPConnection:1", ResponseNamespace = "urn:dslforum-org:service:WANPPPConnection:1")]
            public void GetLinkLayerMaxBitRates([XmlElement("NewUpstreamMaxBitRate", Namespace="")]out ui4 UpstreamMaxBitRate, [XmlElement("NewDownstreamMaxBitRate", Namespace="")]out ui4 DownstreamMaxBitRate)
            {
                object[] results = this.Invoke("GetLinkLayerMaxBitRates", new object[] {  });
                UpstreamMaxBitRate = (ui4)results[0];
                DownstreamMaxBitRate = (ui4)results[1];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANPPPConnection:1#GetPortMappingNumberOfEntries", RequestNamespace = "urn:dslforum-org:service:WANPPPConnection:1", ResponseNamespace = "urn:dslforum-org:service:WANPPPConnection:1")]
            public void GetPortMappingNumberOfEntries([XmlElement("NewPortMappingNumberOfEntries", Namespace="")]out ui2 PortMappingNumberOfEntries)
            {
                object[] results = this.Invoke("GetPortMappingNumberOfEntries", new object[] {  });
                PortMappingNumberOfEntries = (ui2)results[0];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANPPPConnection:1#SetRouteProtocolRx", OneWay=true, RequestNamespace = "urn:dslforum-org:service:WANPPPConnection:1", ResponseNamespace = "urn:dslforum-org:service:WANPPPConnection:1")]
            public void SetRouteProtocolRx([XmlElement("NewRouteProtocolRx", Namespace="")]string RouteProtocolRx)
            {
                this.Invoke("SetRouteProtocolRx", new object[] { RouteProtocolRx });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANPPPConnection:1#SetIdleDisconnectTime", OneWay=true, RequestNamespace = "urn:dslforum-org:service:WANPPPConnection:1", ResponseNamespace = "urn:dslforum-org:service:WANPPPConnection:1")]
            public void SetIdleDisconnectTime([XmlElement("NewIdleDisconnectTime", Namespace="")]ui4 IdleDisconnectTime)
            {
                this.Invoke("SetIdleDisconnectTime", new object[] { IdleDisconnectTime });
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANPPPConnection:1#X_AVM-DE_GetAutoDisconnectTimeSpan", RequestElementName = "X_AVM-DE_GetAutoDisconnectTimeSpan", ResponseElementName = "X_AVM-DE_GetAutoDisconnectTimeSpanResponse", RequestNamespace = "urn:dslforum-org:service:WANPPPConnection:1", ResponseNamespace = "urn:dslforum-org:service:WANPPPConnection:1")]
            public void GetAutoDisconnectTimeSpan([XmlElement("NewX_AVM-DE_DisconnectPreventionEnable", Namespace="")]out boolean DisconnectPreventionEnable, [XmlElement("NewX_AVM-DE_DisconnectPreventionHour", Namespace="")]out ui2 DisconnectPreventionHour)
            {
                object[] results = this.Invoke("GetAutoDisconnectTimeSpan", new object[] {  });
                DisconnectPreventionEnable = (boolean)results[0];
                DisconnectPreventionHour = (ui2)results[1];
            }

            [SoapDocumentMethod("urn:dslforum-org:service:WANPPPConnection:1#X_AVM-DE_SetAutoDisconnectTimeSpan", OneWay=true, RequestElementName = "X_AVM-DE_SetAutoDisconnectTimeSpan", ResponseElementName = "X_AVM-DE_SetAutoDisconnectTimeSpanResponse", RequestNamespace = "urn:dslforum-org:service:WANPPPConnection:1", ResponseNamespace = "urn:dslforum-org:service:WANPPPConnection:1")]
            public void SetAutoDisconnectTimeSpan([XmlElement("NewX_AVM-DE_DisconnectPreventionEnable", Namespace="")]boolean DisconnectPreventionEnable, [XmlElement("NewX_AVM-DE_DisconnectPreventionHour", Namespace="")]ui2 DisconnectPreventionHour)
            {
                this.Invoke("SetAutoDisconnectTimeSpan", new object[] { DisconnectPreventionEnable, DisconnectPreventionHour });
            }

        }
        #endregion

        public string ControlURL { get { return "/upnp/control/wanpppconn1"; } }
        public SoapHttpClientProtocol SoapHttpClientProtocol { get; set; }

        public Wanpppconn1(string url)
        {
            SoapHttpClientProtocol = new wanpppconn1()
            {
                Url = url + ControlURL
            };
        }

        public void GetInfo(out boolean Enable, out string ConnectionStatus, out string PossibleConnectionTypes, out string ConnectionType, out string Name, out ui4 Uptime, out ui4 UpstreamMaxBitRate, out ui4 DownstreamMaxBitRate, out string LastConnectionError, out ui4 IdleDisconnectTime, out boolean RSIPAvailable, out string UserName, out boolean NATEnabled, out string ExternalIPAddress, out string DNSServers, out string MACAddress, out string ConnectionTrigger, out string LastAuthErrorInfo, out ui2 MaxCharsUsername, out ui2 MinCharsUsername, out string AllowedCharsUsername, out ui2 MaxCharsPassword, out ui2 MinCharsPassword, out string AllowedCharsPassword, out string TransportType, out string RouteProtocolRx, out string PPPoEServiceName, out string RemoteIPAddress, out string PPPoEACName, out boolean DNSEnabled, out boolean DNSOverrideAllowed)
        {
            ((wanpppconn1)SoapHttpClientProtocol).GetInfo(out Enable, out ConnectionStatus, out PossibleConnectionTypes, out ConnectionType, out Name, out Uptime, out UpstreamMaxBitRate, out DownstreamMaxBitRate, out LastConnectionError, out IdleDisconnectTime, out RSIPAvailable, out UserName, out NATEnabled, out ExternalIPAddress, out DNSServers, out MACAddress, out ConnectionTrigger, out LastAuthErrorInfo, out MaxCharsUsername, out MinCharsUsername, out AllowedCharsUsername, out MaxCharsPassword, out MinCharsPassword, out AllowedCharsPassword, out TransportType, out RouteProtocolRx, out PPPoEServiceName, out RemoteIPAddress, out PPPoEACName, out DNSEnabled, out DNSOverrideAllowed);
        }

        public void GetConnectionTypeInfo(out string ConnectionType, out string PossibleConnectionTypes)
        {
            ((wanpppconn1)SoapHttpClientProtocol).GetConnectionTypeInfo(out ConnectionType, out PossibleConnectionTypes);
        }

        public void SetConnectionType(string ConnectionType)
        {
            ((wanpppconn1)SoapHttpClientProtocol).SetConnectionType(ConnectionType);
        }

        public void GetStatusInfo(out string ConnectionStatus, out string LastConnectionError, out ui4 Uptime)
        {
            ((wanpppconn1)SoapHttpClientProtocol).GetStatusInfo(out ConnectionStatus, out LastConnectionError, out Uptime);
        }

        public void GetUserName(out string UserName)
        {
            ((wanpppconn1)SoapHttpClientProtocol).GetUserName(out UserName);
        }

        public void SetUserName(string UserName)
        {
            ((wanpppconn1)SoapHttpClientProtocol).SetUserName(UserName);
        }

        public void SetPassword(string Password)
        {
            ((wanpppconn1)SoapHttpClientProtocol).SetPassword(Password);
        }

        public void GetNATRSIPStatus(out boolean RSIPAvailable, out boolean NATEnabled)
        {
            ((wanpppconn1)SoapHttpClientProtocol).GetNATRSIPStatus(out RSIPAvailable, out NATEnabled);
        }

        public void SetConnectionTrigger(string ConnectionTrigger)
        {
            ((wanpppconn1)SoapHttpClientProtocol).SetConnectionTrigger(ConnectionTrigger);
        }

        public void ForceTermination()
        {
            ((wanpppconn1)SoapHttpClientProtocol).ForceTermination();
        }

        public void RequestConnection()
        {
            ((wanpppconn1)SoapHttpClientProtocol).RequestConnection();
        }

        public void GetGenericPortMappingEntry(ui2 PortMappingNumberOfEntries, out string RemoteHost, out ui2 ExternalPort, out string PortMappingProtocol, out ui2 InternalPort, out string InternalClient, out boolean PortMappingEnabled, out string PortMappingDescription, out ui4 PortMappingLeaseDuration)
        {
            ((wanpppconn1)SoapHttpClientProtocol).GetGenericPortMappingEntry(PortMappingNumberOfEntries, out RemoteHost, out ExternalPort, out PortMappingProtocol, out InternalPort, out InternalClient, out PortMappingEnabled, out PortMappingDescription, out PortMappingLeaseDuration);
        }

        public void GetSpecificPortMappingEntry(string RemoteHost, ui2 ExternalPort, string PortMappingProtocol, out ui2 InternalPort, out string InternalClient, out boolean PortMappingEnabled, out string PortMappingDescription, out ui4 PortMappingLeaseDuration)
        {
            ((wanpppconn1)SoapHttpClientProtocol).GetSpecificPortMappingEntry(RemoteHost, ExternalPort, PortMappingProtocol, out InternalPort, out InternalClient, out PortMappingEnabled, out PortMappingDescription, out PortMappingLeaseDuration);
        }

        public void AddPortMapping(string RemoteHost, ui2 ExternalPort, string PortMappingProtocol, ui2 InternalPort, string InternalClient, boolean PortMappingEnabled, string PortMappingDescription, ui4 PortMappingLeaseDuration)
        {
            ((wanpppconn1)SoapHttpClientProtocol).AddPortMapping(RemoteHost, ExternalPort, PortMappingProtocol, InternalPort, InternalClient, PortMappingEnabled, PortMappingDescription, PortMappingLeaseDuration);
        }

        public void DeletePortMapping(string RemoteHost, ui2 ExternalPort, string PortMappingProtocol)
        {
            ((wanpppconn1)SoapHttpClientProtocol).DeletePortMapping(RemoteHost, ExternalPort, PortMappingProtocol);
        }

        public void GetExternalIPAddress(out string ExternalIPAddress)
        {
            ((wanpppconn1)SoapHttpClientProtocol).GetExternalIPAddress(out ExternalIPAddress);
        }

        public void GetDNSServers(out string DNSServers)
        {
            ((wanpppconn1)SoapHttpClientProtocol).GetDNSServers(out DNSServers);
        }

        public void SetDNSServers(string DNSServers)
        {
            ((wanpppconn1)SoapHttpClientProtocol).SetDNSServers(DNSServers);
        }

        public void GetLinkLayerMaxBitRates(out ui4 UpstreamMaxBitRate, out ui4 DownstreamMaxBitRate)
        {
            ((wanpppconn1)SoapHttpClientProtocol).GetLinkLayerMaxBitRates(out UpstreamMaxBitRate, out DownstreamMaxBitRate);
        }

        public void GetPortMappingNumberOfEntries(out ui2 PortMappingNumberOfEntries)
        {
            ((wanpppconn1)SoapHttpClientProtocol).GetPortMappingNumberOfEntries(out PortMappingNumberOfEntries);
        }

        public void SetRouteProtocolRx(string RouteProtocolRx)
        {
            ((wanpppconn1)SoapHttpClientProtocol).SetRouteProtocolRx(RouteProtocolRx);
        }

        public void SetIdleDisconnectTime(ui4 IdleDisconnectTime)
        {
            ((wanpppconn1)SoapHttpClientProtocol).SetIdleDisconnectTime(IdleDisconnectTime);
        }

        public void GetAutoDisconnectTimeSpan(out boolean DisconnectPreventionEnable, out ui2 DisconnectPreventionHour)
        {
            ((wanpppconn1)SoapHttpClientProtocol).GetAutoDisconnectTimeSpan(out DisconnectPreventionEnable, out DisconnectPreventionHour);
        }

        public void SetAutoDisconnectTimeSpan(boolean DisconnectPreventionEnable, ui2 DisconnectPreventionHour)
        {
            ((wanpppconn1)SoapHttpClientProtocol).SetAutoDisconnectTimeSpan(DisconnectPreventionEnable, DisconnectPreventionHour);
        }

    }
}
