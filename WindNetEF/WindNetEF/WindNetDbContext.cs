using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindNetEF
{
    public class WindNetDbContext : DbContext
    {
        //public DbSet<Model> Models { get; set; }

        public WindNetDbContext()
            : base("name=WindNetConnString")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new Configuration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
