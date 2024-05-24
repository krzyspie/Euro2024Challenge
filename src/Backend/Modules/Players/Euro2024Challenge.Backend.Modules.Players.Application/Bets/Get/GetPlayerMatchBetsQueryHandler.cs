using Euro2024Challenge.Backend.Modules.Players.Domain.Repositories;
using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Get
{
    internal sealed class GetPlayerMatchBetsQueryHandler(IPlayersRepository playersRepository) : IRequestHandler<GetPlayerMatchBetsQuery, Unit>
    {
        private readonly IPlayersRepository _playersRepository = playersRepository;

        public async Task<Unit> Handle(GetPlayerMatchBetsQuery request, CancellationToken cancellationToken)
        {
            return Unit.Value;
        }
    }
}
