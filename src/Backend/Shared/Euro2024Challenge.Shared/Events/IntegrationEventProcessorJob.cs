using Microsoft.Extensions.Hosting;

namespace Euro2024Challenge.Shared;

internal sealed class IntegrationEventProcessorJob : BackgroundService
{
    private readonly InMemoryMessageQueue _messageQueue;
    private readonly IEventDispatcher _eventDispatcher;

    public IntegrationEventProcessorJob(InMemoryMessageQueue messageQueue, IEventDispatcher eventDispatcher)
    {
        _messageQueue = messageQueue;
        _eventDispatcher = eventDispatcher;
    }
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await foreach (var integrationEvent in _messageQueue.Reader.ReadAllAsync(stoppingToken))
        {
            try
            {
                await _eventDispatcher.PublishAsync(integrationEvent, stoppingToken);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
