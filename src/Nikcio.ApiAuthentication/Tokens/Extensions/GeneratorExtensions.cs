﻿using Microsoft.Extensions.DependencyInjection;
using Nikcio.ApiAuthentication.Tokens.Generators;

namespace Nikcio.ApiAuthentication.Tokens.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class GeneratorExtensions {
        /// <summary>
        /// Adds generators
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddGenerators(this IServiceCollection services) {
            services
                .AddScoped<ITokenGenerator, TokenGenerator>();

            return services;
        }
    }
}
