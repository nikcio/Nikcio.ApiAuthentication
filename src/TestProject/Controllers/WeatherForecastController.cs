﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nikcio.ApiAuthentication.ApiKeys.Services;
using Nikcio.ApiAuthentication.Authentication.Services;
using Nikcio.ApiAuthentication.Persistence.ApiKeys.Models;
using Nikcio.ApiAuthentication.Tokens.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.Controllers {
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase {
        private static readonly string[] _summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IApiKeyAuthenticatorService _apiKeyAuthenticatorService;
        private readonly IApiKeyService _apiKeyService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IApiKeyAuthenticatorService apiKeyAuthenticatorService, IApiKeyService apiKeyService) {
            _logger = logger;
            _apiKeyAuthenticatorService = apiKeyAuthenticatorService;
            _apiKeyService = apiKeyService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get() {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = _summaries[rng.Next(_summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet]
        public async Task<ApiKey> AddAPiKey(string apiKey) {
            return (await _apiKeyService.Add(new ApiKey { Key = apiKey })).ReponseValue;
        }

        [HttpGet]
        public async Task<ApiToken> GetApiToken(string apikey) {
            return await _apiKeyAuthenticatorService.AuthenticateKey(apikey);
        }

        [HttpGet]
        [Authorize]
        public string TestAccess() {
            return "Access";
        }
    }
}
