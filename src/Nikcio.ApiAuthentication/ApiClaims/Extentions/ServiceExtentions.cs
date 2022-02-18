using Nikcio.ApiAuthentication.ApiClaims.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Nikcio.ApiAuthentication.ApiClaims.Extentions {
    public static class ServiceExtentions {
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services
                .AddScoped<IApiClaimService, ApiClaimsService>();

            return services;
        }
    }
}
