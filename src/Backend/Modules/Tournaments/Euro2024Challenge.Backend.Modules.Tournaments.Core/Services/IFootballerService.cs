using Euro2024Challenge.Backend.Modules.Tournaments.Core.DTO;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Services;

public interface IFootballerService
{
    Task UpdateGoals(int id, int goals);
    Task<FootballerResponse> Get(int id);
}