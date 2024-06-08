using Euro2024Challenge.Backend.Modules.Tournament.Shared.DTO;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Extensions;

public static class TeamExtensions
{
    public static IEnumerable<TeamResponse> ToTeamResponse(this IEnumerable<Team> teams)
    {
        return teams.Select(team => new TeamResponse(team.Id, team.Name));
    }

    public static TeamResponse ToTeamResponse(this Team team)
    {
        return new TeamResponse(team.Id, team.Name);
    }
}