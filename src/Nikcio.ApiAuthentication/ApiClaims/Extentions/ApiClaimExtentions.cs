using Microsoft.Extensions.DependencyInjection;

namespace Nikcio.ApiAuthentication.ApiClaims.Extentions {
    public static class ApiClaimExtentions {
        public static IServiceCollection AddApiClaims(this IServiceCollection services) {
            services
                .AddServices();

            return services;
        }
    }
}
