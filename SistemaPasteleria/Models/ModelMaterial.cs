using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SistemaPasteleria.Models
{
    class ModelMaterial
    {
        public class Material
        {
            public int id_material { get; set; }
            public int id_catalogo { get; set; }
            public double cantidad_inicial { get; set; }
            public double precio { get; set; }
            public double precio_gramo { get; set; }
            public double cantidad_disponible { get; set; }


        }
        public class MaterialContex : DbContext
        {
            public DbSet<Material> Materiales { get; set; }
        }
    }
}
