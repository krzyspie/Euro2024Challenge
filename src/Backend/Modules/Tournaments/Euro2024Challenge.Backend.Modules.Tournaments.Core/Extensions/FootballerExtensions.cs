using Euro2024Challenge.Backend.Modules.Tournaments.Core.DTO;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Extensions;

public static class FootballerExtensions
{
    public static FootballerResponse ToTeamResponse(this Footballer footballer)
    {
        return new FootballerResponse(footballer.Id, footballer.FullName, footballer.Golas, footballer.Team.Name);
    }
}