namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities
{
    public class Footballer
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public string Name { get; set; }
        public int Golas { get; set; }       
    }
}