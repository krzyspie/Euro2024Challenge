namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.DTO
{
    public class PlayerMatchBetDto
    {
        public Guid PlayerId { get; set; }
        public int MatchId { get; set; }
        public int Result { get; set; }
        public int HomeTeamGoals { get; set; }
        public int AwayTeamGoals { get; set; }
    }
}
