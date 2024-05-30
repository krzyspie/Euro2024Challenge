using Euro2024Challenge.Backend.Modules.Players.Domain.Enums;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Create
{
    public sealed record CreateMatchBetRequest(Guid PlayerId, int MatchId, MatchWinner Winner, int HomeTeamGoals, int AwayTeamGoals);
}
