using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Repositories;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Services;

public class FootballerService : IFootballerService
{
    private readonly IFootballerRepository _footballerRepository;

    public FootballerService(IFootballerRepository footballerRepository)
    {
        _footballerRepository = footballerRepository;
    }

    public async Task Add(Footballer footballer)
    {
        await _footballerRepository.Add(footballer);
    }

    public async Task UpdateGoals(int id, int goals)
    {
        await _footballerRepository.UpdateGoals(id, goals);
    }

    public async Task<Footballer> Get(int id)
    {
        return await _footballerRepository.Get(id);
    }
}