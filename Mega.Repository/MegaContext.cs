using BusinessEntities.Account;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mega.Repository
{
    public class MegaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=94.73.145.4;Database=u8253916_mega; Uid=u8253916_mega;Pwd=UYha13W2;");
        }


        public DbSet<User> UserSet { get; set; }
    }
}
