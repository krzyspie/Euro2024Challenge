using Euro2024Challenge.Backend.Modules.Tournaments.Core.Database;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Repositories;

public class TeamRepository : ITeamRepository
{
    private readonly TournamentDbContext _tournamentDbContext;
    private readonly DbSet<Team> _teams;

    public TeamRepository(TournamentDbContext tournamentDbContext)
    {
        _tournamentDbContext = tournamentDbContext;
        _teams = tournamentDbContext.Teams;
    }

    public async Task<Team> GetAsync(int id)
    {
        return await _teams.SingleOrDefaultAsync(x => x.Id == id);
    }
}