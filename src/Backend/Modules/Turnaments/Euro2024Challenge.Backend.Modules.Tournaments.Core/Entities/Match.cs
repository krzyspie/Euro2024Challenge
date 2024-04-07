namespace Euro2024Challenge.Backend.Modules.Turnaments.Core
{
    public class Match
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int GuestTeamId { get; set; }
        public int AwayTeamId { get; set; }
        public int GuestTeamGoals { get; set; }
        public int AwayTeamGoals { get; set; }
    }
}