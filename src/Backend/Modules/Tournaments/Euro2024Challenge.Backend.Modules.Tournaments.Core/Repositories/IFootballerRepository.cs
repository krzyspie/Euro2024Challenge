using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Repositories;

public interface IFootballerRepository
{
    Task Add(Footballer footballer);
    Task UpdateGoals(int id, int goals);
    Task<Footballer> Get(int id);
}