using System.Threading.Tasks;
using Nikcio.ApiAuthentication.Tokens.Models;

namespace Nikcio.ApiAuthentication.Authentication.Services {
    public interface IApiKeyAuthenticatorService {
        Task<ApiToken> AuthenticateKey(string apikey);
    }
}