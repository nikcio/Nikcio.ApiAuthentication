using System.Reflection;
using Nikcio.ApiAuthentication.Persistence.ApiClaims.Models;
using Nikcio.ApiAuthentication.Persistence.ApiKeys.Models;
using Microsoft.EntityFrameworkCore;

namespace Nikcio.ApiAuthentication.Persistence.Contexts {
    /// <summary>
    /// Api authenticator
    /// </summary>
    public class ApiAuthenticationContext : DbContext, IApiAuthenticationContext {
        /// <summary>
        /// Default construtor
        /// </summary>
        /// <param name="options"></param>
        public ApiAuthenticationContext(DbContextOptions<ApiAuthenticationContext> options) : base(options) {
            Database.Migrate();
        }

        /// <summary>
        /// The DbContext
        /// </summary>
        public DbContext Context => this;
        /// <summary>
        /// Api keys
        /// </summary>
        public DbSet<ApiKey> ApiKeys { get; set; }
        /// <summary>
        /// Api claims
        /// </summary>
        public DbSet<ApiClaim> ApiClaims { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
