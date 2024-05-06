using Euro2024Challenge.Backend.Modules.Classification.Application;
using Euro2024Challenge.Backend.Modules.Classification.Infrastructure;
using Euro2024Challenge.Backend.Modules.Classification.Presentation;
using Microsoft.Extensions.DependencyInjection;

namespace Euro2024Challenge.Backend.Modules.Classification.Api;

public static class RegisterModule
{
    public static IServiceCollection RegisterClassificationModule(this IServiceCollection services)
    {
        services.AddApplication()
            .AddPresentation()
            .AddInfrastructure();

        return services;
    }
}