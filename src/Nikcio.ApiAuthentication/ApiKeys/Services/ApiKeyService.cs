using Microsoft.Extensions.Logging;
using Nikcio.ApiAuthentication.Persistence.ApiKeys.Models;
using Nikcio.ApiAuthentication.Persistence.ApiKeys.Repositories;
using Nikcio.DataAccess.Services;
using Nikcio.DataAccess.Services.Crud;
using Nikcio.DataAccess.Settings;

namespace Nikcio.ApiAuthentication.ApiKeys.Services {
    /// <inheritdoc/>
    public class ApiKeyService : CrudServiceBase<ApiKey, IApiKeyRepository>, IApiKeyService {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="logger"></param>
        /// <param name="dataAccessSettings"></param>
        public ApiKeyService(IApiKeyRepository repository, ILogger<ServiceBase<IApiKeyRepository>> logger, DataAccessSettings dataAccessSettings) : base(repository, logger, dataAccessSettings) {
        }
    }
}
