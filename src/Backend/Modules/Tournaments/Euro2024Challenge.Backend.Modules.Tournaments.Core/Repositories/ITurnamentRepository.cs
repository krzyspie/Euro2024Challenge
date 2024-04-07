using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Repositories;

internal interface ITurnamentRepository
{
    Task AddMatch(Match match);
    Task UpdateMatch();
    Task GetMatch();
    Task UpdatePlayer();
    Task GetPlayer();
}