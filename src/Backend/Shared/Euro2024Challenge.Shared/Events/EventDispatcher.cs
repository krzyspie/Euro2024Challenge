
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

        var tasks = handlers.Select(x => x.HandleAsync(integrationEvent));
        await Task.WhenAll(tasks);
    }
}
