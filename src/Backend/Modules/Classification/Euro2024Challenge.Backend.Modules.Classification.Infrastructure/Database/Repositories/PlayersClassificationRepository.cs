using Euro2024Challenge.Backend.Modules.Classification.Domain.Entities;
using Euro2024Challenge.Backend.Modules.Classification.Domain.Repositories;

namespace Euro2024Challenge.Backend.Modules.Classification.Infrastructure.Database.Repositories;

public class PlayersClassificationRepository : IClassificationRepository
{
    public Task<IEnumerable<PlayersPoints>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task Insert(PlayerPoints points)
    {
        throw new NotImplementedException();
    }

    public Task<PlayerPoints> Get(Guid playerId)
    {
        throw new NotImplementedException();
    }
}