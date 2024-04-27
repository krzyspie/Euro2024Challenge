using Euro2024Challenge.Backend.Modules.Players.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Euro2024Challenge.Backend.Modules.Players.Infrastructure.Database.Configuration;

public class TournamentWinnerBetsConfiguration : IEntityTypeConfiguration<TournamentWinnerBet>
{
    public void Configure(EntityTypeBuilder<TournamentWinnerBet> builder)
    {
        builder.ToTable("TournamentWinnerBets");
    }
}