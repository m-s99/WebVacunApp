using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebVacunApp.Models
{
    public class Calendario
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Calendario")]
        public string Nombre { get; set; }
        [Required]
        public string SexoPaciente { get; set; }
        [Required]
        public bool Prematuro { get; set; }
    }
}
