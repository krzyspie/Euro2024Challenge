using Euro2024Challenge.Backend.Modules.Players.Domain.Entities;
using Euro2024Challenge.Backend.Modules.Players.Domain.Repositories;
using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Update
{
    public class UpdateTopScorerCommandHandler : IRequestHandler<UpdateTopScorerBetCommand, Unit>
    {
        private readonly IPlayersBetsRepository _playersBetsRepository;

        public UpdateTopScorerCommandHandler(IPlayersBetsRepository playersBetsRepository)
        {
            _playersBetsRepository = playersBetsRepository;
        }

        public async Task<Unit> Handle(UpdateTopScorerBetCommand request, CancellationToken cancellationToken)
        {
            var bet = new TopScorerBet
            {
                PlayerId = request.PLayerId,
                Goals = request.Goals,
                FootballerId = request.FootballerId
            };
            
            await _playersBetsRepository.UpdateTopScorerBetAsync(bet);

            return Unit.Value;
        }
    }
}