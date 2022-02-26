using Nikcio.ApiAuthentication.Persistence.ApiClaims.Models;
using Nikcio.ApiAuthentication.Persistence.ApiClaims.Repositories;
using Nikcio.DataAccess.Services.Crud;

namespace Nikcio.ApiAuthentication.ApiClaims.Services {
    /// <summary>
    /// A service for management of api claims
    /// </summary>
    public interface IApiClaimService : ICrudServiceBase<ApiClaim, IApiClaimRepository> {
    }
}