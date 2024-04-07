namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Footballer> Footballers { get; set; }
    }
}