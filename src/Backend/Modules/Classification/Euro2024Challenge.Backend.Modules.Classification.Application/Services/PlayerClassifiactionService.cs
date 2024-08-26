using Euro2024Challenge.Backend.Modules.Classification.Domain.Repositories;

namespace Euro2024Challenge.Backend.Modules.Classification.Application.Services;

public class PlayerClassifiactionService : IPlayerClassificationService
{
    private readonly IClassificationRepository _classificationRepository;

    public PlayerClassifiactionService(IClassificationRepository classificationRepository)
    {
        _classificationRepository = classificationRepository;
    }

    public async Task UpdatePlayerPoints(Guid playerId, int betId)
    {
        var playerBetPoints = await _classificationRepository.GetBetPoints(playerId, betId);
    }
}