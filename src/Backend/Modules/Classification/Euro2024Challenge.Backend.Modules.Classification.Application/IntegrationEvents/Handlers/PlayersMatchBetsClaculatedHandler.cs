using Euro2024Challenge.Backend.Modules.Classification.Application.Services;
using Euro2024Challenge.Backend.Modules.Players.Shared.Events;
using Euro2024Challenge.Shared;

namespace Euro2024Challenge.Backend.Modules.Classification.Application.IntegrationEvents.Handlers;

public class MatchUpdatedHandler : IEventHandler<PlayersMatchBetsClaculated>
{
    private readonly IPlayerClassificationService _playerClassificationService;

    public MatchUpdatedHandler(IPlayerClassificationService playerClassificationService)
    {
        _playerClassificationService = playerClassificationService;
    }

    public async Task HandleAsync(PlayersMatchBetsClaculated integrationEvent, CancellationToken cancellationToken = default)
    {
        Console.WriteLine("PlayersMatchBetsClaculated integrationEvent");
        
        await _playerClassificationService.UpdatePlayerPoints();
    }
}