using MediatR;

namespace Euro2024Challenge.Backend.Modules.Classification.Application;

public sealed record CreatePlayerClassificationCommand(Guid PlayerId, Guid BetId, int Points) : IRequest<Unit>;