using Microsoft.Extensions.DependencyInjection;

namespace Nikcio.ApiAuthentication.Persistence.ApiKeys.Extentions {
    /// <summary>
    /// Api key extentions
    /// </summary>
    public static class ApiKeyExtentions {
        /// <summary>
        /// Adds api keys
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddApiKeys(this IServiceCollection services) {
            services
                .AddRespositories();

            return services;
        }
    }
}
