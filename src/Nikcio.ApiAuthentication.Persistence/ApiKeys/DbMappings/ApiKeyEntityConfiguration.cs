using Nikcio.ApiAuthentication.Persistence.ApiKeys.Models;
using Nikcio.DataAccess.Conventions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Nikcio.ApiAuthentication.Persistence.ApiKeys.DbMappings {
    internal class ApiKeyEntityConfiguration : IEntityTypeConfiguration<ApiKey> {
        public void Configure(EntityTypeBuilder<ApiKey> builder) {
            builder.Property(p => p.Key).HasMaxLength(DefaultValues.DefaultApiKeyLength).IsRequired();
        }
    }
}
