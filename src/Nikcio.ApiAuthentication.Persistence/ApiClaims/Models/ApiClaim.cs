using System.Collections.Generic;
using System.Security.Claims;
using Nikcio.ApiAuthentication.Persistence.ApiKeys.Models;
using Nikcio.DataAccess.Models;

namespace Nikcio.ApiAuthentication.Persistence.ApiClaims.Models {
    /// <summary>
    /// A Api claim
    /// </summary>
    public class ApiClaim : IGenericId {
        /// <summary>
        /// The id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The claim type
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// The claim value
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// The Api keys using the claim
        /// </summary>
        public virtual ICollection<ApiKey> ApiKeys { get; set; }

        /// <summary>
        /// Gets the claim as <see cref="Claim"/>
        /// </summary>
        /// <returns></returns>
        public Claim GetClaim() {
            return new Claim(Type, Value);
        }
    }
}
