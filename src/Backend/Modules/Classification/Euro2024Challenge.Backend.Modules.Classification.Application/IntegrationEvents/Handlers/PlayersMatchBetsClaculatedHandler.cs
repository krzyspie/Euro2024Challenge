using Euro2024Challenge.Backend.Modules.Classification.Domain.Repositories;
using Euro2024Challenge.Backend.Modules.Players.Shared.Events;
using Euro2024Challenge.Shared;

namespace Euro2024Challenge.Backend.Modules.Classification.Application.IntegrationEvents.Handlers;

public class MatchUpdatedHandler : IEventHandler<PlayersMatchBetsClaculated>
{
    private readonly IClassificationRepository _classificationRepository;

    public MatchUpdatedHandler(IClassificationRepository classificationRepository)
    {
        _classificationRepository = classificationRepository;
    }

    public async Task HandleAsync(PlayersMatchBetsClaculated integrationEvent, CancellationToken cancellationToken = default)
    {
        Console.WriteLine("PlayersMatchBetsClaculated integrationEvent");
        await _classificationRepository.Update(new());
    }
}