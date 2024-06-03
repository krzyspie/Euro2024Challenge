namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.DTO
{
    public class PlayerBetsDto
    {
        public Guid PlayerId { get; set; }
        
        public IEnumerable<PlayerMatchBetDto> MatchBets { get; set; }

        public PlayerTopScorerBetDto TopScorerBet { get; set; }

        public PlayerTournamentWinnerBetDto TournamentWinner { get; set; }
    }
}