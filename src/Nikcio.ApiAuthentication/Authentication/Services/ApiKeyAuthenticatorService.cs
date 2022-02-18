using System;
using System.Linq;
using System.Threading.Tasks;
using Nikcio.ApiAuthentication.ApiKeys.Services;
using Nikcio.ApiAuthentication.Tokens.Models;
using Nikcio.ApiAuthentication.Tokens.Services;
using Microsoft.Extensions.Logging;

namespace Nikcio.ApiAuthentication.Authentication.Services {
    public class ApiKeyAuthenticatorService : IApiKeyAuthenticatorService {
        private readonly ITokenService _tokenService;
        private readonly IApiKeyService _apiKeyService;
        private readonly ILogger<ApiKeyAuthenticatorService> _logger;

        public ApiKeyAuthenticatorService(ITokenService tokenService, IApiKeyService apiKeyService, ILogger<ApiKeyAuthenticatorService> logger) {
            _tokenService = tokenService;
            _apiKeyService = apiKeyService;
            _logger = logger;
        }

        public async Task<ApiToken> AuthenticateKey(string apikey) {
            try {
                var apiKeyEntry = (await _apiKeyService.QueryDbSet()).ReponseValue.Where(item => item.Key == apikey).FirstOrDefault();
                var apiKeyExists = apiKeyEntry != default;
                return _tokenService.GenerateToken(apiKeyEntry.GetClaims());
            } catch (Exception ex) {
                _logger.LogError(ex, $"Authentication failed for key: {apikey}");
                return null;
            }
        }
    }
}
