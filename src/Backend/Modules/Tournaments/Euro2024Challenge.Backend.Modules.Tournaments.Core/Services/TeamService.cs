using Euro2024Challenge.Backend.Modules.Tournament.Shared.DTO;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Extensions;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Repositories;
using Microsoft.EntityFrameworkCore.Storage.Json;
using Microsoft.Extensions.Caching.Memory;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Services;

public class TeamService : ITeamService
{
    private readonly ITeamRepository _teamRepository;
    private readonly IMemoryCache _cache;

    public TeamService(ITeamRepository teamRepository, IMemoryCache cache)
    {
        _teamRepository = teamRepository;
        _cache = cache;
    }
    
    public async Task<IEnumerable<TeamResponse>> GetTeamsAsync(List<int> ids)
    {
        var stats = _cache.GetCurrentStatistics();

        var teams = await _teamRepository.GetTeamsAsync(ids);

        return teams.ToTeamsResponse();
    }

    public async Task<TeamResponse> GetTeamAsync(int id)
    {
        if(!_cache.TryGetValue(id, out string? teamName))
        {
            var team = await _teamRepository.GetTeamAsync(id);
            
            _cache.Set(id, team.Name);
            
            return team.ToTeamResponse();
        }
        
        return new TeamResponse(id, teamName!);        
    }
}