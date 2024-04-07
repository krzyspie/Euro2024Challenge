using Euro2024Challenge.Shared.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Euro2024Challenge.Backend.Modules.Turnaments.Core.Database
{
    public class TournamentDbContext : DbContext
    {
        public TournamentDbContext(DbContextOptions<TournamentDbContext> options) : base(options)
        {
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Footballer> Footballers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("tournaments");
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

    }
}