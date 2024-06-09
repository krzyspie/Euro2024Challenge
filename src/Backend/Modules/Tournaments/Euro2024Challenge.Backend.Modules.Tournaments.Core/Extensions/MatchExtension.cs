using Euro2024Challenge.Backend.Modules.Tournament.Shared.DTO;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Extensions;

public static class MatchExtension
{
    public static MatchResponse ToMatchResponse(this Match match, IDictionary<int, string> teams)
    {
        return new MatchResponse(match.Id, match.Number, match.GuestTeamId, teams[match.GuestTeamId],
                                    match.AwayTeamId, teams[match.AwayTeamId], match.GuestTeamGoals,
                                    match.AwayTeamGoals, match.StartHour);
    }

    public static IEnumerable<MatchResponse> ToMatchesResponse(this IEnumerable<Match> matches, IDictionary<int, string> teams)
    {
        return matches
                .Select(x => new MatchResponse(x.Id, x.Number, x.GuestTeamId, teams[x.GuestTeamId], 
                                               x.AwayTeamId, teams[x.AwayTeamId], x.GuestTeamGoals,
                                               x.AwayTeamGoals, x.StartHour));
    }
}