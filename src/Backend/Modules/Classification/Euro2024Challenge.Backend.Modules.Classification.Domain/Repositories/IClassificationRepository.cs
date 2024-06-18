using Euro2024Challenge.Backend.Modules.Classification.Domain.Entities;

namespace Euro2024Challenge.Backend.Modules.Classification.Domain.Repositories;

public interface IClassificationRepository
{
    Task<List<PlayersPoints>> GetAll();

    Task Insert(BetPoints points);
    Task<IReadOnlyCollection<BetPoints>> Get(Guid playerId);
}