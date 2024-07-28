namespace Euro2024Challenge.Backend.Modules.Classification.Infrastructure.Database.Models
{
    public class PlayerBetPoints
    {
        public string Id { get; set; }

        public string PlayerId { get; set; }

        public string BetId { get; set; }
        
        public int Points { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
