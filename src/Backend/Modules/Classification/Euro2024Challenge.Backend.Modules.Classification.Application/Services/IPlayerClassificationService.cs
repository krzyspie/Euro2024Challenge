namespace Euro2024Challenge.Backend.Modules.Classification.Application.Services;

public interface IPlayerClassificationService
{
    Task UpdatePlayerPoints(Guid playerId, int betId, int points);
}
