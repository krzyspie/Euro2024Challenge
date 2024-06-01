using Euro2024Challenge.Backend.Modules.Players.Domain.Enums;
using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Update
{
    public sealed record UpdateMatchBetCommand(Guid PLayerId, int MatchId, MatchWinner Winner, int HomeTeamGoals, int AwayTeamGoals) : IRequest<Unit>;
}
