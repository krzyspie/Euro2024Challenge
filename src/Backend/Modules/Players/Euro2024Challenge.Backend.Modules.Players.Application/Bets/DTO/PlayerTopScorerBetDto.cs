namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.DTO
{
    public class PlayerTopScorerBetDto
    {
        public Guid PlayerId { get; set; }

        public int FootballerId { get; set; }

        public string FullName { get; set; }

        public string TeamName { get; set; }

        public int Goals { get; set; }
    }
}
