using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace festival.Models
{
    public class Employee
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("first_name")]
        public string First_name { get; set; }

        [BsonElement("last_name")]
        public string Last_name { get; set; }

        [BsonElement("age")]
        public decimal Age { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("username")]
        public string Username { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }
    }
}
