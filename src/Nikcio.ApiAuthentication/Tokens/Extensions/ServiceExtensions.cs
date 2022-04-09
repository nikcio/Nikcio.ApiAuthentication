using Microsoft.Extensions.DependencyInjection;
using Nikcio.ApiAuthentication.Tokens.Services;

namespace Nikcio.ApiAuthentication.Tokens.Extensions {
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
                .AddScoped<ITokenService, TokenService>();

            return services;
        }
    }
}
