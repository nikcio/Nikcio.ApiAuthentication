using System.Collections.Generic;
using System.Security.Claims;
using Nikcio.ApiAuthentication.Tokens.Models;

namespace Nikcio.ApiAuthentication.Tokens.Services {
    public interface ITokenService {
        ApiToken GenerateToken();

        ApiToken GenerateToken(List<Claim> claims);
    }
}