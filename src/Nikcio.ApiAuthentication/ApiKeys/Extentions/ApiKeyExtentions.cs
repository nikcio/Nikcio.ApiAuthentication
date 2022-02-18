using Microsoft.Extensions.DependencyInjection;

namespace Nikcio.ApiAuthentication.ApiKeys.Extentions {
    public static class ApiKeyExtentions {
        public static IServiceCollection AddApiKeys(this IServiceCollection services) {
            services
                .AddServices();

            return services;
        }
    }
}
