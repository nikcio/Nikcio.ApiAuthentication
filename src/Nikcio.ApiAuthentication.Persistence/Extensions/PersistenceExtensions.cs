using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nikcio.ApiAuthentication.Persistence.ApiClaims.Extensions;
using Nikcio.ApiAuthentication.Persistence.ApiKeys.Extensions;
using Nikcio.ApiAuthentication.Persistence.Contexts.Extensions;
using Nikcio.DataAccess.Extensions;

namespace Nikcio.ApiAuthentication.Persistence.Extensions {
    /// <summary>
    /// Persistence Extensions
    /// </summary>
    public static class PersistenceExtensions {
        /// <summary>
        /// Adds persistence services and settings
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="connectionStringKey"></param>
        /// <param name="dataAccessConfigurationSection"></param>
        /// <returns></returns>
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration, string connectionStringKey, string dataAccessConfigurationSection) {
            services
                .AddContexts(configuration, connectionStringKey)
                .AddApiKeys()
                .AddApiClaims()
                .AddDataAccess(configuration, dataAccessConfigurationSection);

            return services;
        }
    }
}
