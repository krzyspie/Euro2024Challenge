
using Microsoft.Extensions.DependencyInjection;

namespace Euro2024Challenge.Shared;

public class EventDispatcher : IEventDispatcher
{
    private readonly IServiceProvider _serviceProvider;

    public EventDispatcher(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task PublishAsync<TEvent>(TEvent integrationEvent, CancellationToken cancellationToken) where TEvent : class, IEvent
    {

        using var scope = _serviceProvider.CreateScope();
        var handlers = scope.ServiceProvider.GetServices<IEventHandler<TEvent>>();

        var handlerType = typeof(IEventHandler<>).MakeGenericType(integrationEvent.GetType());
        var handlers3 = scope.ServiceProvider.GetServices(handlerType);
        var method = handlerType.GetMethod(nameof(IEventHandler<IEvent>.HandleAsync));
        var tasks = handlers3.Select(x => (Task)method.Invoke(x, new object[] { integrationEvent, cancellationToken }));
        var tasks2 = handlers.Select(x => x.HandleAsync(integrationEvent, cancellationToken));

        await Task.WhenAll(tasks);
    }
}
