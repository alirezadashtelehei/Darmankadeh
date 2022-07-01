using DarmankadehTest.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DarmankadehTest.DbContexts
{
    public class AuthenticationContext: DbContext
    {
        public AuthenticationContext(DbContextOptions<AuthenticationContext> options) : base(options) { }

        public DbSet<User> Authentication { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, MobileNo = "09909031662", FirstName = "Alireza", LastName = "Dashtelehei", EmailAddress = "ar.dashtelehei@gmail.com" });
        }
    }
}
