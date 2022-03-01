using Microsoft.Extensions.DependencyInjection;

namespace Nikcio.ApiAuthentication.Tokens.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class TokenExtensions {
        /// <summary>
        /// Adds tokens
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddTokens(this IServiceCollection services) {
            services
                .AddServices()
                .AddGenerators()
                .AddValidators();

            return services;
        }
    }
}
