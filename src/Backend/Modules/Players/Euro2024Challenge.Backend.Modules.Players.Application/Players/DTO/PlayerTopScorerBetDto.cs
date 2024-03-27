namespace Euro2024Challenge.Backend.Modules.Players.Application.Players.DTO
{
    public class PlayerTopScorerBetDto
    {
        public Guid PlayerId { get; set; }

        public Guid FootballerId { get; set; }

        public int Goals { get; set; }
    }
}
