using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace PortfolioAPI.Entities
{
   
    public class Tecnologia
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("titulo")]
        public string Titulo { get; set; }

        [BsonElement("descricao")]
        public string Descricao { get; set; }

        [BsonElement("tipo")]
        public string Tipo { get; set; }

        [BsonElement("nivelhabilidade")]
        public int NivelHabilidade { get; set; }
    }

}
