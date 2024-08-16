
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
            List<Domain.Entities.Player> players = await _playersRepository.GetPlayers(playersIds.ToList());

            Dictionary<Guid, string> result = [];

            foreach (var item in playersIds)
            {
                Domain.Entities.Player? player = players.FirstOrDefault(x => x.Id == item && !string.IsNullOrWhiteSpace(x.Username));
                result.Add(item, player is null ? string.Empty : player.Username);
            }

            return result;
        }
    }
}