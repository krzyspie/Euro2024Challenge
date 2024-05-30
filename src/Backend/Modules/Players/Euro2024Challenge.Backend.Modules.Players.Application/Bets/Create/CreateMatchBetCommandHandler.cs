using Euro2024Challenge.Backend.Modules.Players.Domain.Entities;
using Euro2024Challenge.Backend.Modules.Players.Domain.Repositories;
using Euro2024Challenge.Backend.Modules.Players.Domain.ValueObjects;
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

        public async Task<Unit> Handle(CreateMatchBetCommand request, CancellationToken cancellationToken)
        {
            var bet = new MatchBet
            {
                Id = new Guid(),
                MatchId = request.MatchId,
                Result = MatchResult.CreateNew((ushort)request.HomeTeamGoals, (ushort)request.AwayTeamGoals),
                PlayerId = request.PLayerId,
                CreatedAt = DateTime.Now,
                Winner = request.Winner
            };
            
            await _playersBetsRepository.CreateMatchBetAsync(bet);
            
            return Unit.Value;
        }
    }
}