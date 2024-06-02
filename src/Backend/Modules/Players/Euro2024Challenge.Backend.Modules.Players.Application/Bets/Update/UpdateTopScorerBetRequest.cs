using Euro2024Challenge.Backend.Modules.Players.Domain.Enums;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Update
{
    public sealed record UpdateTopScorerBetRequest(Guid PlayerId,  int FootballerId, int Goals);
}
