using Euro2024Challenge.Backend.Modules.Players.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Euro2024Challenge.Backend.Modules.Players.Infrastructure.Database.Configuration
{
    internal class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.ToTable("Players");

            builder.Property(x => x.Email)
                .IsRequired();

            builder.Property(x => x.Username)
                .IsRequired();
        }
    }
}
