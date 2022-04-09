using Microsoft.Extensions.DependencyInjection;
using Nikcio.ApiAuthentication.ApiClaims.Services;

namespace Nikcio.ApiAuthentication.ApiClaims.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class ServiceExtensions {
        /// <summary>
        /// Adds services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services
                .AddScoped<IApiClaimService, ApiClaimsService>();

            return services;
        }
    }
}
