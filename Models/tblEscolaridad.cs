using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Membresia.Models
{
    public class tblEscolaridad
    {
        [Key]
        public int IdEscolaridad { get; set; }

        [Required(ErrorMessage = "Falta Escolaridad!")]
        [Display(Name = "Escolaridad")]
        public string Escolaridad { get; set; }

    }
}
