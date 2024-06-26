using Microsoft.Extensions.Hosting;

namespace Euro2024Challenge.Shared;

internal sealed class IntegrationEventProcessorJob : BackgroundService
{
    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        throw new NotImplementedException();
    }
}
