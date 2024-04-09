using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Repositories;

public interface ITeamRepository
{
    Task Add(Team team);
    Task<Team> Get(int id);
}