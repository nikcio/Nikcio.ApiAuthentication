using Nikcio.ApiAuthentication.Persistence.ApiClaims.Models;
using Nikcio.ApiAuthentication.Persistence.ApiClaims.Repositories;
using Nikcio.DataAccess.Services;
using Nikcio.DataAccess.Services.Crud;
using Microsoft.Extensions.Logging;
using Nikcio.DataAccess.Settings;

namespace Nikcio.ApiAuthentication.ApiClaims.Services {
    public class ApiClaimsService : CrudServiceBase<ApiClaim, IApiClaimRepository>, IApiClaimService {
        public ApiClaimsService(IApiClaimRepository repository, ILogger<ServiceBase<IApiClaimRepository>> logger, DataAccessSettings dataAccessSettings) : base(repository, logger, dataAccessSettings) {
        }
    }
}
