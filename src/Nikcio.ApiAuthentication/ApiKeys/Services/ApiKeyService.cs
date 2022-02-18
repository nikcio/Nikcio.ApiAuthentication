using Nikcio.ApiAuthentication.Persistence.ApiKeys.Models;
using Nikcio.ApiAuthentication.Persistence.ApiKeys.Repositories;
using Nikcio.DataAccess.Services;
using Nikcio.DataAccess.Services.Crud;
using Microsoft.Extensions.Logging;

namespace Nikcio.ApiAuthentication.ApiKeys.Services {
    public class ApiKeyService : CrudServiceBase<ApiKey, IApiKeyRepository>, IApiKeyService {
        public ApiKeyService(IApiKeyRepository repository, ILogger<ServiceBase<IApiKeyRepository>> logger) : base(repository, logger) {
        }
    }
}
