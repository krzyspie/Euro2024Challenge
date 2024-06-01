using Euro2024Challenge.Backend.Modules.Players.Domain.Enums;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Update
{
    public sealed record UpdateMatchBetRequest(Guid PlayerId, int MatchId, MatchWinner Winner, int HomeTeamGoals, int AwayTeamGoals);
}
