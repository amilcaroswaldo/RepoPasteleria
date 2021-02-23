using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace SistemaPasteleria.Models
{
    public class Material
    {
        [Key]
        public int IdMaterial { get; set; }
        public int IdCatalogo { get; set; }
        public double CantidadInicial { get; set; }
        public double Precio { get; set; }
        public double PrecioGramo { get; set; }
        public double CantidadDisponible { get; set; }
    }
}
