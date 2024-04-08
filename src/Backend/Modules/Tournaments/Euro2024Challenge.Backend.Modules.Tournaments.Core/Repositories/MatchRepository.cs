using Euro2024Challenge.Backend.Modules.Tournaments.Core.Database;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Repositories;

public class MatchRepository : IMatchRepository
{
    private readonly TournamentDbContext _tournamentDbContext;

    public MatchRepository(TournamentDbContext tournamentDbContext)
    {
        _tournamentDbContext = tournamentDbContext;
    }
    
    public Task Add(Match match)
    {
        throw new NotImplementedException();
    }

    public Task UpdateResult(int guestTeamGoals, int awayTeamGoals)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Match>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Match> GetByNumber(int number)
    {
        throw new NotImplementedException();
    }
}