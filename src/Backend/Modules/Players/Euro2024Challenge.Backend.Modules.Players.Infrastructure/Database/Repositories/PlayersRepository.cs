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

        public Task Create(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
