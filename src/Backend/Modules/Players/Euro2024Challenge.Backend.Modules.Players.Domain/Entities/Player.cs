namespace Euro2024Challenge.Backend.Modules.Players.Domain.Entities
{
    public sealed class Player : BaseEntity
    {
        public required string Email { get; set; }
        public required string Username { get; set; }
    }
}
