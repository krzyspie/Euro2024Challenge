using Euro2024Challenge.Backend.Modules.Tournament.Shared.DTO;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Services;

public interface ITeamService
{
    Task<IEnumerable<TeamResponse>> GetTeamsAsync(List<int> id);
    Task<TeamResponse> GetTeamAsync(int ids);
}