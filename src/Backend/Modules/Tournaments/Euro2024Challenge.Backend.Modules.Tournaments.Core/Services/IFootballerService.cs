using Euro2024Challenge.Backend.Modules.Tournament.Shared.DTO;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Services;

public interface IFootballerService
{
    Task UpdateGoals(int id, int goals);
    Task<FootballerResponse> Get(int id);
}