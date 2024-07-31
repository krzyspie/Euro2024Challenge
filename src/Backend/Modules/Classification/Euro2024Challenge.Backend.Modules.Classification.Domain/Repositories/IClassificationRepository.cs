using Euro2024Challenge.Backend.Modules.Classification.Domain.Entities;

namespace Euro2024Challenge.Backend.Modules.Classification.Domain.Repositories;

public interface IClassificationRepository
{
    Task<List<PlayerBetPoints>> GetAll();
    Task Insert(PlayerBetPoints playerBetPoints);
    Task<PlayerBetPoints> Get(Guid playerId);
}