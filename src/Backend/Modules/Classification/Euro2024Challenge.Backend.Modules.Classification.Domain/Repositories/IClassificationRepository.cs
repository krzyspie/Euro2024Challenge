using Euro2024Challenge.Backend.Modules.Classification.Domain.Entities;

namespace Euro2024Challenge.Backend.Modules.Classification.Domain.Repositories;

public interface IClassificationRepository
{
    Task<IEnumerable<PlayerPoints>> GetAll();

    Task Add(PlayerPoints points);
}