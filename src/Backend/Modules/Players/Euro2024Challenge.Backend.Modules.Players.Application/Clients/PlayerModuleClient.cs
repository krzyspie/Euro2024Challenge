
using Euro2024Challenge.Backend.Modules.Players.Shared;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Clients
{
    public class PlayerModuleClient : IPlayerModuleApi
    {
        public Task<IDictionary<Guid, string>> GetPlayersUsernames(IEnumerable<Guid> playersId)
        {
            throw new NotImplementedException();
        }
    }
}