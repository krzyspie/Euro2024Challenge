using Euro2024Challenge.Backend.Modules.Classification.Domain.Entities;

namespace Euro2024Challenge.Backend.Modules.Classification.Application;

public class GetPlayerClassificationsResponse
{
    public Guid PlayerId { get; set; }

    public IReadOnlyCollection<BetPoints> BetsPoints { get; set; }
}
