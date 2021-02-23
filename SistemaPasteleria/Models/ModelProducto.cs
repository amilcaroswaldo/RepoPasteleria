using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SistemaPasteleria.Models
{
    class ModelProducto
    {
        public class Producto
        {
            public int id_producto { get; set; }
            public int id_receta { get; set; }
            public int id_catalogo { get; set; }
            public double cantidad { get; set; }
            public double precio { get; set; }
        }
        public class ProductoContex : DbContext
        {
            public DbSet<Producto> Productos { get; set; }
        }
    }
}
