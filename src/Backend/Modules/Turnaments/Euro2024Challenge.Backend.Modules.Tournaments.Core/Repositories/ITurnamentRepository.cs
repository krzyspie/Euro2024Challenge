using Euro2024Challenge.Backend.Modules.Turnaments.Core;

internal interface ITurnamentRepository
{
    Task AddMatch(Match match);
    Task UpdateMatch();
    Task GetMatch();
    Task UpdatePlayer();
    Task GetPlayer();
}