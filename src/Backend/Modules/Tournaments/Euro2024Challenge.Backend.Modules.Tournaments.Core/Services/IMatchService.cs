using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Services;

public interface IMatchService
{
    Task Add(Match? match);
    Task UpdateResult(int number, int guestTeamGoals, int awayTeamGoals);
    Task<IEnumerable<Match>> GetAll();
    Task<Match?> GetByNumber(int number);
}