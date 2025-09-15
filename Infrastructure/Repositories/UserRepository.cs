using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Models;

namespace Infrastructure.Repositories
{
    public class UserRepository: IUserRepository
    {        
        public UserRepository()
        {
                
        }
        public IEnumerable<User> GetUsers()
        {
            return null;
        }
        public User GetUserByUserId(int userId)
        {
            return null;
        }
        public void AddUser(User user)
        {

        }
        public void UpdateUser(User user) 
        {

        }      
        public void DeleteUser(int userId)
        {

        }
        public void SaveChanges()
        {
        }
    }
}
