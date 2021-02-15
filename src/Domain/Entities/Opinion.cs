using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace Domain.Entities
{
    public class Opinion
    {
        [JsonIgnore]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public long Fingerprint { get; set; }

        public string Url { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        public UrlInfo UrlInfo { get; set; }
    }

    public class UrlInfo
    {
        public string FullUrl { get; set; }

        public string Host { get; set; }

        public string Subject { get; set; }
    }
}
