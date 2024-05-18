using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Repositories;

public interface IFootballerRepository
{
    Task UpdateAsync(Footballer footballer);
    Task<Footballer> Get(int id);
}