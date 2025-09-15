using MongoDB.Driver;
using Domain.Models;

namespace Infrastructure
{
    public class MongoDbService
    {        
        private readonly IMongoCollection<Product> _productsCollection;

        public MongoDbService(MongoDbSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _productsCollection = database.GetCollection<Product>(settings.CollectionName);
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _productsCollection.Find(_ => true).ToListAsync();
        }

        public async Task AddAsync(Product product)
        {
            await _productsCollection.InsertOneAsync(product);
        }
    }
}
