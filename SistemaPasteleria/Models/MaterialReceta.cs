using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SistemaPasteleria.Models
{
    public class MaterialReceta
    {

            public int IdMaterialReceta { get; set; }
            public int IdListaMaterial { get; set; }
            public int IdMaterial { get; set; }
            public double Cantidad { get; set; }
    }
}
