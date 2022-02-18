using Nikcio.ApiAuthentication.Persistence.ApiClaims.Models;
using Nikcio.DataAccess.Conventions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Nikcio.ApiAuthentication.Persistence.ApiClaims.DbMappings {
    /// <summary>
    /// Configuration for api claim
    /// </summary>
    public class ApiClaimEntityConfiguration : IEntityTypeConfiguration<ApiClaim> {
        /// <summary>
        /// Configuration
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<ApiClaim> builder) {
            builder.Property(p => p.Type)
                .HasMaxLength(DefaultValues.DefaultStringLength)
                .IsRequired();

            builder.Property(p => p.Value)
                .HasMaxLength(DefaultValues.DefaultValueLength);
        }
    }
}
