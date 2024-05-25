using Euro2024Challenge.Backend.Modules.Players.Application.Extensions;
using Euro2024Challenge.Backend.Modules.Players.Application.Players.DTO;
using Euro2024Challenge.Backend.Modules.Players.Domain.Repositories;
using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Players.Get;

public class GetPlayerQueryHandler : IRequestHandler<GetPlayerQuery, PlayerDto>
{
    private readonly IPlayersRepository _playersRepository;

    public GetPlayerQueryHandler(IPlayersRepository playersRepository)
    {
        _playersRepository = playersRepository;
    }

    public async Task<PlayerDto> Handle(GetPlayerQuery request, CancellationToken cancellationToken)
    {
        return (await _playersRepository.Get(request.PlayerId)).ToPlayerDto();
    }
}