using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Model
{
    public class Vacante
    {        
        [Key]
        public int VacanteId { get; set; }
        [Required]
        public string Nombre { get; set; }
        public Empresa Empresa { get; set; }
    }
}
