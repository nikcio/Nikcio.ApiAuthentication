using Nikcio.ApiAuthentication.Persistence.ApiKeys.Models;
using Nikcio.ApiAuthentication.Persistence.Contexts;
using Nikcio.DataAccess.Repositories.Crud;
using Microsoft.Extensions.Logging;

namespace Nikcio.ApiAuthentication.Persistence.ApiKeys.Repositories {
    /// <summary>
    /// A repository for managing api keys
    /// </summary>
    public class ApiKeyRepository : DbCrudRepositoryBase<ApiKey>, IApiKeyRepository {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="logger"></param>
        public ApiKeyRepository(IApiAuthenticationContext dbContext, ILogger<DbCrudRepositoryBase<ApiKey>> logger) : base(dbContext, logger) {
        }
    }
}
