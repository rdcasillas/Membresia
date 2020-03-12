using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Membresia.Models
{
    public class Iglesias
    {
        [Key]
        public int IDiglesia { get; set; }

        [Required(ErrorMessage = "Falta Nombre de Iglesia")]
        [Display(Name = "Nombre Iglesia")]
        public string iglesia { get; set; }

        [Required(ErrorMessage = "Falta Nombre del Pastor")]
        [Display(Name = "Pastor")]
        public string pastor { get; set; }

        [Display(Name = "País")]
        public string pais { get; set; }

        [Display(Name = "Ciudad")]
        public string ciudad { get; set; }
    }
}
