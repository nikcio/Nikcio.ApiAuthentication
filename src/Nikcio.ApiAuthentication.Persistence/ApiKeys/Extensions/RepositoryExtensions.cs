using Microsoft.Extensions.DependencyInjection;
using Nikcio.ApiAuthentication.Persistence.ApiKeys.Repositories;

namespace Nikcio.ApiAuthentication.Persistence.ApiKeys.Extensions {
    /// <summary>
    /// Repository Extensions
    /// </summary>
    public static class RepositoryExtensions {
        /// <summary>
        /// Adds repositories
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddRespositories(this IServiceCollection services) {
            services
                .AddScoped<IApiKeyRepository, ApiKeyRepository>();

            return services;
        }
    }
}
