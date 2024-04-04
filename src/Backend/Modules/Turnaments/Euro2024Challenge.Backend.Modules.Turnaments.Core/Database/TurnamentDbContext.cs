using Euro2024Challenge.Shared.Database;
using Microsoft.EntityFrameworkCore;

namespace Euro2024Challenge.Backend.Modules.Turnaments.Core.Database
{
    public class TurnamentDbContext : BaseDbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Footballer> Footballers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("turnaments");
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

    }
}