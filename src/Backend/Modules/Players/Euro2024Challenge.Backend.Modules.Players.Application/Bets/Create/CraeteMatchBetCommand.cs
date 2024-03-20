using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Create
{
    public sealed record CraeteMatchBetCommand(Guid PLayerId, int MatchId, int Result, int HomeTeamGoals, int AwayTeamGoals) : IRequest<Unit>;
}
