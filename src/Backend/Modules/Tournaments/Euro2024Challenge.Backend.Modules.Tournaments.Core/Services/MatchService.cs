using Euro2024Challenge.Backend.Modules.Tournament.Shared.DTO;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.DTO;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Extensions;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Repositories;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Services;

public class MatchService : IMatchService
{
    private readonly IMatchRepository _matchRepository;
    private readonly ITeamRepository _teamRepository;

    public MatchService(IMatchRepository matchRepository, ITeamRepository teamRepository)
    {
        _matchRepository = matchRepository;
        _teamRepository = teamRepository;
    }

    public async Task Add(AddMatchRequest matchToAdd)
    {
        var match = new Match
        {
            Number = matchToAdd.Number,
            GuestTeamId = matchToAdd.GuestTeamId,
            AwayTeamId = matchToAdd.AwayTeamId,
            GuestTeamGoals = matchToAdd.GuestTeamGoals,
            AwayTeamGoals = matchToAdd.AwayTeamGoals,
            StartHour = matchToAdd.StartHour
        };
        
        await _matchRepository.AddAsync(match);
    }

    public async Task UpdateResult(int number, int guestTeamGoals, int awayTeamsGoals)
    {
        Match match = await _matchRepository.GetByNumber(number);
        match.GuestTeamGoals = guestTeamGoals;
        match.AwayTeamGoals = awayTeamsGoals;
        await _matchRepository.UpdateAsync(match);

        //Invoke event integration MatchResultUpdated
    }

    public async Task<IReadOnlyCollection<MatchResponse>> GetAll()
    {
        var matches =  await _matchRepository.GetAll();
        var teams = await _teamRepository.GetAllTeamsAsync();

        return matches.ToMatchesResponse(teams).ToList().AsReadOnly();
    }

    public async Task<MatchResponse> GetByNumber(int number)
    {
        var teams = await _teamRepository.GetAllTeamsAsync();
        return (await _matchRepository.GetByNumber(number)).ToMatchResponse(teams);
    }

    public async Task<IReadOnlyCollection<MatchResponse>> GetByNumbers(int[] numbers)
    {
        var matches = await _matchRepository.GetByNumbers(numbers);
        var teams = await _teamRepository.GetAllTeamsAsync();

        return matches.ToMatchesResponse(teams).ToList().AsReadOnly();
    }
}