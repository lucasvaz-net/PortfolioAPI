using MongoDB.Driver;
using PortfolioAPI.Entities;

namespace PortfolioAPI.Repositories
{
    public class EstudoRepository
    {
        private readonly IMongoCollection<Estudo> _mongo;

        public EstudoRepository(MongoDBContext context)
        {
            _mongo = context.GetCollection<Estudo>("estudo");
        }

        public async Task<List<Estudo>> GetAllAsync() =>
            await _mongo.Find(estudo => true).ToListAsync();

        public async Task<Estudo> GetByIdAsync(string id) =>
            await _mongo.Find(estudo => estudo.Id == id).FirstOrDefaultAsync();
    }
}
