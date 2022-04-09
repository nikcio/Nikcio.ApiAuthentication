using Microsoft.Extensions.DependencyInjection;
using Nikcio.ApiAuthentication.Tokens.Validators;

namespace Nikcio.ApiAuthentication.Tokens.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class ValidatorExtensions {
        /// <summary>
        /// Adds validators
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddValidators(this IServiceCollection services) {
            services
                .AddScoped<IRefreshTokenValidator, RefreshTokenValidator>();

            return services;
        }
    }
}
