using Euro2024Challenge.Backend.Modules.Players.Application.Bets.DTO;
using Euro2024Challenge.Backend.Modules.Players.Application.Extensions;
using Euro2024Challenge.Backend.Modules.Players.Domain.Repositories;
using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Get
{
    internal sealed class GetPlayerBetsQueryHandler(IPlayersRepository playersRepository) : IRequestHandler<GetPlayerBetsQuery, PlayerBetsDto>
    {
        private readonly IPlayersRepository _playersRepository = playersRepository;

        public async Task<PlayerBetsDto> Handle(GetPlayerBetsQuery request, CancellationToken cancellationToken)
        {
            var result = await _playersRepository.GetWithBets(request.PlayerId);
            
            return result.ToPlayerBetsDto();
        }
    }
}
