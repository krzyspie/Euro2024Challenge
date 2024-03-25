using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Players.Commands
{
    public sealed record GetPlayerMatchBetsCommand(Guid PlayerId) : IRequest<Unit>;
}
