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

    public Task<TeamResponse> GetTeam(int id)
    {
        throw new NotImplementedException();
    }

    Task<FootballerResponse> ITournamentModuleApi.GetFootballer(int id)
    {
        throw new NotImplementedException();
    }

    Task<IReadOnlyCollection<MatchResponse>> ITournamentModuleApi.GetMatches(int[] matchIds)
    {
        throw new NotImplementedException();
    }
}
