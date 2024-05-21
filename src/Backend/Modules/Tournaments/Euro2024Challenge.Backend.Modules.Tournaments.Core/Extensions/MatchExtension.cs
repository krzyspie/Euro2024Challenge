using Euro2024Challenge.Backend.Modules.Tournaments.Core.DTO;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Extensions;

public static class MatchExtension
{
    public static MatchResponse ToMatchResponse(this Match match)
    {
        return new MatchResponse(match.Id, match.Number, match.GuestTeamId, match.AwayTeamId, match.GuestTeamGoals,
            match.AwayTeamGoals, match.StartHour);
    }

    public static IEnumerable<MatchResponse> ToMatchesResponse(this IEnumerable<Match> matches)
    {
        return matches.Select(x => new MatchResponse(x.Id, x.Number, x.GuestTeamId, x.AwayTeamId, x.GuestTeamGoals,
            x.AwayTeamGoals, x.StartHour));
    }
}