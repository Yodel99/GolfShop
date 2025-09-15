using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        User GetUserByUserId(int userId);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int userId);
        void SaveChanges();
    }
}
