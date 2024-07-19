namespace Euro2024Challenge.Backend.Modules.Players.Domain;

public interface IPointsCalculator
{
    int CalculateMatchPoints(int homeTeamGoals, int awayTeamGoals, ValueObjects.MatchResult? result);
    int CalculateTournamentWinnerPoints();
    int CalculateFootballerGoalsPoints();
}