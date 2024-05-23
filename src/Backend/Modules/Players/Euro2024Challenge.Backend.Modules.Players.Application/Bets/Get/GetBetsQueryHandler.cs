using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Get;

public class GetBetsQueryHandler : IRequestHandler<GetBetsQuery, Unit>
{
    public Task<Unit> Handle(GetBetsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}