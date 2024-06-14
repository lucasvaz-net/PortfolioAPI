using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;


namespace PortfolioAPI.Entities
{
    public class Projeto
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("titulo")]
        public string Titulo { get; set; }

        [BsonElement("descricao")]
        public string Descricao { get; set; }

        [BsonElement("texto1")]
        public string Texto1 { get; set; }

        [BsonElement("texto2")]
        public string Texto2 { get; set; }

        [BsonElement("texto3")]
        public string Texto3 { get; set; }

        [BsonElement("datainicio")]
        public DateTime DataInicio { get; set; }

        [BsonElement("datafinal")]
        public DateTime DataFinal { get; set; }

        [BsonElement("linkgit")]
        public string LinkGit { get; set; }

        [BsonElement("linkweb")]
        public string LinkWeb { get; set; }

        [BsonElement("nrordemexibixao")]
        public int NrOrdemExibicao { get; set; }

        [BsonElement("listadetecnologias")]
        public List<string> ListaDeTecnologias { get; set; }

        [BsonElement("tipo")]
        public string Tipo { get; set; }
    }
}
