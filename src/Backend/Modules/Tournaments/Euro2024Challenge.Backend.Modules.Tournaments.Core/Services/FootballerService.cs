using Euro2024Challenge.Backend.Modules.Tournament.Shared.DTO;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Extensions;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Repositories;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Services;

public class FootballerService : IFootballerService
{
    private readonly IFootballerRepository _footballerRepository;

    public FootballerService(IFootballerRepository footballerRepository)
    {
        _footballerRepository = footballerRepository;
    }

    public async Task UpdateGoals(int id, int goals)
    {
        Footballer footballer = await _footballerRepository.Get(id);
        footballer.Goals = goals;
        
        await _footballerRepository.UpdateAsync(footballer);
    }

    public async Task<FootballerResponse> Get(int id)
    {
        var footballer =  await _footballerRepository.Get(id);
        return footballer.ToFootballerResponse();
    }
}