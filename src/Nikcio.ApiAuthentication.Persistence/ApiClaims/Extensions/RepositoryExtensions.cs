using Nikcio.ApiAuthentication.Persistence.ApiClaims.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Nikcio.ApiAuthentication.Persistence.ApiClaims.Extensions {
    /// <summary>
    /// Repository Extensions
    /// </summary>
    public static class RepositoryExtensions {
        /// <summary>
        /// Adds repositories
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddRepositories(this IServiceCollection services) {
            services
                .AddScoped<IApiClaimRepository, ApiClaimRepository>();

            return services;
        }
    }
}
