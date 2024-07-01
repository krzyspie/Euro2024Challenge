using Microsoft.Extensions.DependencyInjection;

namespace Euro2024Challenge.Shared;

public static class DependencyInjection
{
    public static IServiceCollection RegisterShared(this IServiceCollection services)
    {
        services.AddSingleton<IEventDispatcher, EventDispatcher>();
        services.AddHostedService<IntegrationEventProcessorJob>();

        return services;

    }

}
