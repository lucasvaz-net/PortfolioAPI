using MongoDB.Driver;
using PortfolioAPI.Entities;

namespace PortfolioAPI.Repositories
{
    public class ExperienciaRepository
    {
        private readonly IMongoCollection<Experiencia> _mongo;

        public ExperienciaRepository(MongoDBContext context)
        {
            _mongo = context.GetCollection<Experiencia>("experiencia");
        }

        public async Task<List<Experiencia>> GetAllAsync() =>
            await _mongo.Find(experiencia => true).ToListAsync();

        public async Task<Experiencia> GetByIdAsync(string id) =>
            await _mongo.Find(experiencia => experiencia.Id == id).FirstOrDefaultAsync();
    }
}
