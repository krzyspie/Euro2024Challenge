using Euro2024Challenge.Backend.Modules.Players.Domain.Entities;
using Euro2024Challenge.Backend.Modules.Players.Domain.Repositories;
using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Players.Create
{
    internal sealed class CreatePlayerCommandHandler(IPlayersRepository playersRepository) : IRequestHandler<CreatePlayerCommand, Unit>
    {
        private readonly IPlayersRepository _playersRepository = playersRepository;

        public async Task<Unit> Handle(CreatePlayerCommand request, CancellationToken cancellationToken)
        {
            Player player = new()
            {
                Email = request.Email,
                Username = request.Username,
            };

            await _playersRepository.Create(player);

            return Unit.Value;
        }
    }
}
