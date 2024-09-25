namespace Euro2024Challenge.Backend.Modules.Classification.Application.Services;

public interface IPlayerClassificationService
{
    Task UpdatePlayerPoints(Guid playerId, Guid betId, int points);
}
