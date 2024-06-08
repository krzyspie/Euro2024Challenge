using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Repositories;

public interface IMatchRepository
{
    Task AddAsync(Match? match);
    Task UpdateAsync(Match? match);
    Task<IEnumerable<Match>> GetAll();
    Task<Match> GetByNumber(int number);
    Task<IReadOnlyCollection<Match>> GetByNumbers(int[] numbers);
}