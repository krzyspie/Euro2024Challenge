namespace Euro2024Challenge.Shared.Database;

public interface IUnitOfWork
{
    Task SaveChangesAsync(CancellationToken cancellationToken = default);
}