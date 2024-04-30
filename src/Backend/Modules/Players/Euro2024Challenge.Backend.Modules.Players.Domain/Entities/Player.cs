using Euro2024Challenge.Shared.Domain;

namespace Euro2024Challenge.Backend.Modules.Players.Domain.Entities
{
    public sealed class Player : BaseEntity, IAggregateRoot
    {
        public required string Email { get; set; }
        public required string Username { get; set; }

        public TopScorerBet TopScorerBet { get; set; } = null!;
        public TournamentWinnerBet TournamentWinnerBet { get; set; } = null!;
        public ICollection<MatchBet> MatchBets { get; set; } = new List<MatchBet>();
    }
}
