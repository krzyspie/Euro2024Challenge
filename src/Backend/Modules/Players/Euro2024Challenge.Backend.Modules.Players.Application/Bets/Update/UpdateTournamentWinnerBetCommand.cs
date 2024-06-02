using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Update
{
    public sealed record UpdateTournamentWinnerBetCommand(Guid PLayerId, int TeamId) : IRequest<Unit>;
}
