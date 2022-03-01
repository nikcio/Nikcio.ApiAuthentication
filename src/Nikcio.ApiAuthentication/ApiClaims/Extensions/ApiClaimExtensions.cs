using Microsoft.Extensions.DependencyInjection;

namespace Nikcio.ApiAuthentication.ApiClaims.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class ApiClaimExtensions {
        /// <summary>
        /// Adds api claims
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddApiClaims(this IServiceCollection services) {
            services
                .AddServices();

            return services;
        }
    }
}
