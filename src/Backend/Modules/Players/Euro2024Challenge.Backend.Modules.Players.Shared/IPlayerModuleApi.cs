namespace Euro2024Challenge.Backend.Modules.Players.Shared
{
    public interface IPlayerModuleApi
    {
        Task<IDictionary<Guid, string>> GetPlayersUsernames(IEnumerable<Guid> playersId);
    }
}