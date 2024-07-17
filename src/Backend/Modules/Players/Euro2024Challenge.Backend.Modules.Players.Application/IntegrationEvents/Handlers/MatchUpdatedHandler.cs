using Euro2024Challenge.Backend.Modules.Players.Domain.Repositories;
using Euro2024Challenge.Backend.Modules.Players.Shared.Events;
using Euro2024Challenge.Backend.Modules.Tournament.Shared;
using Euro2024Challenge.Shared;

namespace Euro2024Challenge.Backend.Modules.Players.Application.IntegrationEvents.Handlers;

public class MatchUpdatedHandler : IEventHandler<MatchUpdated>
{
    private readonly IEventBus _eventBus;
    private readonly IPlayersRepository _playersRepository;

    public MatchUpdatedHandler(IEventBus eventBus, IPlayersRepository playersRepository)
    {
        _eventBus = eventBus;
        _playersRepository = playersRepository;
    }
    public async Task HandleAsync(MatchUpdated integrationEvent, CancellationToken cancellationToken = default)
    {
        Console.WriteLine("MatchUpdatedHandler integrationEvent");

        var playersMatchBets = await _playersRepository.GetAllPlayersMatchBets();

        foreach(var item in playersMatchBets)
        {
            await _eventBus.PublishAsync(new PlayersMatchBetsClaculated());
        }
    }
}