using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Create
{
    public sealed record CreateTopScorerBetCommand(Guid PlayerId, int FootballerId, int Goals) : IRequest<Unit>;
}
