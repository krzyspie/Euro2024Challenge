using Euro2024Challenge.Backend.Modules.Players.Application.Bets.DTO;
using Euro2024Challenge.Backend.Modules.Players.Domain.Repositories;
using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Get
{
    internal sealed class GetPlayerBetsQueryHandler(IPlayersRepository playersRepository) : IRequestHandler<GetPlayerBetsQuery, PlayerBetsDto>
    {
        private readonly IPlayersRepository _playersRepository = playersRepository;

        public async Task<PlayerBetsDto> Handle(GetPlayerBetsQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new PlayerBetsDto());
        }
    }
}
