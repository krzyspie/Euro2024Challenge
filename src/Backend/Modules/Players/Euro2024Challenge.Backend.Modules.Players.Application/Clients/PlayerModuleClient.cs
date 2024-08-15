
using Euro2024Challenge.Backend.Modules.Players.Domain.Repositories;
using Euro2024Challenge.Backend.Modules.Players.Shared;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Clients
{
    public class PlayerModuleClient : IPlayerModuleApi
    {
        private readonly IPlayersRepository _playersRepository;

        public PlayerModuleClient(IPlayersRepository playersRepository)
        {
            _playersRepository = playersRepository;
        }

        public async Task<IDictionary<Guid, string>> GetPlayersUsernames(IEnumerable<Guid> playersIds)
        {
            await _playersRepository.GetPlayers(playersIds.ToList());

            return null;
        }
    }
}