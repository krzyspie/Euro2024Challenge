using Euro2024Challenge.Shared.Domain;

namespace Euro2024Challenge.Backend.Modules.Classification.Domain.Entities;

public class PlayerPoints : BaseEntity
{
    public Guid PlayerId { get; set; }
    
    public Guid BetId { get; set; }
    
    public int Points { get; set; }
}