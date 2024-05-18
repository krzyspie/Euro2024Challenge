using Euro2024Challenge.Backend.Modules.Tournaments.Core.Database;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Repositories;

public class MatchRepository : IMatchRepository
{
    private readonly TournamentDbContext _tournamentDbContext;
    private readonly DbSet<Match> _matches;

    public MatchRepository(TournamentDbContext tournamentDbContext)
    {
        _tournamentDbContext = tournamentDbContext;
        _matches = tournamentDbContext.Matches;
    }
    
    public async Task AddAsync(Match match)
    {
        await _matches.AddAsync(match);
        await _tournamentDbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(Match? match)
    {
        _matches.Update(match);
        await _tournamentDbContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<Match>> GetAll()
    {
        return await _matches.ToListAsync();
    }

    public async Task<Match?> GetByNumber(int number)
    {
        return await _matches.SingleOrDefaultAsync(x => x.Number == number);
    }
}