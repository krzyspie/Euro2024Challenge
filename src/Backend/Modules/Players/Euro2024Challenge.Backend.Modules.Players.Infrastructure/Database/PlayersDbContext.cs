using Euro2024Challenge.Backend.Modules.Players.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Euro2024Challenge.Backend.Modules.Players.Infrastructure.Database
{
    internal class PlayersDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<MatchBet> MatchesMets { get; set; }
        public DbSet<TopScorerBet> TopScorerBets { get; set; }
        public DbSet<TurnamentWinnerBet> TurnamentWinnerBets { get; set; }

        public PlayersDbContext(DbContextOptions<PlayersDbContext> options) : base(options)
        {                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("players");
        }
    }
}
