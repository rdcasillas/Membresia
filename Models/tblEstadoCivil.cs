using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Membresia.Models
{
    public class tblEstadoCivil
    {
        [Key]
        public int IdEstadoCivil { get; set; }

        [Required(ErrorMessage = "Falta!")]
        [Display(Name = "Estado Civil")]
        public string EstadoCivil { get; set; }

    }
}
