namespace Euro2024Challenge.Backend.Modules.Players.Domain.Entities
{
    public class TopScorerBet : BaseEntity
    {
        public Guid PlayerId { get; set; }

        public int FootballerId { get; set; }

        public int Goals { get; set; }
    }
}
