namespace Euro2024Challenge.Backend.Modules.Players.Domain.Entities
{
    public class TournamentWinnerBet : BaseEntity
    {
        public Guid PlayerId { get; set; }

        public Guid TeamId { get; set; }
    }
}
