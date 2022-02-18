﻿using Nikcio.ApiAuthentication.Authentication.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Nikcio.ApiAuthentication.Authentication.Extentions {
    public static class ServiceExtentions {
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services
                .AddScoped<IApiKeyAuthenticatorService, ApiKeyAuthenticatorService>();

            return services;
        }
    }
}
