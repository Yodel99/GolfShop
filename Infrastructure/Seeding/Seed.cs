using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Infrastructure;
using MongoDB.Driver;
using MongoDB.EntityFrameworkCore;

namespace Infrastructure.Seeding
{
    public class Seed
    {
        public static void Populate(MongoDbContext context)
        {
            User user1 = new User("Admin", "123");
            User user2 = new User("User", "321");

            context.AddAsync(user1);
            
        }
       
    }
}
