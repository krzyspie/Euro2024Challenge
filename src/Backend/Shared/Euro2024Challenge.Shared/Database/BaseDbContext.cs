using Microsoft.EntityFrameworkCore;

namespace Euro2024Challenge.Shared.Database
{
    public class BaseDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Database=euro2024; Username=postgres; Password=admin");
        }
    }
}