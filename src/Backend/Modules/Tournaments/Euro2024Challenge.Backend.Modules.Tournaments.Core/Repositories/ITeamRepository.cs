using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Repositories;

public interface ITeamRepository
{
    Task<Team> GetAsync(int id);
}