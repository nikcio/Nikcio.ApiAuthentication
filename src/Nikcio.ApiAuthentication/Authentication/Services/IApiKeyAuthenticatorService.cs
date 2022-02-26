using Nikcio.ApiAuthentication.Tokens.Models;

namespace Nikcio.ApiAuthentication.Authentication.Services {
    /// <summary>
    /// A service for authenticating api keys
    /// </summary>
    public interface IApiKeyAuthenticatorService {
        /// <summary>
        /// Checks if a api key is vaild and returns a token if valid
        /// </summary>
        /// <param name="apikey"></param>
        /// <returns></returns>
        Task<ApiToken> AuthenticateKey(string apikey);
    }
}