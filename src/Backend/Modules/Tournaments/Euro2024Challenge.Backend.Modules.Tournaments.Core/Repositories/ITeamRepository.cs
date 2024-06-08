using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Repositories;

public interface ITeamRepository
{
    Task<IEnumerable<Team>> GetTeamsAsync(List<int> ids);
    Task<Team> GetTeamAsync(int id);
}