using Microsoft.Extensions.DependencyInjection;

namespace Nikcio.ApiAuthentication.Tokens.Extentions {
    public static class TokenExtentions {
        public static IServiceCollection AddTokens(this IServiceCollection services) {
            services
                .AddServices()
                .AddGenerators()
                .AddValidators();

            return services;
        }
    }
}
