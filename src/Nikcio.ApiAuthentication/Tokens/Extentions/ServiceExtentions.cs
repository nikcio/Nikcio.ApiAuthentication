using Nikcio.ApiAuthentication.Tokens.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Nikcio.ApiAuthentication.Tokens.Extentions {
    public static class ServiceExtentions {
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services
                .AddScoped<ITokenService, TokenService>();

            return services;
        }
    }
}
