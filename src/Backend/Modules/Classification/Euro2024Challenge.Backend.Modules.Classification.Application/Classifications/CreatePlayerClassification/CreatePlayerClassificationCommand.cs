using MediatR;

namespace Euro2024Challenge.Backend.Modules.Classification.Application.Classifications.CreatePlayerClassification;

public sealed record CreatePlayerClassificationCommand(Guid PlayerId, Guid BetId, int Points) : IRequest<Unit>;