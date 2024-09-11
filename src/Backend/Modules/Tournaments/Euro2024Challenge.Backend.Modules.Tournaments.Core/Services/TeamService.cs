using Euro2024Challenge.Backend.Modules.Tournament.Shared.DTO;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Cache;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Extensions;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Repositories;
using Microsoft.Extensions.Caching.Memory;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Services;

public class TeamService : ITeamService
{
    private readonly ITeamRepository _teamRepository;
    private readonly ITeamsCache _cache;

    public TeamService(ITeamRepository teamRepository, ITeamsCache cache)
    {
        _teamRepository = teamRepository;
        _cache = cache;
    }
    
    public async Task<IEnumerable<TeamResponse>> GetTeamsAsync(List<int> ids)
    {
        SemaphoreSlim semaphore = new(1, 1);

        if(!_cache.TryGetValue(out Dictionary<int, string>? allTeams))
        {
            try
            {
                await semaphore.WaitAsync();

                if(!_cache.TryGetValue(out allTeams))
                {
                    var teams = await _teamRepository.GetAllTeamsAsync();
                
                    _cache.Set(teams);
                
                    var teamsDto = teams.ToTeamsResponse();

                    return teamsDto.Where(x => ids.Contains(x.Id));
                }
            }
            finally
            {
                semaphore.Release();
            }
        }

        var resultTeams = allTeams!.ToTeamsResponse();

        return resultTeams.Where(x => ids.Contains(x.Id));
    }

    public async Task<TeamResponse> GetTeamAsync(int id)
    {
        SemaphoreSlim semaphore = new(1, 1);

        if(!_cache.TryGetValue(out Dictionary<int, string>? allTeams))
        {
            try
            {
                await semaphore.WaitAsync();
                if(!_cache.TryGetValue(out allTeams))
                {
                    var teams = await _teamRepository.GetAllTeamsAsync();
                
                    _cache.Set(teams);
                
                    var teamsDto = teams.ToTeamsResponse();

                    return teamsDto.First(x => x.Id == id);
                }
            }
            finally
            {
                semaphore.Release();
            }
        }

        return new TeamResponse(id, allTeams![id]);        
    }
}