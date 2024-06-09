using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Repositories;

public interface ITeamRepository
{
    Task<IDictionary<int, string>> GetTeamsAsync(IEnumerable<int> ids);
    Task<IDictionary<int, string>> GetAllTeamsAsync();
    Task<Team> GetTeamAsync(int id);
}