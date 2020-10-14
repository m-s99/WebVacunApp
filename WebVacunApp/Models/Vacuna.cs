using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebVacunApp.Models
{
    public class Vacuna
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Vacuna")]
        public string Nombre { get; set; }
        [Required]
        public int PeriodoAplicacion { get; set; }
        [Required]
        public string Beneficios { get; set; }

    }
}
