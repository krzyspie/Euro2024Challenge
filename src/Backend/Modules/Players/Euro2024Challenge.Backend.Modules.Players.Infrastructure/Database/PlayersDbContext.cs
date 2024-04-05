using Euro2024Challenge.Backend.Modules.Players.Domain.Entities;
using Euro2024Challenge.Shared.Database;
using Microsoft.EntityFrameworkCore;

namespace Euro2024Challenge.Backend.Modules.Players.Infrastructure.Database
{
    internal class PlayersDbContext : BaseDbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<MatchBet> MatchMets { get; set; }
        public DbSet<TopScorerBet> TopScorerBets { get; set; }
        public DbSet<TurnamentWinnerBet> TurnamentWinnerBets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("players");
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
