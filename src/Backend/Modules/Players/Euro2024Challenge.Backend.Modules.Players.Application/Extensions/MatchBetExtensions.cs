using Euro2024Challenge.Backend.Modules.Players.Application.Bets.DTO;
using Euro2024Challenge.Backend.Modules.Players.Domain.Entities;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Extensions;

public static class MatchBetExtensions
{
    private static PlayerMatchBetDto ToPlayerMatchBetDto(this MatchBet matchBet)
    {
        return new PlayerMatchBetDto
        {
            PlayerId = matchBet.PlayerId,
            MatchId = matchBet.MatchId,
            HomeTeamGoals = matchBet.Result.HomeTeamGoals,
            AwayTeamGoals = matchBet.Result.AwayTeamGoals,
            Result = (int)matchBet.Winner
        };
    }
    
    public static IEnumerable<PlayerMatchBetDto> ToPlayerMatchBetDto(this IEnumerable<MatchBet> matchBets)
    {
        return matchBets.Select(x => x.ToPlayerMatchBetDto());
    }
}