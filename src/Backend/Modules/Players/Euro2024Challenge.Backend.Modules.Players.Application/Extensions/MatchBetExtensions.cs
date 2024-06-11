using Euro2024Challenge.Backend.Modules.Players.Application.Bets.DTO;
using Euro2024Challenge.Backend.Modules.Players.Domain.Entities;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Extensions;

public static class MatchBetExtensions
{
    private static PlayerMatchBetDto ToPlayerMatchBetDto(this MatchBet matchBet, Tournament.Shared.DTO.MatchResponse match)
    {
        return new PlayerMatchBetDto
        {
            PlayerId = matchBet.PlayerId,
            MatchId = matchBet.MatchId,
            HomeTeam = match.GuestTeamName,
            HomeTeamGoals = matchBet.Result.HomeTeamGoals,
            AwayTeam = match.AwayTeamName,
            AwayTeamGoals = matchBet.Result.AwayTeamGoals,
            Result = matchBet.Winner.ToStringOutput(match.AwayTeamName, match.GuestTeamName)
        };
    }
    
    public static IEnumerable<PlayerMatchBetDto> ToPlayerMatchBetDto(this IEnumerable<MatchBet> matchBets, IReadOnlyCollection<Tournament.Shared.DTO.MatchResponse> matches)
    {
        return matchBets.Select(x => {
            var match = matches.First(m => m.Number == x.MatchId);
            return x.ToPlayerMatchBetDto(match);

        } );
    }
}