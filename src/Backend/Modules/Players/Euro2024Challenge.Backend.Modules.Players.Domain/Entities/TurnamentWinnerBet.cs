namespace Euro2024Challenge.Backend.Modules.Players.Domain.Entities
{
    public class TurnamentWinnerBet : BaseEntity
    {
        public Guid PlayerId { get; set; }

        public Guid TeamId { get; set; }
    }
}
