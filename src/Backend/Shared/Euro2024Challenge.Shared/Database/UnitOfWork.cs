using Microsoft.EntityFrameworkCore;

namespace Euro2024Challenge.Shared.Database;

public sealed class UnitOfWork(DbContext dbContext) : IUnitOfWork
{
    public Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return dbContext.SaveChangesAsync(cancellationToken);
    }
}