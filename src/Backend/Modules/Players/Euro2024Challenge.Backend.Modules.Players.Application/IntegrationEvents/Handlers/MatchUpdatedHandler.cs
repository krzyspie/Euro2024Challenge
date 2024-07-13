using Euro2024Challenge.Backend.Modules.Players.Shared.Events;
using Euro2024Challenge.Backend.Modules.Tournament.Shared;
using Euro2024Challenge.Shared;

namespace Euro2024Challenge.Backend.Modules.Players.Application.IntegrationEvents.Handlers;

public class MatchUpdatedHandler : IEventHandler<MatchUpdated>
{
    private readonly IEventBus _eventBus;

    public MatchUpdatedHandler(IEventBus eventBus)
    {
        _eventBus = eventBus;
    }
    public async Task HandleAsync(MatchUpdated integrationEvent, CancellationToken cancellationToken = default)
    {
        Console.WriteLine("MatchUpdatedHandler integrationEvent");

        await _eventBus.PublishAsync(new PlayersMatchBetsClaculated());
    }
}