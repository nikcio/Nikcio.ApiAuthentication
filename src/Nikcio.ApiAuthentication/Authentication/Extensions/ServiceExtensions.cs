using Microsoft.Extensions.DependencyInjection;
using Nikcio.ApiAuthentication.Authentication.Services;

namespace Nikcio.ApiAuthentication.Authentication.Extensions {
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
                .AddScoped<IApiKeyAuthenticatorService, ApiKeyAuthenticatorService>();

            return services;
        }
    }
}
