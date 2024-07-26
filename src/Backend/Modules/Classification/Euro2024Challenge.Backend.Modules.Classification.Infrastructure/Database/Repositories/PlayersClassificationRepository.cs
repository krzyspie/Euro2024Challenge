using Euro2024Challenge.Backend.Modules.Classification.Domain.Entities;
using Euro2024Challenge.Backend.Modules.Classification.Domain.Repositories;
using Euro2024Challenge.Backend.Modules.Classification.Infrastructure.Database.Models;
using Euro2024Challenge.Backend.Modules.Classification.Infrastructure.Database.Settings;
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

    public async Task<List<PlayersPoints>> GetAll()
    {
        var result = await _playersClassificationCollection.Find(_ => true).ToListAsync();

        return null;
    }

    public async Task Insert(Guid playerId, BetPoints points)
    {
        PlayerBetPoints playerBetPoints = new()
        {
            PlayerId = playerId,
            BetId = points.BetId,
            Points = points.Points
        };

        await _playersClassificationCollection.InsertOneAsync(playerBetPoints);
    }

    public async Task<List<BetPoints>> Get(Guid playerId)
    {
        var filter = Builders<PlayerBetPoints>.Filter.Eq("player_id", playerId);
        var result = await _playersClassificationCollection.Find(filter).FirstOrDefaultAsync();
        
        return [];
    }
}