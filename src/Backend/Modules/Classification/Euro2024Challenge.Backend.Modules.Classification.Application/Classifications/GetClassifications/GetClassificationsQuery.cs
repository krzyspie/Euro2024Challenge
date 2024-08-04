using MediatR;

namespace Euro2024Challenge.Backend.Modules.Classification.Application.Classifications.GetClassifications;

public sealed record GetClassificationsQuery(Guid PlayerId) : IRequest<GetClassificationsResponse>;
