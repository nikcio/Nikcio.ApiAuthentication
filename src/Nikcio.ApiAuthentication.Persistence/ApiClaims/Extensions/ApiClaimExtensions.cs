using Microsoft.Extensions.DependencyInjection;

namespace Nikcio.ApiAuthentication.Persistence.ApiClaims.Extensions {
    /// <summary>
    /// Extensions for api claims
    /// </summary>
    public static class ApiClaimExtensions {
        /// <summary>
        /// Adds api claims
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddApiClaims(this IServiceCollection services) {
            services
                .AddRepositories();

            return services;
        }
    }
}
