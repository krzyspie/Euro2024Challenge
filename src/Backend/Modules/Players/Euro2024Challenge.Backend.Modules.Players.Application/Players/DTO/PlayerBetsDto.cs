namespace Euro2024Challenge.Backend.Modules.Players.Application.Players.DTO
{
    public class PlayerBetsDto
    {
        public IEnumerable<PlayerMatchBetDto> MatchBets { get; set; }

        public PlayerTopScorerBetDto TopScorerBet { get; set; }

        public PlayerTurnamentWinnerBetDto TurnamenetWinner { get; set; }
    }
}
