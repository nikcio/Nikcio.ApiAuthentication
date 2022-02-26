using Nikcio.ApiAuthentication.Persistence.ApiKeys.Models;
using Nikcio.ApiAuthentication.Persistence.ApiKeys.Repositories;
using Nikcio.DataAccess.Services.Crud;

namespace Nikcio.ApiAuthentication.ApiKeys.Services {
    /// <summary>
    /// A service for management of api keys
    /// </summary>
    public interface IApiKeyService : ICrudServiceBase<ApiKey, IApiKeyRepository> {
    }
}