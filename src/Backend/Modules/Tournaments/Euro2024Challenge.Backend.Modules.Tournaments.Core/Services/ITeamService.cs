using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Services;

public interface ITeamService
{
    Task<Team> Get(int id);
}