using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace SistemaPasteleria.Models
{
    public class MaterialReceta
    {
        [Key]
        public int IdMaterialReceta { get; set; }
        public int IdListaMaterial { get; set; }

        public ListaMaterial ListaMaterial { get; set; }
        public int IdMaterial { get; set; }

        public Material Material { get; set; }
        public double Cantidad { get; set; }
    }
}
