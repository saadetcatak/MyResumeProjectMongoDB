using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MyResumeProjectMongoDB.DAL.Entities
{
    public class ContactInfo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ContactInfoID { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
    

    }
}
