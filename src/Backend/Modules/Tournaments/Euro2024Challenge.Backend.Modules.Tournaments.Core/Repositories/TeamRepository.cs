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

    public async Task<Team> GetTeamAsync(int id)
    {
        return await _teams.SingleAsync(x => x.Id == id);
    }

    public async Task<IDictionary<int, string>> GetTeamsAsync(IEnumerable<int> ids)
    {
        return await _teams.Where(x => ids.Contains(x.Id))
                        .ToDictionaryAsync<Team, int, string>(key => key.Id, v => v.Name);
    }

    public async Task<IDictionary<int, string>> GetAllTeamsAsync()
    {
        return await _teams.ToDictionaryAsync<Team, int, string>(key => key.Id, v => v.Name);
    }
}