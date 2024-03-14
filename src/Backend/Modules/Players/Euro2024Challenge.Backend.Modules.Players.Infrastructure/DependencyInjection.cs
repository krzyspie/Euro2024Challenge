using Euro2024Challenge.Backend.Modules.Players.Domain.Repositories;
using Euro2024Challenge.Backend.Modules.Players.Infrastructure.Database;
using Euro2024Challenge.Backend.Modules.Players.Infrastructure.Database.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Euro2024Challenge.Backend.Modules.Players.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services
                .AddDbContext<PlayersDbContext>(
                    option => option.UseSqlServer())
                .AddScoped<IPlayersRepository, PlayersRepository>();

            return services;
        }
    }
}
