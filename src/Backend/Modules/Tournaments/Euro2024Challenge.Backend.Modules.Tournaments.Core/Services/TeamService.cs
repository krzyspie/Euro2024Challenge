using Euro2024Challenge.Backend.Modules.Tournament.Shared.DTO;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Extensions;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Repositories;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Services;

public class TeamService : ITeamService
{
    private readonly ITeamRepository _teamRepository;

    public TeamService(ITeamRepository teamRepository)
    {
        _teamRepository = teamRepository;
    }
    
    public async Task<IEnumerable<TeamResponse>> GetTeamsAsync(List<int> ids)
    {
        var teams = await _teamRepository.GetTeamsAsync(ids);

        return teams.ToTeamResponse();
    }

    public async Task<TeamResponse> GetTeamAsync(int ids)
    {
        var team = await _teamRepository.GetTeamAsync(ids);

        return team.ToTeamResponse();
    }
}