using Euro2024Challenge.Backend.Modules.Classification.Domain.Entities;

namespace Euro2024Challenge.Backend.Modules.Classification.Application;

public class GetPlayerClassificationResponse
{
    public Guid PlayerId { get; set; }

    public IReadOnlyCollection<PlayerPoints> BetsPoints { get; set; }
}
