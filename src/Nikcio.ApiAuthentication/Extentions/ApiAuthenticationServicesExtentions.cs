using Nikcio.ApiAuthentication.ApiClaims.Extentions;
using Nikcio.ApiAuthentication.ApiKeys.Extentions;
using Nikcio.ApiAuthentication.Authentication.Extentions;
using Microsoft.Extensions.DependencyInjection;

namespace Nikcio.ApiAuthentication.Extentions {
    /// <summary>
    /// Extentions
    /// </summary>
    public static class ApiAuthenticationServicesExtentions {
        /// <summary>
        /// Adds api authentication services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddApiAuthenticationServices(this IServiceCollection services) {
            services
                .AddApiKeys()
                .AddAuthenticationServices()
                .AddApiClaims();

            return services;
        }
    }
}
