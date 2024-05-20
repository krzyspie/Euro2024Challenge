using Euro2024Challenge.Backend.Modules.Tournaments.Core.DTO;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Services;

public interface ITeamService
{
    Task<IEnumerable<TeamResponse>> GetTeamsAsync(List<int> id);
}