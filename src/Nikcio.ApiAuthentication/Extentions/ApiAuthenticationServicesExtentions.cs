using Nikcio.ApiAuthentication.ApiClaims.Extentions;
using Nikcio.ApiAuthentication.ApiKeys.Extentions;
using Nikcio.ApiAuthentication.Authentication.Extentions;
using Microsoft.Extensions.DependencyInjection;

namespace Nikcio.ApiAuthentication.Extentions {
    public static class ApiAuthenticationServicesExtentions {
        public static IServiceCollection AddApiAuthenticationServices(this IServiceCollection services) {
            services
                .AddApiKeys()
                .AddAuthenticationServices()
                .AddApiClaims();

            return services;
        }
    }
}
