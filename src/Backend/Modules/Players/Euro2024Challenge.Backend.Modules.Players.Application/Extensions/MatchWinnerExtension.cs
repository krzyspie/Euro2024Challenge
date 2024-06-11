using Euro2024Challenge.Backend.Modules.Players.Domain.Enums;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Extensions;

public static class MatchWinnerExtension
{
    public static string ToStringOutput(this MatchWinner matchWinner, string awayTeamName, string homeTeamName)
    {
        return matchWinner switch
        {
            MatchWinner.Draw => "Draw",
            MatchWinner.HomeTeam => homeTeamName,
            MatchWinner.AwayTeam => awayTeamName,
            _ => string.Empty,
        };
    }
}