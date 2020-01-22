using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindNetEF.Models;

namespace WindNetEF
{
    public class WindNetDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public WindNetDbContext()
            : base("name=WindNetConnString")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EntityConfigurations.CompanyConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
