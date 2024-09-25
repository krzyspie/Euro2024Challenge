using Euro2024Challenge.Shared;

namespace Euro2024Challenge.Backend.Modules.Players.Shared.Events;

public record class PlayerBetClaculated(Guid PlayerId, Guid BetId, int Points) : IEvent;