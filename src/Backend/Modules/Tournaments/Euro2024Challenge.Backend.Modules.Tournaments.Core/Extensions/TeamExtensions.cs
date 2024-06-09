using Euro2024Challenge.Backend.Modules.Tournament.Shared.DTO;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Extensions;

public static class TeamExtensions
{
    public static IEnumerable<TeamResponse> ToTeamsResponse(this IDictionary<int, string> teams)
    {
        return teams.Select(team => new TeamResponse(team.Key, team.Value));
    }

    public static TeamResponse ToTeamResponse(this Team team)
    {
        return new TeamResponse(team.Id, team.Name);
    }
}