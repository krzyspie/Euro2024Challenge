using Euro2024Challenge.Backend.Modules.Tournament.Shared.DTO;

namespace Euro2024Challenge.Backend.Modules.Tournament.Shared;


public interface ITournamentModuleApi
{
    Task<IReadOnlyCollection<MatchResponse>> GetMatches(int[] matchIds);
    Task<TeamResponse> GetTeam(int id);
    Task<FootballerResponse> GetFootballer(int id);
}