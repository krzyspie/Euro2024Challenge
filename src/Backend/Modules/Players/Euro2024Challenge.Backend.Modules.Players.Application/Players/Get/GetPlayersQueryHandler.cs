
using Euro2024Challenge.Backend.Modules.Players.Application.Players.DTO;
using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Players.Get;

public class GetPlayersQueryHandler : IRequestHandler<GetPlayersQuery, IEnumerable<PlayerDto>>
{
    public Task<IEnumerable<PlayerDto>> Handle(GetPlayersQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
