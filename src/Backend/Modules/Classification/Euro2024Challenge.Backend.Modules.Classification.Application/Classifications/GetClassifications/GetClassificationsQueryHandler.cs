using Euro2024Challenge.Backend.Modules.Classification.Application.Extensions;
using Euro2024Challenge.Backend.Modules.Classification.Domain.Entities;
using Euro2024Challenge.Backend.Modules.Classification.Domain.Repositories;
using MediatR;

namespace Euro2024Challenge.Backend.Modules.Classification.Application.Classifications.GetClassifications;

public class GetClassificationsQueryHandler : IRequestHandler<GetClassificationsQuery, IReadOnlyCollection<GetClassificationsResponse>>
{
    private readonly IClassificationRepository _classificationRepository;

    public GetClassificationsQueryHandler(IClassificationRepository classificationRepository)
    {
        _classificationRepository = classificationRepository;
    }

    public async Task<IReadOnlyCollection<GetClassificationsResponse>> Handle(GetClassificationsQuery request, CancellationToken cancellationToken)
    {
        IReadOnlyCollection<PlayerBetPoints> betsPoints = await _classificationRepository.GetAll();

        return betsPoints.ToGetClassificationsResponse().AsReadOnly();
    }
}