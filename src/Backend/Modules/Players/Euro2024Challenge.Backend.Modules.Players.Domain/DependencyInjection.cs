using Euro2024Challenge.Backend.Modules.Players.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Euro2024Challenge.Backend.Modules.Players.Domain
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            services.AddSingleton<IPointsCalculator, PointsCalculator>();
            return services;
        }
    }
}
