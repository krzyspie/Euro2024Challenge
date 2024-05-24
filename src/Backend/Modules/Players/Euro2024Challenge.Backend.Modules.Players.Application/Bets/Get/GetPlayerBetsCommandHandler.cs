using Euro2024Challenge.Backend.Modules.Players.Application.Bets.DTO;
using Euro2024Challenge.Backend.Modules.Players.Domain.Repositories;
using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Get
{
    internal sealed class GetPlayerBetsCommandHandler(IPlayersRepository playersRepository) : IRequestHandler<GetPlayerBetsCommand, PlayerBetsDto>
    {
        private readonly IPlayersRepository _playersRepository = playersRepository;

        public async Task<PlayerBetsDto> Handle(GetPlayerBetsCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new PlayerBetsDto());
        }
    }
}
