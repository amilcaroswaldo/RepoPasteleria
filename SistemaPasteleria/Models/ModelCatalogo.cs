using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SistemaPasteleria.Models
{
    class ModelCatalogo
    {
        public class Catalogo
        {
            public int id_catalogo { get; set; }
            public string nombre { get; set; }

        }
        public class CatalogoContex : DbContext
        {
            public DbSet<Catalogo> Catalogos { get; set; }
        }
    }
}
