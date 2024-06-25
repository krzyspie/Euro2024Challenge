namespace Euro2024Challenge.Shared;

public class EventBus : IEventBus
{
    private readonly InMemoryMessageQueue _messageQueue;

    public EventBus(InMemoryMessageQueue messageQueue)
    {
        _messageQueue = messageQueue;
    }
    public async Task PublishAsync<T>(T integrationEvent, CancellationToken cancellationToken) where T : class, IEvent
    {
        await _messageQueue.Writer.WriteAsync(integrationEvent, cancellationToken);
    }
}
