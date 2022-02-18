using Nikcio.ApiAuthentication.ApiKeys.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Nikcio.ApiAuthentication.ApiKeys.Extentions {
    public static class ServiceExtentions {
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services
                .AddScoped<IApiKeyService, ApiKeyService>();

            return services;
        }
    }
}
