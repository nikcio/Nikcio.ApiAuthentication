using Nikcio.ApiAuthentication.Persistence.ApiClaims.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Nikcio.ApiAuthentication.Persistence.ApiClaims.Extentions {
    /// <summary>
    /// Repository extentions
    /// </summary>
    public static class RepositoryExtentions {
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
