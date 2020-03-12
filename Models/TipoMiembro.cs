using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Membresia.Models
{
    public class TipoMiembro
    {
        [Key]
        public int IdMiembro { get; set; }

        [Required(ErrorMessage = "Falta Nombre de Tipo Miembro!")]
        [Display(Name ="Tipo de Miembro")]
        public string miembro { get; set; }
        public int IDiglesia { get; set; }
    }
}
