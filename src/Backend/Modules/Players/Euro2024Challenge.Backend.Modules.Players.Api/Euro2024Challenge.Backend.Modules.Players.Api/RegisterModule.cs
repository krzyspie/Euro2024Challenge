using Microsoft.Extensions.DependencyInjection;

using Euro2024Challenge.Backend.Modules.Players.Application;
using Euro2024Challenge.Backend.Modules.Players.Infrastructure;
using Euro2024Challenge.Backend.Modules.Players.Presentation;
using Microsoft.AspNetCore.Routing;
using Euro2024Challenge.Backend.Modules.Players.Domain;

namespace Euro2024Challenge.Backend.Modules.Players.Api
{
    public static class RegisterModule
    {
        public static IServiceCollection RegisterPlayersModule(this IServiceCollection services)
        {
            services
                .AddDomain()
                .AddApplication()
                .AddInfrastructure()
                .AddPresentation();

            return services;
        }

        public static IEndpointRouteBuilder UsePlayersModules(this IEndpointRouteBuilder app)
        {
            app.MapPlayersEndpoints();
            app.MapPlayerBetsEndpoints();

            return app;
        }
    }
}
