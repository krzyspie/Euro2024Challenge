using Euro2024Challenge.Backend.Modules.Tournaments.Core.DTO;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Services;

public interface IMatchService
{
    Task Add(AddMatchRequest match);
    Task UpdateResult(int number, int guestTeamGoals, int awayTeamGoals);
    Task<IEnumerable<MatchResponse>> GetAll();
    Task<MatchResponse> GetByNumber(int number);
}