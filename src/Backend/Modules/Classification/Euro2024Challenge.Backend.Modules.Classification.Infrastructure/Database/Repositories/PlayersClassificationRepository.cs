using Euro2024Challenge.Backend.Modules.Classification.Domain.Entities;
using Euro2024Challenge.Backend.Modules.Classification.Domain.Repositories;
using Euro2024Challenge.Backend.Modules.Classification.Infrastructure.Database.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Euro2024Challenge.Backend.Modules.Classification.Infrastructure.Database.Repositories;

public class PlayersClassificationRepository : IClassificationRepository
{
    private readonly IMongoCollection<PlayerBetPoints> _playersClassificationCollection;

    public PlayersClassificationRepository(IOptions<ClassificationDatabaseSettings> options)
    {
        var mongoClient = new MongoClient(options.Value.ConnectionString);
        var mongoDatabase = mongoClient.GetDatabase(options.Value.DatabaseName);
        _playersClassificationCollection = mongoDatabase.GetCollection<PlayerBetPoints>(options.Value.CollectionName);
    }

    public async Task<List<PlayerBetPoints>> GetAll()
    {
        var result = await _playersClassificationCollection.Find(_ => true).ToListAsync();

        return result;
    }

    public async Task Insert(PlayerBetPoints playerBetPoints)
    {
        await _playersClassificationCollection.InsertOneAsync(playerBetPoints);
    }

    public async Task Update(PlayerBetPoints playerBetPoints)
    {
        
    }

    public async Task<IReadOnlyCollection<PlayerBetPoints>> Get(Guid playerId)
    {
        var filter = Builders<PlayerBetPoints>.Filter.Eq("PlayerId", playerId);
        var result = (await _playersClassificationCollection.Find(filter).ToListAsync()).AsReadOnly();
        
        return result;
    }

    public async Task<IReadOnlyCollection<PlayerBetPoints>> GetBetPoints(Guid playerId, int betId)
    {
        var builder = Builders<PlayerBetPoints>.Filter;
        var filter = builder.Eq("PlayerId", playerId) & builder.Eq("BetId", betId);

        return  (await _playersClassificationCollection.Find(filter).ToListAsync()).AsReadOnly();
    }
}