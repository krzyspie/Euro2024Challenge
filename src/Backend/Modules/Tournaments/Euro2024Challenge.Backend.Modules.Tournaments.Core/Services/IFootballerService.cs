using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Services;

public interface IFootballerService
{
    Task Add(Footballer footballer);
    Task UpdateGoals(int goals);
    Task<Footballer> Get(int id);
}