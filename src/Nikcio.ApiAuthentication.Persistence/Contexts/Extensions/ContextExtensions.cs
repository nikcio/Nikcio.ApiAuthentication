using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Nikcio.ApiAuthentication.Persistence.Contexts.Extensions {
    /// <summary>
    /// Context Extensions
    /// </summary>
    public static class ContextExtensions {
        /// <summary>
        /// Adds contexts
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="connectionStringKey"></param>
        /// <returns></returns>
        public static IServiceCollection AddContexts(this IServiceCollection services, IConfiguration configuration, string connectionStringKey) {
            services.AddPooledDbContextFactory<ApiAuthenticationContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString(connectionStringKey))
                .UseLazyLoadingProxies()
                .LogTo(Console.WriteLine));

            services.AddScoped<IApiAuthenticationContext>(x => {
                var factory = x.GetRequiredService<IDbContextFactory<ApiAuthenticationContext>>();
                return factory.CreateDbContext();
            });

            return services;
        }
    }
}
