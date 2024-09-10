namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Cache;

public interface ITeamsCache
{
    bool TryGetValue(out Dictionary<int, string>? value);

    void Set(Dictionary<int, string>? value);
}
