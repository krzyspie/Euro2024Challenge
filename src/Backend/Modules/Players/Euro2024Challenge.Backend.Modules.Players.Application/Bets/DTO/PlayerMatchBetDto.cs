namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.DTO
{
    public class PlayerMatchBetDto
    {
        public Guid PlayerId { get; set; }
        public int MatchId { get; set; }
        public string Result { get; set; }
        public int HomeTeamGoals { get; set; }
        public string HomeTeam { get; set; }
        public int AwayTeamGoals { get; set; }
        public string AwayTeam { get; set; }
    }
}