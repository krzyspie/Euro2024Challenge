using Euro2024Challenge.Backend.Modules.Classification.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Euro2024Challenge.Backend.Modules.Classification.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));
        services.AddScoped<IPlayerClassificationService, PlayerClassifiactionService>();
        return services;
    }
}