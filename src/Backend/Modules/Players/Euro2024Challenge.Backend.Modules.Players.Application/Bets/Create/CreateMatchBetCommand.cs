using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Create
{
    public sealed record CreateMatchBetCommand(Guid PLayerId, int MatchId, int Result, int HomeTeamGoals, int AwayTeamGoals) : IRequest<Unit>;
}
