namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Update
{
    public sealed record UpdateTournamentWinnerBetRequest(Guid PlayerId, int TeamId);
}
