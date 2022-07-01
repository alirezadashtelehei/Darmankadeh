using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DarmankadehTest.DbContexts;
using DarmankadehTest.Model;
using Microsoft.EntityFrameworkCore;

namespace DarmankadehTest.Repository
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly AuthenticationContext _dbContext;
        public AuthenticationRepository(AuthenticationContext dbContext)
        {
            _dbContext = dbContext;
        }
        public User GetAuthenticationByPhone(string PhoneNo)
        {
            return _dbContext.Authentication.Find(PhoneNo);
        }

        public void InsertAuthentication(Authentication authentication)
        {
            _dbContext.Add(authentication);            
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
