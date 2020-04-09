using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Membresia.Models
{
    public class tblBautismo
    {
        [Key]
        public int IdBautismo { get; set; }

        [Required(ErrorMessage = "Falta Fecha de Bautismo!")]
        [Display(Name = "Fecha de Bautismo")]
        public DateTime FechaBautismo { get; set; }
    }
}
