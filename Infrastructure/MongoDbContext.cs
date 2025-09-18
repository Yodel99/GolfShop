using MongoDB.Driver;
using MongoDB.Bson;
using Microsoft.EntityFrameworkCore;
using MongoDB.EntityFrameworkCore.Extensions;
using Domain.Models;
using Infrastructure;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Runtime;
using Infrastructure.Repositories;



namespace Infrastructure
{

    public class MongoDbContext: DbContext
    {
       
        public IMongoCollection<Product> Products { get; init; }
        public IMongoCollection<User> Users { get; init; }
        public MongoDbContext()
        {
        }
        public MongoDbContext(string databaseName, MongoClient client)
        {
            var database = client.GetDatabase(databaseName);
            Users = database.GetCollection<User>("users");
            Products = database.GetCollection<Product>("GolfItems");
        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().ToCollection("GolfItems");
            modelBuilder.Entity<User>().ToCollection("users");
            
        }




        //private readonly IMongoCollection<Product> _productsCollection;

        //public MongoDbContext(MongoDbSettings settings)
        //{
        //    var client = new MongoClient(settings.ConnectionString);
        //    var database = client.GetDatabase(settings.DatabaseName);
        //    _productsCollection = database.GetCollection<Product>(settings.CollectionName);
        //}

        //public async Task<List<Product>> GetAllAsync()
        //{
        //    return await _productsCollection.Find(_ => true).ToListAsync();
        //}

        public async Task AddAsync(User user)
        {
            await Users.InsertOneAsync(user);
            
        }
    }
}
