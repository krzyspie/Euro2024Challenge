using Euro2024Challenge.Backend.Modules.Players.Domain.Repositories;
using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Create
{
    public class CreateMatchBetCommandHandler : IRequestHandler<CreateMatchBetCommand, Unit>
    {
        private readonly IPlayersBetsRepository _playersBetsRepository;

        public CreateMatchBetCommandHandler(IPlayersBetsRepository playersBetsRepository)
        {
            _playersBetsRepository = playersBetsRepository;
        }

        public Task<Unit> Handle(CreateMatchBetCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}