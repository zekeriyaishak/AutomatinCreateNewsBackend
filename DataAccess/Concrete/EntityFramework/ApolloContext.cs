using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class ApolloContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb;Database=Apollo;Trusted_Connection=true");
        }

        public DbSet<User> USERS { get; set; }
        public DbSet<OperationClaim> OPERATIONCLAIMS { get; set; }
        public DbSet<UserOperationClaim> USEROPERATIONCLAIMS { get; set; }


    }
}
