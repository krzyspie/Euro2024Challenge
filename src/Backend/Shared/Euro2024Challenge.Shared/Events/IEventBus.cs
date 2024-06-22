namespace Euro2024Challenge.Shared;

public interface IEventBus
{
    Task PublishAsync<T>(
        T integrationEvent,
        CancellationToken cancellationToken = default)
        where T : class, IEvent;

}
