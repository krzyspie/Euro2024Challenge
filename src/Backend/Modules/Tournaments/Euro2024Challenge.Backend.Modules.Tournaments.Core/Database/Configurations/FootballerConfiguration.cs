using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Database.Configurations
{
    internal class FootballerConfiguration : IEntityTypeConfiguration<Footballer>
    {
        public void Configure(EntityTypeBuilder<Footballer> builder)
        {
            builder.HasIndex(x => new { x.FullName, x.Team }).IsUnique();
        }
    }
}