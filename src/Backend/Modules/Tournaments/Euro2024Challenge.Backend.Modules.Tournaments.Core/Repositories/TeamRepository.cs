using Euro2024Challenge.Backend.Modules.Tournaments.Core.Database;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Repositories;

public class TeamRepository : ITeamRepository
{
    private readonly TournamentDbContext _tournamentDbContext;

    public TeamRepository(TournamentDbContext tournamentDbContext)
    {
        _tournamentDbContext = tournamentDbContext;
    }

    public Task Add(Team team)
    {
        throw new NotImplementedException();
    }

    public Task<Team> Get(int id)
    {
        throw new NotImplementedException();
    }
}