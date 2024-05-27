using Euro2024Challenge.Backend.Modules.Players.Domain.Entities;

namespace Euro2024Challenge.Backend.Modules.Players.Domain.Repositories;

public interface IPlayersBetsRepository
{
    Task CreateMatchBetAsync(MatchBet matchBet);
    Task UpdateMatchBetAsync(MatchBet matchBet);
    Task CreateTopScorerBetAsync(TopScorerBet topScorerBet);
    Task UpdateTopScorerBetAsync(TopScorerBet topScorerBet);
    Task CreateTournamentWinnerBetAsync(TournamentWinnerBet tournamentWinnerBet);
    Task UpdateTournamentWinnerBetAsync(TournamentWinnerBet tournamentWinnerBet);
}