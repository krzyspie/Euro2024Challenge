using Euro2024Challenge.Backend.Modules.Classification.Application;
using Euro2024Challenge.Backend.Modules.Classification.Infrastructure;
using Euro2024Challenge.Backend.Modules.Classification.Presentation;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace Euro2024Challenge.Backend.Modules.Classification.Api;

public static class RegisterModule
{
    public static IServiceCollection RegisterClassificationModule(this IServiceCollection services)
    {
        services
            .AddApplication()
            .AddPresentation()
            .AddInfrastructure();

        return services;
    }
    
    public static IEndpointRouteBuilder UseClassificationModules(this IEndpointRouteBuilder app)
    {
        app.MapClassificationEndpoints();

        return app;
    }
}