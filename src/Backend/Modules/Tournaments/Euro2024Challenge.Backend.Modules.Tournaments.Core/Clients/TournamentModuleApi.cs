using Euro2024Challenge.Backend.Modules.Tournament.Shared;
using Euro2024Challenge.Backend.Modules.Tournament.Shared.DTO;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Services;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core;

public class TournamentModuleApi : ITournamentModuleApi
{
    private readonly IMatchService _matchService;
    private readonly ITeamService _teamService;
    private readonly IFootballerService _footballerService;

    public TournamentModuleApi(IMatchService matchService, ITeamService teamService, IFootballerService footballerService)
    {
        _matchService = matchService;
        _teamService = teamService;
        _footballerService = footballerService;
    }

    public async Task<TeamResponse> GetTeam(int id)
    {
        var result = await _teamService.GetTeamAsync(id);
        return result;
    }

    public async Task<FootballerResponse> GetFootballer(int id)
    {
        var result = await _footballerService.Get(id);
        return result;
    }

    public async Task<IReadOnlyCollection<MatchResponse>> GetMatches(int[] matchIds)
    {
        if(!matchIds.Any())
        {
            return (IReadOnlyCollection<MatchResponse>)Enumerable.Empty<MatchResponse>();
        }

        var result = await _matchService.GetByNumbers(matchIds);
        return result;
    }
}
