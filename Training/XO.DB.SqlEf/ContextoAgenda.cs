using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XO.Entities;

namespace XO.DB.SqlEf
{
    public class ContextoAgenda : DbContext
    {
        public ContextoAgenda() : base("rainbow")
        {
        }

        public DbSet<Actividad> Actividades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ContextoAgenda>(null);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
