using System.Collections.Generic;
using System.Security.Claims;
using Nikcio.ApiAuthentication.Tokens.Models;

namespace Nikcio.ApiAuthentication.Tokens.Services {
    /// <summary>
    /// A service for token management
    /// </summary>
    public interface ITokenService {
        /// <summary>
        /// Generates a token
        /// </summary>
        /// <returns></returns>
        ApiToken GenerateToken();

        /// <summary>
        /// Generates a token
        /// </summary>
        /// <param name="claims"></param>
        /// <returns></returns>
        ApiToken GenerateToken(List<Claim> claims);
    }
}