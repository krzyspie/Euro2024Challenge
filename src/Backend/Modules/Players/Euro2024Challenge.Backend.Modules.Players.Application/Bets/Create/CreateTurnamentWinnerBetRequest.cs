namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Create
{
    public sealed record CreateTurnamentWinnerBetRequest(Guid PLayerId, int TeamId);
}
