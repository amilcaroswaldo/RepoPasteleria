﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace SistemaPasteleria.Models
{
    public class Receta
    {
        [Key]
        public int IdReceta { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }

        public virtual List<ListaMaterial> ListaMaterials { get; set; }
    }
}
