using Euro2024Challenge.Backend.Modules.Tournaments.Core.Database;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Repositories;

public class TeamRepository : ITeamRepository
{
    private readonly DbSet<Team> _teams;

    public TeamRepository(TournamentDbContext tournamentDbContext)
    {
        _teams = tournamentDbContext.Teams;
    }
    
    public async Task<IEnumerable<Team>> GetTeamsAsync(List<int> ids)
    {
        return await _teams.Where(x => ids.Contains(x.Id)).ToListAsync();
    }
}