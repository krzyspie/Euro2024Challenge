using Euro2024Challenge.Shared;

namespace Euro2024Challenge.Backend.Modules.Players.Shared.Events;

public record class PlayersMatchBetsClaculated(Guid PlayerId, int MatchId, int Points) : IEvent;