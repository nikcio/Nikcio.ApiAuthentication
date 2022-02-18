using Microsoft.Extensions.DependencyInjection;

namespace Nikcio.ApiAuthentication.Authentication.Extentions {
    public static class AuthenticationExtentions {
        public static IServiceCollection AddAuthenticationServices(this IServiceCollection services) {
            services
                .AddServices();

            return services;
        }
    }
}
