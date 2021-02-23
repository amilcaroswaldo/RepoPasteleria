using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SistemaPasteleria.Models
{
    class ModelMaterialReceta
    {
              public class MaterialReceta
        {
            public int id_material_receta { get; set; }
            public int id_producto { get; set; }
            public int id_material { get; set; }
            public double cantidad { get; set; }
        }
        public class MaterialContex : DbContext
        {
            public DbSet<MaterialReceta> MaterialesReceta { get; set; }
        }
    }
}
