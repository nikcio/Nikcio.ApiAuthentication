using Nikcio.ApiAuthentication.Tokens.Validators;
using Microsoft.Extensions.DependencyInjection;

namespace Nikcio.ApiAuthentication.Tokens.Extentions {
    public static class ValidatorExtentions {
        public static IServiceCollection AddValidators(this IServiceCollection services) {
            services
                .AddScoped<IRefreshTokenValidator, RefreshTokenValidator>();

            return services;
        }
    }
}
