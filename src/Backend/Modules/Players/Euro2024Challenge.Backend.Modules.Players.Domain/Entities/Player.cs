namespace Euro2024Challenge.Backend.Modules.Players.Domain.Entities
{
    public sealed class Player : BaseEntity
    {
        public required string Email { get; set; }
        public required string Username { get; set; }

        public TopScorerBet TopScorerBet { get; set; }
        public TournamentWinnerBet TournamentWinnerBet { get; set; }
        public ICollection<MatchBet> MatchBets { get; set; }
    }
}
