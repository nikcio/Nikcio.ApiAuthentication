using Nikcio.ApiAuthentication.ApiKeys.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Nikcio.ApiAuthentication.ApiKeys.Extensions {
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
                .AddScoped<IApiKeyService, ApiKeyService>();

            return services;
        }
    }
}
