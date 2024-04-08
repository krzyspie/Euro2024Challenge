using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Repositories;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Services;

public class MatchService : IMatchService
{
    private readonly IMatchRepository _matchRepository;

    public MatchService(IMatchRepository matchRepository)
    {
        _matchRepository = matchRepository;
    }
    
    public async Task Add(Match match)
    {
        await _matchRepository.Add(match);
    }

    public async Task UpdateResult(int number, int guestTeamGoals, int awayTeamsGoals)
    {
        await _matchRepository.UpdateResult(guestTeamGoals, awayTeamsGoals);
    }

    public async Task<IEnumerable<Match>> GetAll()
    {
        return await _matchRepository.GetAll();
    }

    public async Task<Match> GetByNumber(int number)
    {
        return await _matchRepository.GetByNumber(number);
    }
}