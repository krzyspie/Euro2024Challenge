using Euro2024Challenge.Backend.Modules.Players.Domain.ValueObjects;

namespace Euro2024Challenge.Backend.Modules.Players.Domain.Entities
{
    public class MatchBet : BaseEntity
    {
        public Guid PlayerId { get; set; }
        public int MatchId { get; set; }
        public MatchResult Result { get; set; }
    }
}
