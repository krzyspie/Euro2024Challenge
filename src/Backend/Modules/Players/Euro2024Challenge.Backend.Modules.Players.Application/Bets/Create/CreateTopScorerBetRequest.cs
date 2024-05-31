namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Create
{
    public sealed record CreateTopScorerBetRequest(Guid PlayerId, int FootballerId, int Goals);
}
