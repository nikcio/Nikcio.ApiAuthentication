using Microsoft.Extensions.Logging;
using Nikcio.ApiAuthentication.Persistence.ApiClaims.Models;
using Nikcio.ApiAuthentication.Persistence.Contexts;
using Nikcio.DataAccess.Repositories.Crud;

namespace Nikcio.ApiAuthentication.Persistence.ApiClaims.Repositories {
    /// <summary>
    /// Repository for managing api claims
    /// </summary>
    public class ApiClaimRepository : DbCrudRepositoryBase<ApiClaim>, IApiClaimRepository {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="logger"></param>
        public ApiClaimRepository(IApiAuthenticationContext dbContext, ILogger<DbCrudRepositoryBase<ApiClaim>> logger) : base(dbContext, logger) {
        }
    }
}
