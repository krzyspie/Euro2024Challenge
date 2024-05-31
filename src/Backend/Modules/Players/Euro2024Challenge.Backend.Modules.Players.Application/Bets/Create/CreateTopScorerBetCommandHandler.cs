using Euro2024Challenge.Backend.Modules.Players.Domain.Entities;
using Euro2024Challenge.Backend.Modules.Players.Domain.Repositories;
using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Create
{
    public class CreateTopScorerBetCommandHandler : IRequestHandler<CreateTopScorerBetCommand, Unit>
    {
        private readonly IPlayersBetsRepository _playersBetsRepository;

        public CreateTopScorerBetCommandHandler(IPlayersBetsRepository playersBetsRepository)
        {
            _playersBetsRepository = playersBetsRepository;
        }

        public async Task<Unit> Handle(CreateTopScorerBetCommand request, CancellationToken cancellationToken)
        {
            var bet = new TopScorerBet()
            {
                PlayerId = request.PlayerId,
                FootballerId = request.FootballerId,
                Goals = request.Goals
            };
            
            await _playersBetsRepository.CreateTopScorerBetAsync(bet);
            
            return Unit.Value;
        }
    }
}
