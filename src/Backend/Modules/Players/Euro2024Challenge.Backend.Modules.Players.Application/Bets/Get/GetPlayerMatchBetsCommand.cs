using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Get
{
    public sealed record GetPlayerMatchBetsCommand(Guid PlayerId) : IRequest<Unit>;
}
