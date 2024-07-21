using Euro2024Challenge.Backend.Modules.Players.Domain.Entities;

namespace Euro2024Challenge.Backend.Modules.Players.Domain.Services;

public interface IPointsCalculator
{
    int CalculateMatchPoints(int homeTeamGoals, int awayTeamGoals, ValueObjects.MatchResult? bet);
    int CalculateTournamentWinnerPoints(int winnerTeamId, TournamentWinnerBet tournamentWinnerBet);
    int CalculateTopScorerFootballerPoints();
}