using Microsoft.Extensions.DependencyInjection;

namespace Euro2024Challenge.Shared;

public static class DependencyInjection
{
    public static IServiceCollection RegisterShared(this IServiceCollection services)
    {
        services.AddSingleton<IEventDispatcher, EventDispatcher>();
        services.AddSingleton<IEventBus, EventBus>();
        services.AddSingleton<InMemoryMessageQueue>();
        services.AddHostedService<IntegrationEventProcessorJob>();
        services.Scan(s => s.FromAssemblies(AppDomain.CurrentDomain.GetAssemblies())
            .AddClasses(c => c.AssignableTo(typeof(IEventHandler<>)))
            .AsImplementedInterfaces()
            .WithScopedLifetime());

        return services;
    }

}
