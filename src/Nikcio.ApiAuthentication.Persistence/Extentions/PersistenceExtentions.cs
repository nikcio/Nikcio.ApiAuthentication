using Nikcio.ApiAuthentication.Persistence.ApiClaims.Extentions;
using Nikcio.ApiAuthentication.Persistence.ApiKeys.Extentions;
using Nikcio.ApiAuthentication.Persistence.Contexts.Extentions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nikcio.DataAccess.Extentions;

namespace Nikcio.ApiAuthentication.Persistence.Extentions {
    /// <summary>
    /// Persistence extentions
    /// </summary>
    public static class PersistenceExtentions {
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
