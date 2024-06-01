using Euro2024Challenge.Backend.Modules.Players.Domain.Entities;
using Euro2024Challenge.Backend.Modules.Players.Domain.Repositories;
using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Create
{
    public class CreateTournamentWinnerBetCommandHandler : IRequestHandler<CreateTournamentWinnerBetCommand, Unit>
    {
        private readonly IPlayersBetsRepository _playersBetsRepository;

        public CreateTournamentWinnerBetCommandHandler(IPlayersBetsRepository playersBetsRepository)
        {
            _playersBetsRepository = playersBetsRepository;
        }

        public async Task<Unit> Handle(CreateTournamentWinnerBetCommand request, CancellationToken cancellationToken)
        {
            var bet = new TournamentWinnerBet()
            {
                TeamId = request.TeamId,
                PlayerId = request.PLayerId
            };

            await _playersBetsRepository.CreateTournamentWinnerBetAsync(bet);
            
            return Unit.Value;
        }
    }
}
