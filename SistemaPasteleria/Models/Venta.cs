﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPasteleria.Models
{
    [Table("Venta")]
    public class Venta
    {
        [Key]
        public int IdVenta { get; set; }
        public int IdReceta { get; set; }
        public Receta Receta { get; set; }
        public DateTime Fecha { get; set; }
        public double Cantidad { get; set; }
        public double PrecioUnitario { get; set; }

    }
}
