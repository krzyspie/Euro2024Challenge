using Euro2024Challenge.Backend.Modules.Players.Domain.Entities;
using Euro2024Challenge.Backend.Modules.Players.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Euro2024Challenge.Backend.Modules.Players.Infrastructure.Database.Repositories
{
    internal class PlayersRepository : IPlayersRepository
    {
        private readonly PlayersDbContext _context;
        private readonly DbSet<Player> _players;

        public PlayersRepository(PlayersDbContext context)
        {
            _context = context;
            _players = _context.Players;
        }

        public async Task Create(Player player)
        {
            await _players.AddAsync(player);
            await _context.SaveChangesAsync();
        }

        public Task<Player> Get(Guid playerId)
        {
            return _players.SingleAsync(p => p.Id == playerId);
        }

        public Task<List<Player>> GetPlayers(List<Guid> playersIds)
        {
            return _players.Where(p => playersIds.Contains(p.Id)).ToListAsync();
        }

        public async Task<IEnumerable<Player>> GetAllPlayersMatchBets()
        {
            return await _players
                .Include(m => m.MatchBets).ToListAsync();
        }

        public Task<Player> GetWithBets(Guid playerId)
        {
            return _players
                .Include(m => m.MatchBets)
                .Include(w => w.TournamentWinnerBet)
                .Include(s => s.TopScorerBet)
                .SingleAsync(p => p.Id == playerId);
        }

        public Task<List<Player>> GetAllPlayers()
        {
            return _players.ToListAsync();
        }
    }
}
