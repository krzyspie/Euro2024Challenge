using Euro2024Challenge.Backend.Modules.Classification.Domain.Entities;

namespace Euro2024Challenge.Backend.Modules.Classification.Domain.Repositories;

public interface IClassificationRepository
{
    Task<List<PlayersPoints>> GetAll();
    Task Insert(Guid PlayerId, BetPoints points);
    Task<List<BetPoints>> Get(Guid playerId);
}