using Euro2024Challenge.Backend.Modules.Players.Application.Clients;
using Euro2024Challenge.Backend.Modules.Players.Domain.Repositories;
using Euro2024Challenge.Backend.Modules.Players.Infrastructure.Database;
using Euro2024Challenge.Backend.Modules.Players.Infrastructure.Database.Repositories;
using Euro2024Challenge.Backend.Modules.Players.Shared;
using Euro2024Challenge.Shared.Database;
using Microsoft.Extensions.DependencyInjection;

namespace Euro2024Challenge.Backend.Modules.Players.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services
                .AddPostgres<PlayersDbContext>()
                .AddScoped<IPlayersRepository, PlayersRepository>()
                .AddScoped<IPlayersBetsRepository, PlayersBetsRepository>()
                .AddScoped<IPlayerModuleApi, PlayerModuleClient>();

            return services;
        }
    }
}
