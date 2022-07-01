using DarmankadehTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DarmankadehTest.Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        User GetUserById(int UserId);
        void InsertUser(User user);
        void UpdateUser(User user);
        void Save();
    }
}
