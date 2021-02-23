using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SistemaPasteleria.Models
{
    class ModelVenta
    {
        public class Venta
        {
            public int id_receta { get; set; }
            public string fecha { get; set; }
            public double cantidad { get; set; }
            public double precio_unitario { get; set; }
        }
        public class VentaContex : DbContext
        {
            public DbSet<Venta> Ventas { get; set; }
        }
    }
}
