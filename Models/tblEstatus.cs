using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Membresia.Models
{
    public class tblEstatus
    {
        [Key]
        public int IdEstatus { get; set; }

        [Required(ErrorMessage = "Falta Nombre de Estatus!")]
        [Display(Name = "Estatus")]
        public string Estatus { get; set; }
    }
}
