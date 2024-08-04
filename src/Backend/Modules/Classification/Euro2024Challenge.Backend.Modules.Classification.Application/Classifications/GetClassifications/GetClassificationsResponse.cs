using Euro2024Challenge.Backend.Modules.Classification.Application.Dto;

namespace Euro2024Challenge.Backend.Modules.Classification.Application.Classifications.GetClassifications;

public class GetClassificationsResponse
{
    public Guid PlayerId { get; set; }

    public IReadOnlyCollection<BetPointsDto> BetsPoints { get; set; }
}
