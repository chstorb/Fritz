using Fritz.Services;
using Fritz.Extensions;
using System;
using System.Net;
using Fritz.Serialization;

namespace Fritz
{
    /// <summary>
    /// FritzBoxBase class
    /// </summary>
    public abstract class FritzClientBase
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
        public FritzClientBase()
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

        #region Deviceinfo

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

        #endregion deviceinfo

        #region Deviceconfig

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

        #endregion

        #region Contact

        /// <summary>
        /// Add phonebook.
        /// </summary>
        /// <param name="name">phonebook name</param>
        /// <param name="extraId">phonebook extra id (optional)</param>        
        public void AddPhonebook(string name, string extraId="")
        {
            var service = new Contact(Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: UserName, password: Password);

            if (service.PhonebookExists(name)) return;

            if (string.IsNullOrEmpty(extraId)) extraId = Guid.NewGuid().ToString();

            service.AddPhonebook(extraId, name);
        }

        /// <summary>
        /// Delete phonebook.
        /// </summary>
        /// <param name="name">phonebook name</param>
        public void DeletePhonebook(string name)
        {
            var service = new Contact(Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: UserName, password: Password);

            if (!service.PhonebookExists(name)) return;

            service.DeletePhonebook(name);
        }

        public phonebooksPhonebook GetPhonebook(string name)
        {
            var service = new Contact(Url);
            service.SoapHttpClientProtocol.Credentials = new NetworkCredential(userName: UserName, password: Password);
            return service.GetPhonebook(name);
        }

        #endregion
    }
}
