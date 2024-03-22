using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Create
{
    public class CreateTurnamentWinnerBetCommandHandler : IRequestHandler<CreateTurnamentWinnerBetCommand, Unit>
    {
        public Task<Unit> Handle(CreateTurnamentWinnerBetCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
