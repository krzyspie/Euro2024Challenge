using Microsoft.Extensions.Caching.Memory;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Cache;

public class TeamsCache : ITeamsCache
{
    private const string TeamsKey = "teams-key";
    private readonly IMemoryCache _cache;

    public TeamsCache(IMemoryCache cache)
    {
        _cache = cache;
    }

    public void Set(Dictionary<int, string>? value)
    {
        if (value != null && value.Any())
        {
            _cache.Set(TeamsKey, value);
        }
    }

    public bool TryGetValue(out Dictionary<int, string>? allTeams)
    {
        Dictionary<int, string>? teams = [];
        var hasValue = _cache.TryGetValue(TeamsKey, out teams);
        allTeams = teams;

        return hasValue;
    }
}
