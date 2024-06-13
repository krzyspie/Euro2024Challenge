using Euro2024Challenge.Backend.Modules.Tournament.Shared.DTO;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Extensions;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Repositories;
using Microsoft.Extensions.Caching.Memory;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Services;

public class TeamService : ITeamService
{
    private const string TeamsKey = "teams-key";
    private readonly ITeamRepository _teamRepository;
    private readonly IMemoryCache _cache;

    public TeamService(ITeamRepository teamRepository, IMemoryCache cache)
    {
        _teamRepository = teamRepository;
        _cache = cache;
    }
    
    public async Task<IEnumerable<TeamResponse>> GetTeamsAsync(List<int> ids)
    {
        if(!_cache.TryGetValue(TeamsKey, out Dictionary<int, string>? allTeams))
        {
            var teams = await _teamRepository.GetAllTeamsAsync();
            
            _cache.Set(TeamsKey, teams);
            
            var teamsDto = teams.ToTeamsResponse();

            return teamsDto.Where(x => ids.Contains(x.Id));
        }

        var resultTeams = allTeams!.ToTeamsResponse();

        return resultTeams.Where(x => ids.Contains(x.Id));
    }

    public async Task<TeamResponse> GetTeamAsync(int id)
    {
        if(!_cache.TryGetValue(TeamsKey, out Dictionary<int, string>? allTeams))
        {
            var teams = await _teamRepository.GetAllTeamsAsync();
            
            _cache.Set(TeamsKey, teams);
            
            var teamsDto = teams.ToTeamsResponse();

            return teamsDto.First(x => x.Id == id);
        }

        return new TeamResponse(id, allTeams[id]);        
    }
}