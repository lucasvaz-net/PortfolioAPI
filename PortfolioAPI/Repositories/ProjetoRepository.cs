using MongoDB.Driver;
using PortfolioAPI.Entities;

namespace PortfolioAPI.Repositories
{
    public class ProjetoRepository
    {
        private readonly IMongoCollection<Projeto> _mongo;

        public ProjetoRepository(MongoDBContext context)
        {
            _mongo = context.GetCollection<Projeto>("projeto");
        }

        public async Task<List<Projeto>> GetAllAsync() =>
            await _mongo.Find(projeto => true).ToListAsync();

        public async Task<Projeto> GetByIdAsync(string id) =>
            await _mongo.Find(projeto => projeto.Id == id).FirstOrDefaultAsync();
    }
}
