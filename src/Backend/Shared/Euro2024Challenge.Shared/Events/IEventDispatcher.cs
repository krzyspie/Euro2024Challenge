namespace Euro2024Challenge.Shared;

public interface IEventDispatcher
{
    Task PublishAsync<TEvent>(TEvent integrationEvent, CancellationToken cancellationToken = default)
        where TEvent : class, IEvent;
}
