using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Create
{
    public class CreateMatchBetCommandHandler : IRequestHandler<CreateMatchBetCommand, Unit>
    {
        public Task<Unit> Handle(CreateMatchBetCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
