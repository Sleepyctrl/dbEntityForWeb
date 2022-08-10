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
            // Database.EnsureDeleted();
            // Database.EnsureCreated();
               Database.Migrate();
        }
       

       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"host=localhost;port=5432;DataBase=db;Username=postgres;password=1234");
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<LogActivity> LogActivities { get; set; }
    }
}
