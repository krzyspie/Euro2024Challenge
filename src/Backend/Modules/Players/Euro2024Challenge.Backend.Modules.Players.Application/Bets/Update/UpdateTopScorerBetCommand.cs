using Euro2024Challenge.Backend.Modules.Players.Domain.Enums;
using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Update
{
    public sealed record UpdateTopScorerBetCommand(Guid PLayerId, int FootballerId, int Goals) : IRequest<Unit>;
}
