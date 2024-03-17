namespace Euro2024Challenge.Backend.Modules.Players.Domain.Entities
{
    public class MatchBet : BaseEntity
    {
        public Guid PlayerId { get; set; }
        public int MatchId { get; set; }
        public int Result { get; set; }
        public int HomeTeamGoals { get; set; }
        public int AwayTeamGoals { get; set; }
    }
}
