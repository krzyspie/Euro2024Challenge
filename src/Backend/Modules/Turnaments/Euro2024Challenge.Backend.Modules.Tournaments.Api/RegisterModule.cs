using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Routing;

using Euro2024Challenge.Backend.Modules.Turnaments.Core;
using Euro2024Challenge.Backend.Modules.Turnaments.Presentation;

namespace Euro2024Challenge.Backend.Modules.Turnaments.Api
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
