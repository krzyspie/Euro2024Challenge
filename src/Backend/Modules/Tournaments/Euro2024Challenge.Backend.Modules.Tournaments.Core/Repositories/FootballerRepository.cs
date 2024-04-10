using Euro2024Challenge.Backend.Modules.Tournaments.Core.Database;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Repositories;

public class FootballerRepository : IFootballerRepository
{
    private readonly TournamentDbContext _tournamentDbContext;

    public FootballerRepository(TournamentDbContext tournamentDbContext)
    {
        _tournamentDbContext = tournamentDbContext;
    }

    public Task Add(Footballer footballer)
    {
        throw new NotImplementedException();
    }

    public Task UpdateGoals(int id, int goals)
    {
        throw new NotImplementedException();
    }

    public Task<Footballer> Get(int id)
    {
        throw new NotImplementedException();
    }
    
}