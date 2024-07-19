using Euro2024Challenge.Backend.Modules.Players.Domain;
using Euro2024Challenge.Backend.Modules.Players.Domain.Repositories;
using Euro2024Challenge.Backend.Modules.Players.Shared.Events;
using Euro2024Challenge.Backend.Modules.Tournament.Shared;
using Euro2024Challenge.Shared;

namespace Euro2024Challenge.Backend.Modules.Players.Application.IntegrationEvents.Handlers;

public class MatchUpdatedHandler : IEventHandler<MatchUpdated>
{
    private readonly IEventBus _eventBus;
    private readonly IPlayersRepository _playersRepository;
    private readonly IPointsCalculator _pointsCalculator;

    public MatchUpdatedHandler(IEventBus eventBus, IPlayersRepository playersRepository, IPointsCalculator pointsCalculator)
    {
        _eventBus = eventBus;
        _playersRepository = playersRepository;
        _pointsCalculator = pointsCalculator;
    }
    public async Task HandleAsync(MatchUpdated integrationEvent, CancellationToken cancellationToken = default)
    {
        Console.WriteLine("MatchUpdatedHandler integrationEvent");

        var playersMatchBets = await _playersRepository.GetAllPlayersMatchBets();

        foreach(var item in playersMatchBets)
        {
            var matchBet = item.MatchBets.FirstOrDefault(x => x.MatchId == integrationEvent.MatchId);
            if (matchBet is null)
            {
                continue;
            }

            var betPoints = _pointsCalculator.CalculateMatchPoints(integrationEvent.HomeTeamGoals, integrationEvent.AwayTeamGoals, matchBet.Result);

            await _eventBus.PublishAsync(new PlayersMatchBetsClaculated(item.Id, integrationEvent.MatchId, betPoints));
        }
    }
}