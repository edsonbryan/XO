using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using XO.DB.SQL;

namespace XO.DB.SqlEf
{
    public class Contexto : DbContext
    {
        public Contexto() : base ("rainbow")
        {
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<TipoProducto> TiposProducto { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            System.Data.Entity.Database.SetInitializer<Contexto>(null);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
