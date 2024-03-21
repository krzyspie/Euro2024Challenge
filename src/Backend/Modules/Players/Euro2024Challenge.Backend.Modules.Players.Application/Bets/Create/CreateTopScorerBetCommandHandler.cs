using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Create
{
    public class CreateTopScorerBetCommandHandler : IRequestHandler<CreateTopScorerBetCommand, Unit>
    {
        public Task<Unit> Handle(CreateTopScorerBetCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
