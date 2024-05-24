using Euro2024Challenge.Backend.Modules.Players.Domain.Repositories;
using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Get
{
    internal sealed class GetPlayerMatchBetsCommandHandler(IPlayersRepository playersRepository) : IRequestHandler<GetPlayerMatchBetsCommand, Unit>
    {
        private readonly IPlayersRepository _playersRepository = playersRepository;

        public async Task<Unit> Handle(GetPlayerMatchBetsCommand request, CancellationToken cancellationToken)
        {
            return Unit.Value;
        }
    }
}
