namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities
{
    public class Footballer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Golas { get; set; }
        
        public int TeamId { get; set; }
        public Team Team { get; set; } = null!;
    }
}