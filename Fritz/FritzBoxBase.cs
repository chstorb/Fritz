using Fritz.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Fritz
{
    /// <summary>
    /// FritzBoxBase class
    /// </summary>
    public abstract class FritzBoxBase
    {
        #region Properties

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Host { get; set; } = "fritz.box";
        public ushort Port { get; set; } = 49000;
        public string Url { get; set; }
        public ushort SecurityPort { get; set; }

        #endregion

        /// <summary>
        /// Default constructor
        /// </summary>
        public FritzBoxBase()
        {
            Initialize();
        }

        /// <summary>
        /// Initialize
        /// </summary>
        protected void Initialize()
        {
            DisableServerCertificateValidation();

            Url = $"http://{Host}:{Port}";

            SecurityPort = GetSecurityPort();

            Url = $"https://{Host}:{SecurityPort}";
        }

        /// <summary>
        /// DisableServerCertificateValidation
        /// </summary>
        protected void DisableServerCertificateValidation()
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
        }

        /// <summary>
        /// Get the security port
        /// </summary>
        /// <returns></returns>
        public ushort GetSecurityPort()
        {
            var deviceInfo = new Deviceinfo(Url);
            deviceInfo.GetSecurityPort(out ushort port);
            return port;
        }

        /// <summary>
        /// Reboot Fritz!Box
        /// </summary>
        /// <returns></returns>
        public void Reboot()
        {
            var service = new Deviceconfig(Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: UserName, password: Password);
            service.Reboot(); 
        }
    }
}
