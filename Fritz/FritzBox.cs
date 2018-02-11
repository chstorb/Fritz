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
    /// FritzBox class
    /// </summary>
    public class FritzBox
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
        public FritzBox()
        {
            Initialize();
        }

        /// <summary>
        /// Initialize
        /// </summary>
        private void Initialize()
        {
            DisableServerCertificateValidation();

            Url = $"http://{Host}:{Port}";

            SecurityPort = GetSecurityPort();

            Url = $"https://{Host}:{SecurityPort}";
        }

        /// <summary>
        /// DisableServerCertificateValidation
        /// </summary>
        private void DisableServerCertificateValidation()
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
        }

        /// <summary>
        /// GetSecurityPort
        /// </summary>
        /// <returns></returns>
        private ushort GetSecurityPort()
        {
            var deviceInfo = new Deviceinfo(Url);
            deviceInfo.GetSecurityPort(out ushort port);
            return port;
        }
    }
}
