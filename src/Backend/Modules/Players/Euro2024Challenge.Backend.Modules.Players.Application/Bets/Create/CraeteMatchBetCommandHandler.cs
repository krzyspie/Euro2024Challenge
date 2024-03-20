using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Create
{
    public class CraeteMatchBetCommandHandler : IRequestHandler<CraeteMatchBetCommand, Unit>
    {
        public Task<Unit> Handle(CraeteMatchBetCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
