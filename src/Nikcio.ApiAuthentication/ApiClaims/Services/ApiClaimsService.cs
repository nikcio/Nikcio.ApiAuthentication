using Microsoft.Extensions.Logging;
using Nikcio.ApiAuthentication.Persistence.ApiClaims.Models;
using Nikcio.ApiAuthentication.Persistence.ApiClaims.Repositories;
using Nikcio.DataAccess.Services;
using Nikcio.DataAccess.Services.Crud;
using Nikcio.DataAccess.Settings;

namespace Nikcio.ApiAuthentication.ApiClaims.Services {
    /// <inheritdoc/>
    public class ApiClaimsService : CrudServiceBase<ApiClaim, IApiClaimRepository>, IApiClaimService {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="logger"></param>
        /// <param name="dataAccessSettings"></param>
        public ApiClaimsService(IApiClaimRepository repository, ILogger<ServiceBase<IApiClaimRepository>> logger, DataAccessSettings dataAccessSettings) : base(repository, logger, dataAccessSettings) {
        }
    }
}
