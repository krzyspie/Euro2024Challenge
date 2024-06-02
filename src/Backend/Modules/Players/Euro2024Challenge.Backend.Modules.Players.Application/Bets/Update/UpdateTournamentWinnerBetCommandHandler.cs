using Euro2024Challenge.Backend.Modules.Players.Domain.Entities;
using Euro2024Challenge.Backend.Modules.Players.Domain.Repositories;
using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Update
{
    public class UpdateTournamentWinnerBetCommandHandler : IRequestHandler<UpdateTournamentWinnerBetCommand, Unit>
    {
        private readonly IPlayersBetsRepository _playersBetsRepository;

        public UpdateTournamentWinnerBetCommandHandler(IPlayersBetsRepository playersBetsRepository)
        {
            _playersBetsRepository = playersBetsRepository;
        }

        public async Task<Unit> Handle(UpdateTournamentWinnerBetCommand request, CancellationToken cancellationToken)
        {
            var bet = new TournamentWinnerBet
            {
                TeamId = request.TeamId,
                PlayerId = request.PLayerId
            };

            await _playersBetsRepository.UpdateTournamentWinnerBetAsync(bet);
            
            return Unit.Value;
        }
    }
}
