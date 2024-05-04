using Euro2024Challenge.Backend.Modules.Players.Domain.Entities;
using Euro2024Challenge.Backend.Modules.Players.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Euro2024Challenge.Backend.Modules.Players.Infrastructure.Database.Configuration
{
    internal class MatchBetsConfiguration : IEntityTypeConfiguration<MatchBet>
    {
        public void Configure(EntityTypeBuilder<MatchBet> builder)
        {
            builder.ToTable("MatchBets");

            builder.Property(x => x.PlayerId)
                .IsRequired();
            builder.Property(x => x.Result)
                .HasConversion(v => $"{v.HomeTeamGoals} : {v.AwayTeamGoals}",
                    v => MatchResult.CreateNew(v));
            builder.Property(x => x.Winner)
                .HasConversion<int>();

        }
    }
}
