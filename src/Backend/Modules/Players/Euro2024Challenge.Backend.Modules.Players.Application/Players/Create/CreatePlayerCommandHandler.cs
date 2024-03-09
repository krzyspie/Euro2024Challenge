using Euro2024Challenge.Backend.Modules.Players.Application.Players.Commands;
using Euro2024Challenge.Backend.Modules.Players.Domain.Players.Repositories;
using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Players.Create
{
    internal sealed class CreatePlayerCommandHandler : IRequestHandler<CreatePlayerCommand, Unit>
    {
        private readonly IPlayersRepository _playersRepository;
        public CreatePlayerCommandHandler(IPlayersRepository playersRepository)
        {
            _playersRepository = playersRepository;
        }

        public async Task<Unit> Handle(CreatePlayerCommand request, CancellationToken cancellationToken)
        {
            await _playersRepository.Create(request.Email, request.Username);

            return Unit.Value;
        }
    }
}
