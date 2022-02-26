using System;
using Nikcio.ApiAuthentication.Persistence.Extentions;
using Nikcio.ApiAuthentication.Settings.Extentions;
using Nikcio.ApiAuthentication.Tokens.Extentions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Nikcio.ApiAuthentication.Extentions {
    public static class ApiAuthenticationExtentions {
        public static IServiceCollection AddNikcioApiAuthentication(this IServiceCollection services, IConfiguration configuration) {
            var defaultSettings = new ApiAuthenticationConfigurationSettings();
            return AddNikcioApiAuthentication(services, configuration, defaultSettings);
        }

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
