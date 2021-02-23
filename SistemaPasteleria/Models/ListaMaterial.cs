using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace SistemaPasteleria.Models
{
    public class ListaMaterial
    {
        [Key]
        public int IdListaMaterial { get; set; }
        public int IdReceta { get; set; }
        public Receta Receta { get; set; }
        public int IdCatalogo { get; set; }
        public Catalogo Catalogo { get; set; }
        public double Cantidad { get; set; }


    }
}
