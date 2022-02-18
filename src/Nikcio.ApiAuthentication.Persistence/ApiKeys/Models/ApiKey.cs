using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Nikcio.ApiAuthentication.Persistence.ApiClaims.Models;
using Nikcio.DataAccess.Models;

namespace Nikcio.ApiAuthentication.Persistence.ApiKeys.Models {
    /// <summary>
    /// A Api key
    /// </summary>
    public class ApiKey : IGenericId {
        /// <summary>
        /// The id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The key
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// The claims
        /// </summary>
        public virtual ICollection<ApiClaim> Claims { get; set; }

        /// <summary>
        /// Gets the claims as <see cref="Claim"/>
        /// </summary>
        /// <returns></returns>
        public List<Claim> GetClaims() {
            return Claims.Select(claim => claim.GetClaim()).ToList();
        }
    }
}
