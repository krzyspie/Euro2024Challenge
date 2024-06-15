using MediatR;

namespace Euro2024Challenge.Backend.Modules.Classification.Application;

public sealed record GetPlayerClassificationsQuery(Guid PlayerId) : IRequest<GetPlayerClassificationsResponse>;
