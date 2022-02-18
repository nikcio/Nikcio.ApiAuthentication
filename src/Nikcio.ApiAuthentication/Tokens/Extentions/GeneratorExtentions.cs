using Nikcio.ApiAuthentication.Tokens.Generators;
using Microsoft.Extensions.DependencyInjection;

namespace Nikcio.ApiAuthentication.Tokens.Extentions {
    public static class GeneratorExtentions {
        public static IServiceCollection AddGenerators(this IServiceCollection services) {
            services
                .AddScoped<ITokenGenerator, TokenGenerator>();

            return services;
        }
    }
}
