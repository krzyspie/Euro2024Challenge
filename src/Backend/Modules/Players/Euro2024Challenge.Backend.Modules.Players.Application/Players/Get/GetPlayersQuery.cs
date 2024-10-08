using Euro2024Challenge.Backend.Modules.Players.Application.Players.DTO;
using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Players.Get;

public sealed record GetPlayersQuery() : IRequest<IEnumerable<PlayerDto>>;
