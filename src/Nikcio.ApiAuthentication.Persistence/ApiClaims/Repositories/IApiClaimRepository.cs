using Nikcio.ApiAuthentication.Persistence.ApiClaims.Models;
using Nikcio.DataAccess.Repositories.Crud;

namespace Nikcio.ApiAuthentication.Persistence.ApiClaims.Repositories {
    /// <summary>
    /// A Repository for managing api claims
    /// </summary>
    public interface IApiClaimRepository : IDbCrudRepositoryBase<ApiClaim> {
    }
}