using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Create
{
    public sealed record CreateTurnamentWinnerBetCommand(Guid PLayerId, int TeamId) : IRequest<Unit>;
}
