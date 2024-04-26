using Euro2024Challenge.Backend.Modules.Players.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Euro2024Challenge.Backend.Modules.Players.Infrastructure.Database.Configuration;

internal class TopScorerBetsConfiguration : IEntityTypeConfiguration<TopScorerBet>
{
    public void Configure(EntityTypeBuilder<TopScorerBet> builder)
    {
        
    }
}