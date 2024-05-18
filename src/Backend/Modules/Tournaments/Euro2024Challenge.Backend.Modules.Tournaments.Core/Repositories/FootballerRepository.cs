using Euro2024Challenge.Backend.Modules.Tournaments.Core.Database;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Repositories;

public class FootballerRepository : IFootballerRepository
{
    private readonly TournamentDbContext _tournamentDbContext;
    private DbSet<Footballer> _footballers;

    public FootballerRepository(TournamentDbContext tournamentDbContext)
    {
        _tournamentDbContext = tournamentDbContext;
        _footballers = tournamentDbContext.Footballers;
    }

    public async Task UpdateAsync(Footballer footballer)
    {
        _footballers.Update(footballer);
        await _tournamentDbContext.SaveChangesAsync();
    }

    public async Task<Footballer> Get(int id)
    {
        return await _footballers.SingleAsync(x => x.Id == id);
    }
    
}