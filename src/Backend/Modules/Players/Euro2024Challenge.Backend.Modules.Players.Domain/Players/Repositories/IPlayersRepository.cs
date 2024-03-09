namespace Euro2024Challenge.Backend.Modules.Players.Domain.Players.Repositories
{
    public interface IPlayersRepository
    {
        Task Create(string email, string userName);
    }
}
