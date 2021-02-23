using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SistemaPasteleria.Models
{
    class ModelReceta
    {
        public class Receta
        {
            public int id_receta { get; set; }
            public string nombre { get; set; }
            public string descripcion { get; set; }
            public double precio_unitario { get; set; }
        }
        public class RecetaContex : DbContext
        {
            public DbSet<Receta> Recetas { get; set; }
        }
    }
}
