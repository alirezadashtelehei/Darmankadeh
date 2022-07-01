using DarmankadehTest.DbContexts;
using DarmankadehTest.Model;
using DarmankadehTest.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DarmankadehXUnitTestProject
{
    class UserRepositoryTest : IUserRepository
    {
        private readonly UserContext _dbContext;
        private readonly List<User> _users;
        public UserRepositoryTest(UserContext dbContext)
        {
            _dbContext = dbContext;
        }
        public UserRepositoryTest()
        {
            
            _users = new List<User>()
            {
                new User(){Id=2,FirstName="Ali",LastName="Dashti",MobileNo="09909031662",EmailAddress="ar.dashtelehei@gmail.com"}
            };
        }

        public IEnumerable<User> GetUsers()
        {
            return _users;
        }

        public void InsertUser(User newUser)
        {            
            _users.Add(newUser);            
        }
        public User GetUserById(int id)
        {
            return _users.Where(a => a.Id == id)
                .FirstOrDefault();
        }

        public void Save()
        {
            
        }

        public void UpdateUser(User user)
        {
            
        }
    }
}
