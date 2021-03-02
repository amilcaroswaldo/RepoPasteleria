using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPasteleria.Models
{
    [Table("Unidad")]
    public class Unidad
    {
        [Key]
        public int IdUnidad { get; set; }

        public string Nombre { get; set; }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
