using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Repository
{
    public class Consulta
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string NameUser { get; set; }

        public string Extenso { get; set; }
        public int ValorConsultado { get; set; }
    }
}