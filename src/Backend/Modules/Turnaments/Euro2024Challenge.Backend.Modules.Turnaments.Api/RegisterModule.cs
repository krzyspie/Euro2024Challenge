using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Routing;

using Euro2024Challenge.Backend.Modules.Turnaments.Core;
using Euro2024Challenge.Backend.Modules.Turnaments.Presentation;

namespace Euro2024Challenge.Backend.Modules.Turnaments.Api
{
    public static class RegisterModule
    {
        public static IServiceCollection RegisterTurnamentsModule(this IServiceCollection services)
        {
             services
                .AddCore()
                .AddPresentation();

            return services;
        }

        public static IEndpointRouteBuilder UseTurnamentsModules(this IEndpointRouteBuilder app)
        {
            app.MapTurnamentsEndpoints();

            return app;
        }
    }
}
