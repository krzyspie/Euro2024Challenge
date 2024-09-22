
using Euro2024Challenge.Backend.Modules.Players.Application.Players.DTO;
using Euro2024Challenge.Backend.Modules.Players.Domain.Repositories;
using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Players.Get;

public class GetPlayersQueryHandler : IRequestHandler<GetPlayersQuery, IEnumerable<PlayerDto>>
{
    private readonly IPlayersRepository _playersRepository;

    public GetPlayersQueryHandler(IPlayersRepository playersRepository)
    {
        _playersRepository = playersRepository;
    }

    public async Task<IEnumerable<PlayerDto>> Handle(GetPlayersQuery request, CancellationToken cancellationToken)
    {
        return await _playersRepository.GetAllPlayers();
    }
}
