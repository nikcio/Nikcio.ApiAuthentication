using Nikcio.ApiAuthentication.Persistence.ApiKeys.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Nikcio.ApiAuthentication.Persistence.ApiKeys.Extentions {
    /// <summary>
    /// Repository extentions
    /// </summary>
    public static class RepositoryExtentions {
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
