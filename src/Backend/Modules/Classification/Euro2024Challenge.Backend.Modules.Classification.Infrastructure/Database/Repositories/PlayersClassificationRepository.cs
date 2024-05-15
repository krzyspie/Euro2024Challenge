using Euro2024Challenge.Backend.Modules.Classification.Domain.Entities;
using Euro2024Challenge.Backend.Modules.Classification.Domain.Repositories;
using Euro2024Challenge.Backend.Modules.Classification.Infrastructure.Database.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Euro2024Challenge.Backend.Modules.Classification.Infrastructure.Database.Repositories;

public class PlayersClassificationRepository : IClassificationRepository
{
    private readonly IMongoCollection<PlayerPoints> _playersClassificationCollection;

    public PlayersClassificationRepository(IOptions<ClassificationDatabaseSettings> options)
    {
        var mongoClient = new MongoClient(options.Value.ConnectionString);
        var mongoDatabase = mongoClient.GetDatabase(options.Value.DatabaseName);
        _playersClassificationCollection = mongoDatabase.GetCollection<PlayerPoints>(options.Value.CollectionName);
    }
    public Task<IEnumerable<PlayersPoints>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task Insert(PlayerPoints points)
    {
        throw new NotImplementedException();
    }

    public Task<PlayerPoints> Get(Guid playerId)
    {
        throw new NotImplementedException();
    }
}