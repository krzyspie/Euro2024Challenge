using Euro2024Challenge.Backend.Modules.Players.Domain.Entities;

namespace Euro2024Challenge.Backend.Modules.Players.Domain.Repositories
{
    public interface IPlayersRepository
    {
        Task Create(Player player);

        Task<Player> Get(Guid playerId);
        Task<List<Player>> GetPlayers(List<Guid> playersIds);
        Task<Player> GetWithBets(Guid playerId);
        Task<IEnumerable<Player>> GetAllPlayersMatchBets();
    }
}
