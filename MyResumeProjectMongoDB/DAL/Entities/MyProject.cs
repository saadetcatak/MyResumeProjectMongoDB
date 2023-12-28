using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MyResumeProjectMongoDB.DAL.Entities
{
    
    public class MyProject
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string MyProjectID { get; set; }
        public string Link { get; set; }
        public string Image { get; set; }
        public string Status { get; set; }
    }
}
