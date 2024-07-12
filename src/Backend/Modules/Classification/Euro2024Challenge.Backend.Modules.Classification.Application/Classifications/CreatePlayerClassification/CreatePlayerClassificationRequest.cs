namespace Euro2024Challenge.Backend.Modules.Classification.Application.Classifications.CreatePlayerClassification;

public sealed record CreatePlayerClassificationRequest(Guid PlayerId, Guid BetId, int Points);
