namespace Euro2024Challenge.Backend.Modules.Classification.Application;

public sealed record CreatePlayerClassificationRequest(Guid PlayerId, Guid BetId, int Points);
