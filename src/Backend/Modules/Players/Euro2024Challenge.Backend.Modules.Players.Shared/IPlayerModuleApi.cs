namespace Euro2024Challenge.Backend.Modules.Players.Shared
{
    public interface IPlayerModuleApi
    {
        Task GetPlayersUsernames(IEnumerable<Guid> playersId);
    }
}