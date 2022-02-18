using Nikcio.ApiAuthentication.Persistence.ApiKeys.Models;
using Nikcio.DataAccess.Repositories.Crud;

namespace Nikcio.ApiAuthentication.Persistence.ApiKeys.Repositories {
    /// <summary>
    /// A repository for managing api keys
    /// </summary>
    public interface IApiKeyRepository : IDbCrudRepositoryBase<ApiKey> {
    }
}