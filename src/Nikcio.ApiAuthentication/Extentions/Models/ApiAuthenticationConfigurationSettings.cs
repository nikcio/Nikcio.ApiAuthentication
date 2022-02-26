using Microsoft.AspNetCore.Authorization;

namespace Nikcio.ApiAuthentication.Extentions.Models {
    /// <summary>
    /// Settings for api configuration
    /// </summary>
    public class ApiAuthenticationConfigurationSettings {
        /// <summary>
        /// Provides programmatic configuration used by <see cref="IAuthorizationService"/> and <see cref="IAuthorizationPolicyProvider"/>
        /// </summary>
        public Action<AuthorizationOptions>? AuthorizationOptions { get; set; } = default;
        /// <summary>
        /// Configures what connection string to use to store data
        /// </summary>
        public string ConnectionStringKey { get; set; } = "Default";
        /// <summary>
        /// The configuration section for Nikcio.ApiAuthentication
        /// </summary>
        public string ConfigurationSection { get; set; } = "Nikcio:ApiAuthentication";
        /// <summary>
        /// The configuration section for Nikcio.DataAccess
        /// </summary>
        public string DataAccessConfigurationSection { get; set; } = "Nikcio:DataAccess";
    }
}
