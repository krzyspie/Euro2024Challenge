using Euro2024Challenge.Backend.Modules.Classification.Domain.Entities;

namespace Euro2024Challenge.Backend.Modules.Classification.Domain.Repositories;

public interface IClassificationRepository
{
    Task<List<PlayerBetPoints>> GetAll();
    Task Insert(PlayerBetPoints playerBetPoints);
    Task<IReadOnlyCollection<PlayerBetPoints>> Get(Guid playerId);
    Task<PlayerBetPoints> GetBetPoints(Guid playerId, Guid betId);
    Task Update(PlayerBetPoints playerBetPoints);
}