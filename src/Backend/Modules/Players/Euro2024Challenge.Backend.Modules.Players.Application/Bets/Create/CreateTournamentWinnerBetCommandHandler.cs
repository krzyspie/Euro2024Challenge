using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Create
{
    public class CreateTournamentWinnerBetCommandHandler : IRequestHandler<CreateTournamentWinnerBetCommand, Unit>
    {
        public Task<Unit> Handle(CreateTournamentWinnerBetCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
