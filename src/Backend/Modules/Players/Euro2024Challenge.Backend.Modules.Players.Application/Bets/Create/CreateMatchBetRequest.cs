namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Create
{
    public sealed record CreateMatchBetRequest(Guid PlayerId, int MatchId, int Result, int HomeTeamGoals, int AwayTeamGoals);
}
