using Euro2024Challenge.Backend.Modules.Classification.Application.Extensions;
using Euro2024Challenge.Backend.Modules.Classification.Domain.Repositories;
using MediatR;

namespace Euro2024Challenge.Backend.Modules.Classification.Application.Classifications.GetPlayerClassifications;

public class GetPlayerClassificationsQueryHandler : IRequestHandler<GetPlayerClassificationsQuery, GetPlayerClassificationsResponse>
{
    private readonly IClassificationRepository _classificationRepository;

    public GetPlayerClassificationsQueryHandler(IClassificationRepository classificationRepository)
    {
        _classificationRepository = classificationRepository;
    }

    public async Task<GetPlayerClassificationsResponse> Handle(GetPlayerClassificationsQuery request, CancellationToken cancellationToken)
    {
        IReadOnlyCollection<Domain.Entities.BetPoints> betsPoints = await _classificationRepository.Get(request.PlayerId);

        return betsPoints.ToGetPlayerClassificationsResponse(request.PlayerId);
    }
}