using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Repositories;

public interface ITeamRepository
{
    Task<Dictionary<int, string>> GetTeamsAsync(IEnumerable<int> ids);
    Task<Dictionary<int, string>> GetAllTeamsAsync();
    Task<Team> GetTeamAsync(int id);
}