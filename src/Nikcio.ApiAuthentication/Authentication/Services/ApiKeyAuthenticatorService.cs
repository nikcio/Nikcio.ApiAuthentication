using Nikcio.ApiAuthentication.ApiKeys.Services;
using Nikcio.ApiAuthentication.Tokens.Models;
using Nikcio.ApiAuthentication.Tokens.Services;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace Nikcio.ApiAuthentication.Authentication.Services {
    /// <inheritdoc/>
    public class ApiKeyAuthenticatorService : IApiKeyAuthenticatorService {
        private readonly ITokenService _tokenService;
        private readonly IApiKeyService _apiKeyService;
        private readonly ILogger<ApiKeyAuthenticatorService> _logger;

        /// <summary>
        /// Construcutor
        /// </summary>
        /// <param name="tokenService"></param>
        /// <param name="apiKeyService"></param>
        /// <param name="logger"></param>
        public ApiKeyAuthenticatorService(ITokenService tokenService, IApiKeyService apiKeyService, ILogger<ApiKeyAuthenticatorService> logger) {
            _tokenService = tokenService;
            _apiKeyService = apiKeyService;
            _logger = logger;
        }

        /// <inheritdoc/>
        public async Task<ApiToken> AuthenticateKey(string apikey) {
            try {
                var apiKeyEntry = (await _apiKeyService.QueryDbSet()).ResponseValue?.Include(item => item.Claims).Where(item => item.Key == apikey).FirstOrDefault();
                var apiKeyExists = apiKeyEntry != default;
                if (apiKeyExists) {
                    return _tokenService.GenerateToken(apiKeyEntry?.GetClaims());
                } else {
                    return new ApiToken();
                }
            } catch (Exception ex) {
                _logger.LogError(ex, $"Authentication failed for key: {apikey}");
                return new ApiToken();
            }
        }
    }
}
