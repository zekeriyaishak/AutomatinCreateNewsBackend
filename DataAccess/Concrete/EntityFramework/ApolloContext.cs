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
        //Fixed My database Connection because my db is not connect with my backend codes.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-SDKFJ6F;Initial Catalog=Apollo;Integrated Security=True;Trusted_Connection=true;TrustServerCertificate=True");
        }

        public DbSet<User> USERS { get; set; }
        public DbSet<OperationClaim> OPERATIONCLAIMS { get; set; }
        public DbSet<UserOperationClaim> USEROPERATIONCLAIMS { get; set; }


    }
}
