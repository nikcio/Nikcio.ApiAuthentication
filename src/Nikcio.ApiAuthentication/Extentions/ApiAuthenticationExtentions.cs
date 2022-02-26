using Nikcio.ApiAuthentication.Persistence.Extentions;
using Nikcio.ApiAuthentication.Settings.Extentions;
using Nikcio.ApiAuthentication.Tokens.Extentions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nikcio.ApiAuthentication.Extentions.Models;

namespace Nikcio.ApiAuthentication.Extentions {
    /// <summary>
    /// Extentions
    /// </summary>
    public static class ApiAuthenticationExtentions {
        /// <summary>
        /// Adds Nikcio.ApiAuthentication
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddNikcioApiAuthentication(this IServiceCollection services, IConfiguration configuration) {
            var defaultSettings = new ApiAuthenticationConfigurationSettings();
            return AddNikcioApiAuthentication(services, configuration, defaultSettings);
        }

        /// <summary>
        /// Adds Nikcio.ApiAuthentication
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        public static IServiceCollection AddNikcioApiAuthentication(this IServiceCollection services, IConfiguration configuration, ApiAuthenticationConfigurationSettings settings) {
            services
                .AddSettings(configuration, settings.ConfigurationSection)
                .AddTokens()
                .AddPersistence(configuration, settings.ConnectionStringKey, settings.DataAccessConfigurationSection)
                .AddApiAuthenticationServices();

            if (settings.AuthorizationOptions == default) {
                services
                    .AddAuthorization();
            } else {
                services
                    .AddAuthorization(settings.AuthorizationOptions);
            }

            return services;
        }
    }
}
