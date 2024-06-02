using Euro2024Challenge.Backend.Modules.Players.Domain.Entities;
using Euro2024Challenge.Backend.Modules.Players.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Euro2024Challenge.Backend.Modules.Players.Infrastructure.Database.Repositories
{
    internal class PlayersBetsRepository : IPlayersBetsRepository
    {
        private readonly PlayersDbContext _context;
        private readonly DbSet<MatchBet> _matchBets;
        private readonly DbSet<TopScorerBet> _topScorerBets;
        private readonly DbSet<TournamentWinnerBet> _tournamentWinnerBets;

        public PlayersBetsRepository(PlayersDbContext context)
        {
            _context = context;
            _matchBets = _context.MatchBets;
            _topScorerBets = _context.TopScorerBets;
            _tournamentWinnerBets = _context.TournamentWinnerBets;
        }
        
        public async Task CreateMatchBetAsync(MatchBet matchBet)
        {
            await _matchBets.AddAsync(matchBet);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateMatchBetAsync(MatchBet matchBet)
        {
            _matchBets.Update(matchBet);
            await _context.SaveChangesAsync();
        }

        public async Task CreateTopScorerBetAsync(TopScorerBet topScorerBet)
        {
            await _topScorerBets.AddAsync(topScorerBet);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTopScorerBetAsync(TopScorerBet topScorerBet)
        {
            _topScorerBets.Update(topScorerBet);
            await _context.SaveChangesAsync();
        }

        public async Task CreateTournamentWinnerBetAsync(TournamentWinnerBet tournamentWinnerBet)
        {
            await _tournamentWinnerBets.AddAsync(tournamentWinnerBet);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTournamentWinnerBetAsync(TournamentWinnerBet tournamentWinnerBet)
        {
            _tournamentWinnerBets.Update(tournamentWinnerBet);
            await _context.SaveChangesAsync();
        }
    }
}
