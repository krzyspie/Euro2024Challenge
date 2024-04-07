using Euro2024Challenge.Backend.Modules.Tournaments.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Routing;
using Euro2024Challenge.Backend.Modules.Tournaments.Presentation;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Api
{
    public static class RegisterModule
    {
        public static IServiceCollection RegisterTournamentsModule(this IServiceCollection services)
        {
             services
                .AddCore()
                .AddPresentation();

            return services;
        }

        public static IEndpointRouteBuilder UseTournamentsModules(this IEndpointRouteBuilder app)
        {
            app.MapTournamentsEndpoints();

            return app;
        }
    }
}
