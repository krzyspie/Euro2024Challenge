using Euro2024Challenge.Backend.Modules.Players.Shared.Events;
using Euro2024Challenge.Shared;

namespace Euro2024Challenge.Backend.Modules.Classification.Application.IntegrationEvents.Handlers;

public class MatchUpdatedHandler : IEventHandler<PlayersMatchBetsClaculated>
{
    public Task HandleAsync(PlayersMatchBetsClaculated integrationEvent, CancellationToken cancellationToken = default)
    {
        Console.WriteLine("PlayersMatchBetsClaculated integrationEvent");

        return Task.CompletedTask;
    }
}