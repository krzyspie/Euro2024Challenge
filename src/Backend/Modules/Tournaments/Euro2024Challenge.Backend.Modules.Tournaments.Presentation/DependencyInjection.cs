using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Routing;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Presentation
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            return services;
        }
    }
}