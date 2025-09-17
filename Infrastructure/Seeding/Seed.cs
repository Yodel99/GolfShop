using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Infrastructure.Seeding
{
    public class Seed
    {
        User user1 = new User("Admin", "123");
        User user2 = new User("User", "123");
    }
}
