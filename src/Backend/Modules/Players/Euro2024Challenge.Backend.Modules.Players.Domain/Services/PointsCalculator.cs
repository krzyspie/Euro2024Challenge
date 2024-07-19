using Euro2024Challenge.Backend.Modules.Players.Domain.ValueObjects;

namespace Euro2024Challenge.Backend.Modules.Players.Domain.Services;

public class PointsCalculator : IPointsCalculator
{
    public int CalculateMatchPoints(int homeTeamGoals, int awayTeamGoals, MatchResult? result)
    {
        return 0;
    }

    public int CalculateTournamentWinnerPoints()
    {
        return 0;
    }

    public int CalculateFootballerGoalsPoints()
    {
        return 0;
    }
}
