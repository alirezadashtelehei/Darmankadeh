using DarmankadehTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DarmankadehTest.Repository
{
    interface IAuthenticationRepository
    {
        User GetAuthenticationByPhone(string PhoneNo);
        void InsertAuthentication(Authentication authentication);
        void Save();
    }
}
