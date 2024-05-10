using Euro2024Challenge.Backend.Modules.Classification.Domain.Entities;
using Euro2024Challenge.Backend.Modules.Classification.Domain.Repositories;

namespace Euro2024Challenge.Backend.Modules.Classification.Infrastructure.Database.Repositories;

public class PlayersClassificationRepository : IClassificationRepository
{
    public Task<IEnumerable<PlayerPoints>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task Add(PlayerPoints points)
    {
        throw new NotImplementedException();
    }
}