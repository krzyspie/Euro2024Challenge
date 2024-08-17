using Euro2024Challenge.Backend.Modules.Classification.Application.Extensions;
using Euro2024Challenge.Backend.Modules.Classification.Domain.Entities;
using Euro2024Challenge.Backend.Modules.Classification.Domain.Repositories;
using Euro2024Challenge.Backend.Modules.Players.Shared;
using MediatR;

namespace Euro2024Challenge.Backend.Modules.Classification.Application.Classifications.GetClassifications;

public class GetClassificationsQueryHandler : IRequestHandler<GetClassificationsQuery, IReadOnlyCollection<GetClassificationsResponse>>
{
    private readonly IClassificationRepository _classificationRepository;
    private readonly IPlayerModuleApi _playerModuleApi;

    public GetClassificationsQueryHandler(IClassificationRepository classificationRepository, IPlayerModuleApi playerModuleApi)
    {
        _classificationRepository = classificationRepository;
        _playerModuleApi = playerModuleApi;
    }

    public async Task<IReadOnlyCollection<GetClassificationsResponse>> Handle(GetClassificationsQuery request, CancellationToken cancellationToken)
    {
        IReadOnlyCollection<PlayerBetPoints> betsPoints = await _classificationRepository.GetAll();

        var playersUsernames = await _playerModuleApi.GetPlayersUsernames(betsPoints.Select(x => Guid.Parse(x.PlayerId)));

        return betsPoints.ToGetClassificationsResponse().AsReadOnly();
    }
}