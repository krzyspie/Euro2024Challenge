using Euro2024Challenge.Backend.Modules.Classification.Domain.Entities;

namespace Euro2024Challenge.Backend.Modules.Classification.Application;

public class GetPlayerClassificationsResponse
{
    public Guid PlayerId { get; set; }

    public IReadOnlyCollection<BetPointsDto> BetsPoints { get; set; }
}
