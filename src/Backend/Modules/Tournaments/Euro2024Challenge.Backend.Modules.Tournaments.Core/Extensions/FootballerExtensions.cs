using Euro2024Challenge.Backend.Modules.Tournament.Shared.DTO;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Extensions;

public static class FootballerExtensions
{
    public static FootballerResponse ToFootballerResponse(this Footballer footballer)
    {
        return new FootballerResponse(footballer.Id, footballer.FullName, footballer.Goals, footballer.Team.Name);
    }
}