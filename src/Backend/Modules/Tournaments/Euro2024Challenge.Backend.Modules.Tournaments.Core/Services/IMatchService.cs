using Euro2024Challenge.Backend.Modules.Tournament.Shared.DTO;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.DTO;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Services;

public interface IMatchService
{
    Task Add(AddMatchRequest match);
    Task UpdateResult(int number, int guestTeamGoals, int awayTeamGoals);
    Task<IReadOnlyCollection<MatchResponse>> GetAll();
    Task<MatchResponse> GetByNumber(int number);
    Task<IReadOnlyCollection<MatchResponse>> GetByNumbers(int[] numbers);
}