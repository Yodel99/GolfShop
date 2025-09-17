using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Domain.Models;
using MongoDB.Driver;

namespace Infrastructure
{
    public class MongoDbSettings
    {

        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
        public string CollectionName { get; set; } = null!;

        public MongoDbSettings()
        {
            
        }

    }
}
