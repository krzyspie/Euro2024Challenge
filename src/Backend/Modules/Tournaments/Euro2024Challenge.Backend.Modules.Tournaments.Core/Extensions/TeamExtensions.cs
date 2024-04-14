using Euro2024Challenge.Backend.Modules.Tournaments.Core.DTO;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Extensions;

public static class TeamExtensions
{
    public static TeamResponse ToTeamResponse(this Team team)
    {
        return new TeamResponse(team.Id, team.Name);
    }
}