using Microsoft.Extensions.DependencyInjection;
using Nikcio.ApiAuthentication.ApiClaims.Extensions;
using Nikcio.ApiAuthentication.ApiKeys.Extensions;
using Nikcio.ApiAuthentication.Authentication.Extensions;

namespace Nikcio.ApiAuthentication.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class ApiAuthenticationServicesExtensions {
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
