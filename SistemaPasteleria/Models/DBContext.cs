using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPasteleria.Models
{
    public class DBContext: DbContext
    {
        public DBContext() : base(nameOrConnectionString: "Default") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Catalogo> Catalogos { get; set; }
        public DbSet<ListaMaterial> ListaMaterials { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Receta> Recetas { get; set; }
        public DbSet<MaterialReceta> MaterialRecetas { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Unidad> Unidades { get; set; }
    }
}
