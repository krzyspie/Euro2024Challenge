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
    
    public async Task Add(Match? match)
    {
        await _matchRepository.AddAsync(match);
    }

    public async Task UpdateResult(int number, int guestTeamGoals, int awayTeamsGoals)
    {
        Match? match = await _matchRepository.GetByNumber(number);
        match.GuestTeamGoals = guestTeamGoals;
        match.AwayTeamGoals = awayTeamsGoals;
        await _matchRepository.UpdateAsync(match);
    }

    public async Task<IEnumerable<Match>> GetAll()
    {
        return await _matchRepository.GetAll();
    }

    public async Task<Match?> GetByNumber(int number)
    {
        return await _matchRepository.GetByNumber(number);
    }
}