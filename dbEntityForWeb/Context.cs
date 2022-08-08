using dbEntityForWeb.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbEntityForWeb
{
     class Context:DbContext
    {
        public Context()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"host=localhost;port=;database=db;username=root;password=1234;");
        }
        public DbSet<Client> Clients { get; set; }
    }
}
