using Euro2024Challenge.Backend.Modules.Players.Domain.Entities;
using Euro2024Challenge.Backend.Modules.Players.Domain.Repositories;
using Euro2024Challenge.Backend.Modules.Players.Domain.ValueObjects;
using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Update
{
    public class UpdateMatchBetCommandHandler : IRequestHandler<UpdateMatchBetCommand, Unit>
    {
        private readonly IPlayersBetsRepository _playersBetsRepository;

        public UpdateMatchBetCommandHandler(IPlayersBetsRepository playersBetsRepository)
        {
            _playersBetsRepository = playersBetsRepository;
        }

        public async Task<Unit> Handle(UpdateMatchBetCommand request, CancellationToken cancellationToken)
        {
            var bet = new MatchBet
            {
                MatchId = request.MatchId,
                Result = MatchResult.CreateNew((ushort)request.HomeTeamGoals, (ushort)request.AwayTeamGoals),
                PlayerId = request.PLayerId,
                Winner = request.Winner
            };
            
            await _playersBetsRepository.UpdateMatchBetAsync(bet);

            return Unit.Value;
        }
    }
}