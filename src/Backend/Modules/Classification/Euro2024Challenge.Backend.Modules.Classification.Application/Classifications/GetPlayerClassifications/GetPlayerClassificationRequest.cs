using MediatR;

namespace Euro2024Challenge.Backend.Modules.Classification.Application;

public sealed record GetPlayerClassificationRequest(Guid PlayerId) : IRequest<GetPlayerClassificationResponse>;
