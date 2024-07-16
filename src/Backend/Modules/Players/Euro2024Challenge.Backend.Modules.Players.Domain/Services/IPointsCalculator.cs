namespace Euro2024Challenge.Backend.Modules.Players.Domain;

public interface IPointsCalculator
{
    int CalculateMatchPoints();
    int CalculateTournamentWinnerPoints();
    int CalculateFootballerGoalsPoints();
}