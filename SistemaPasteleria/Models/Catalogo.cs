using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPasteleria.Models
{
    [Table("Catalogo")]
    public class Catalogo
    {
        [Key]
        public int IdCatalogo { get; set; }

        [Required]
        public string Nombre { get; set; }

       public virtual List<Material> Materials { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
