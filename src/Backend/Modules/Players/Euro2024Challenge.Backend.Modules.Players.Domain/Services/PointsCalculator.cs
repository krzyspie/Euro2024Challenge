using Euro2024Challenge.Backend.Modules.Players.Domain.Entities;
using Euro2024Challenge.Backend.Modules.Players.Domain.ValueObjects;

namespace Euro2024Challenge.Backend.Modules.Players.Domain.Services;

public class PointsCalculator : IPointsCalculator
{
    public int CalculateMatchPoints(int homeTeamGoals, int awayTeamGoals, MatchResult? bet)
    {
        if (bet is null)
        {
            return 0;
        }
        
        if (bet.HomeTeamGoals == homeTeamGoals && bet.AwayTeamGoals == awayTeamGoals)
        {
            return 5;
        }

        var resultDifference = homeTeamGoals - awayTeamGoals;
        var betResultDifference = bet.HomeTeamGoals - bet.AwayTeamGoals; 
        if (resultDifference == betResultDifference)
        {
            return 3;
        }

        return 0;
    }

    public int CalculateTournamentWinnerPoints(int winnerTeamId, TournamentWinnerBet tournamentWinnerBet)
    {
        return winnerTeamId == tournamentWinnerBet.TeamId ? 10 : 0;
    }

    public int CalculateFootballerGoalsPoints()
    {
        return 0;
    }
}
