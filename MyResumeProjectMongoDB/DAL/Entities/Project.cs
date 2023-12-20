using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MyResumeProjectMongoDB.DAL.Entities
{
    public class Project
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int ProjectID { get; set; }
        public int ImageUrl { get; set; }
        public int ProjectUrl { get; set; }
    }
}
