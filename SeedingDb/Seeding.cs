using Infrastructure.Seeding;
using Infrastructure;
using MongoDB.Driver;
using Microsoft.EntityFrameworkCore;

namespace SeedingDb
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MongoDbContext context = new MongoDbContext();

            Console.WriteLine("Reset database? Y/N");

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                Seed.Populate(context);
            }
        }
    }
}

