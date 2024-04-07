using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Euro2024Challenge.Backend.Modules.Turnaments.Core.Database.Configurations
{
    internal class FootballerConfiguration : IEntityTypeConfiguration<Footballer>
    {
        public void Configure(EntityTypeBuilder<Footballer> builder)
        {
            builder.HasIndex(x => x.Name).IsUnique();
        }
    }
}