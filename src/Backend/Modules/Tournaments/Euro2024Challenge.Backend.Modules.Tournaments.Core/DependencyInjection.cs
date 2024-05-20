using Euro2024Challenge.Backend.Modules.Tournaments.Core.Database;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Repositories;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Services;
using Euro2024Challenge.Shared.Database;
using Microsoft.Extensions.DependencyInjection;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            services
                .AddPostgres<TournamentDbContext>()
                .AddScoped<ITeamRepository, TeamRepository>()
                .AddScoped<ITeamService, TeamService>()
                .AddScoped<IMatchRepository, MatchRepository>()
                .AddScoped<IMatchService, MatchService>();

            return services;
        }
    }
}