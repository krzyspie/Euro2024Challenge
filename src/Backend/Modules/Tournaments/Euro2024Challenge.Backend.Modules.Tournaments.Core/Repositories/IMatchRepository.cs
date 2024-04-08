using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Repositories;

public interface IMatchRepository
{
    Task Add(Match match);
    Task UpdateResult(int guestTeamGoals, int awayTeamGoals);
    Task<IEnumerable<Match>> GetAll();
    Task<Match> GetByNumber(int number);
}