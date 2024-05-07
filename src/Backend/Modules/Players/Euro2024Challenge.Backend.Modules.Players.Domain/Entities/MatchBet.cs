using Euro2024Challenge.Backend.Modules.Players.Domain.Enums;
using Euro2024Challenge.Backend.Modules.Players.Domain.ValueObjects;
using Euro2024Challenge.Shared.Domain;

namespace Euro2024Challenge.Backend.Modules.Players.Domain.Entities
{
    public class MatchBet : BaseEntity
    {
        public Guid PlayerId { get; set; }
        public int MatchId { get; set; }
        public MatchResult? Result { get; set; }
        public MatchWinner Winner { get; set; }
    }
}
