using Microsoft.EntityFrameworkCore;

namespace Euro2024Challenge.Backend.Modules.Turnaments.Core.Database
{
    public class TurnamentDbContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Footballer> Footballers { get; set; }

        public TurnamentDbContext(DbContextOptions<TurnamentDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("turnaments");
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

    }
}