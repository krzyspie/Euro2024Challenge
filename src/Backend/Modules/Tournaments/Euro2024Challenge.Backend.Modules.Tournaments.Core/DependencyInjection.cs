using Euro2024Challenge.Backend.Modules.Tournaments.Core.Database;
using Euro2024Challenge.Shared.Database;
using Microsoft.Extensions.DependencyInjection;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            services
                .AddPostgres<TournamentDbContext>();

            return services;
        }
    }
}