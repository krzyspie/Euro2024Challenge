using Euro2024Challenge.Backend.Modules.Classification.Domain.Entities;
using Euro2024Challenge.Backend.Modules.Classification.Domain.Repositories;

namespace Euro2024Challenge.Backend.Modules.Classification.Application.Services;

public class PlayerClassifiactionService : IPlayerClassificationService
{
    private readonly IClassificationRepository _classificationRepository;

    public PlayerClassifiactionService(IClassificationRepository classificationRepository)
    {
        _classificationRepository = classificationRepository;
    }

    public async Task UpdatePlayerPoints(Guid playerId, Guid betId, int points)
    {
        var playerBetPoints = await _classificationRepository.GetBetPoints(playerId, betId);
        
        if (playerBetPoints is null)
        {
            PlayerBetPoints betPoints = new()
            {
                Id = Guid.NewGuid().ToString(),
                PlayerId = playerId.ToString(),
                BetId = betId.ToString(),
                Points = points
            };

            await _classificationRepository.Insert(betPoints);
        }
        else
        {
            PlayerBetPoints betPoints = new()
            {
                Id = playerBetPoints.Id,
                PlayerId = playerId.ToString(),
                BetId = betId.ToString(),
                Points = playerBetPoints.Points + points
            };
            
            await _classificationRepository.Update(betPoints);
        }
    }
}