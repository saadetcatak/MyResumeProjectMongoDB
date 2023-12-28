using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MyResumeProjectMongoDB.DAL.Entities
{
    public class About
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string AboutID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Kind1 { get; set; }
        public string Kind2 { get; set; }
        public string Kind3 { get; set; }
    }
}
