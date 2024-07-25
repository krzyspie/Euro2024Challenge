using MongoDB.Bson.Serialization.Attributes;

namespace Euro2024Challenge.Backend.Modules.Classification.Infrastructure.Database.Models
{
    public class PlayerBetPoints
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public Guid Id { get; set; } = Guid.NewGuid();

        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public Guid PlayerId { get; set; }

        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public Guid BetId { get; set; }
        
        public int Points { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
