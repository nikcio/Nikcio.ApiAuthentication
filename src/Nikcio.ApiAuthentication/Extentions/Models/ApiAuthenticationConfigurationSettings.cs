using System;
using Microsoft.AspNetCore.Authorization;

namespace Nikcio.ApiAuthentication.Extentions {
    public class ApiAuthenticationConfigurationSettings {
        public Action<AuthorizationOptions> AuthorizationOptions { get; set; } = default;
        public string ConnectionStringKey { get; set; } = "Default";
        public string ConfigurationSection { get; set; } = "Nikcio.ApiAuthentication";
        public string DataAccessConfigurationSection { get; set; } = "Nikcio.DataAccess";
    }
}
