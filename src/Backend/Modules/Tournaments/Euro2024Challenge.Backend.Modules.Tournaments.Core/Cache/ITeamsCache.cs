using System;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Cache;

public interface ITeamsCache
{
    Dictionary<int, string> TryGetValue();

    void Set(Dictionary<int, string> value);

}
