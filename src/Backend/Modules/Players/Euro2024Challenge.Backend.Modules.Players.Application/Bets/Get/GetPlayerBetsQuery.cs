using Euro2024Challenge.Backend.Modules.Players.Application.Bets.DTO;
using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Get
{
    public sealed record GetPlayerBetsQuery(Guid PlayerId) : IRequest<PlayerBetsDto>;
}
