using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace SistemaPasteleria.Models
{
    public class Catalogo
    {
        [Key]
        public int IdCatalogo { get; set; }

        [Required]
        public string Nombre { get; set; }

        public virtual List<Material> Materials { get; set; }

    }
}
