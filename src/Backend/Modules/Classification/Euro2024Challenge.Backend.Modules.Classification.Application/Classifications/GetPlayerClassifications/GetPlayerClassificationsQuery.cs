using MediatR;

namespace Euro2024Challenge.Backend.Modules.Classification.Application.Classifications.GetPlayerClassifications;

public sealed record GetPlayerClassificationsQuery(Guid PlayerId) : IRequest<GetPlayerClassificationsResponse>;
