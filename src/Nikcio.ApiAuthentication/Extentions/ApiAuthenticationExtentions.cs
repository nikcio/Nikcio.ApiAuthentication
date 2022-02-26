using System;
using Nikcio.ApiAuthentication.Persistence.Extentions;
using Nikcio.ApiAuthentication.Settings.Extentions;
using Nikcio.ApiAuthentication.Tokens.Extentions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Nikcio.ApiAuthentication.Extentions {
    public static class ApiAuthenticationExtentions {
        public static IServiceCollection AddNikcioApiAuthentication(this IServiceCollection services, IConfiguration configuration, Action<AuthorizationOptions> authorizationOptions = default, string connectionStringKey = "Default", string configurationSection = "Nikcio:ApiAuthentication", string dataAccessConfigurationSection = "Nikcio:DataAccess") {
            services
                .AddSettings(configuration, configurationSection)
                .AddTokens()
                .AddPersistence(configuration, connectionStringKey, dataAccessConfigurationSection)
                .AddApiAuthenticationServices();

            if (authorizationOptions == default) {
                services
                    .AddAuthorization();
            } else {
                services
                    .AddAuthorization(authorizationOptions);
            }

            return services;
        }
    }
}
