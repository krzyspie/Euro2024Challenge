using Euro2024Challenge.Backend.Modules.Classification.Domain.Entities;

namespace Euro2024Challenge.Backend.Modules.Classification.Domain.Repositories;

public interface IClassificationRepository
{
    Task<IEnumerable<PlayersPoints>> GetAll();

    Task Insert(PlayerPoints points);
    Task<PlayerPoints> Get(Guid playerId);
}