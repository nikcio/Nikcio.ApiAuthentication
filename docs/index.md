# Documentation

## Getting started
To get started add the following code to your `startup.cs`:

```csharp
public void ConfigureServices(IServiceCollection services) {
    services.AddNikcioApiAuthentication(Configuration);
}
```

This will add all the setup for adding JWT authentication.

Make sure to add the settings you'd like to use to your appsettings.json:

```json
"Nikcio": {
    "ApiAuthentication": {

        "ValidIssuer": "localhost",
        "ValidAudience": "localhost"
    }
}
```

**Note** All avalible settings can be found in the [ApiAuthenticationSettings.cs](src\Nikcio.ApiAuthentication\Settings\Models\ApiAuthenticationSettings.cs)

Now you just need to create a way to make Api keys (Or create one in the database) and a controller to get a token with a api key.

Example:

```csharp
[Route("api/[controller]/[action]")]
[ApiController]
public class TestController : ControllerBase {
    private readonly IApiKeyAuthenticatorService _authenticationService;
    private readonly IApiKeyService _apiKeyService;

    public TestController(IApiKeyAuthenticatorService authenticationService, IApiKeyService apiKeyService) {
        _authenticationService = authenticationService;
        _apiKeyService = apiKeyService;
    }

    [HttpGet]
    public async Task<ApiToken> Authenticate(string apiKey) {
        return await _authenticationService.AuthenticateKey(apiKey);
    }

    [HttpGet]
    public async Task<ApiKey> CreateApiKey(string apiKey) {
        return (await _apiKeyService.Add(new ApiKey { Key = apiKey })).ReponseValue;
    }
}
```

You can now use the Asp Net Core `Authorize` attribute and all it's funtionallity. [See more here.](https://docs.microsoft.com/en-us/aspnet/core/security/authorization/simple?view=aspnetcore-6.0)

### Using Umbraco? (See here)
```csharp
public void ConfigureServices(IServiceCollection services) {
    services.AddUmbraco(_env, _config)
        .AddBackOffice()
        .AddWebsite()
        .AddComposers()
        .AddSubscriptions(_config, useSecurity: true)
        .Build();
    services.AddNikcioApiAuthentication(_config, connectionStringKey: "umbracoDbDSN");
}
```

You have to place the `AddNikcioApiAuthentication` call after the umbraco setup because the configuration done by the package otherwise would be overridden and therefore not work.