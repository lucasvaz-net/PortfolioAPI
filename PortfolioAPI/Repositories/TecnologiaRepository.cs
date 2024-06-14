using MongoDB.Driver;
using PortfolioAPI.Entities;

namespace PortfolioAPI.Repositories
{
    public class TecnologiaRepository
    {
        private readonly IMongoCollection<Tecnologia> _mongo;

        public TecnologiaRepository(MongoDBContext context)
        {
            _mongo = context.GetCollection<Tecnologia>("tecnologia");
        }

        public async Task<List<Tecnologia>> GetAllAsync() =>
            await _mongo.Find(tecnologia => true).ToListAsync();

        public async Task<Tecnologia> GetByIdAsync(string id) =>
            await _mongo.Find(tecnologia => tecnologia.Id == id).FirstOrDefaultAsync();
    }
}
