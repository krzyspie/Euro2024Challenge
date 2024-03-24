using Euro2024Challenge.Backend.Modules.Players.Application.Players.Commands;
using Euro2024Challenge.Backend.Modules.Players.Domain.Repositories;
using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Players.Create
{
    internal sealed class GetPlayerBetsCommandHandler(IPlayersRepository playersRepository) : IRequestHandler<GetPlayerBetsCommand, Unit>
    {
        private readonly IPlayersRepository _playersRepository = playersRepository;

        public async Task<Unit> Handle(GetPlayerBetsCommand request, CancellationToken cancellationToken)
        {
            return Unit.Value;
        }
    }
}
