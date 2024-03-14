using Euro2024Challenge.Backend.Modules.Players.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Euro2024Challenge.Backend.Modules.Players.Infrastructure.Database
{
    internal class PlayersDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }

        public PlayersDbContext(DbContextOptions<PlayersDbContext> options) : base(options)
        {
                
        }
    }
}
