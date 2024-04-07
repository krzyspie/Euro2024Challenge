using Microsoft.Extensions.DependencyInjection;
using Euro2024Challenge.Backend.Modules.Turnaments.Core.Database;
using Euro2024Challenge.Shared.Database;

namespace Euro2024Challenge.Backend.Modules.Turnaments.Core
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