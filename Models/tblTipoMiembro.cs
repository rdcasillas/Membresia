using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Membresia.Models
{
    public class tblTipoMiembro
    {
        [Key]
        public int IdMiembro { get; set; }

        [Required(ErrorMessage = "Falta Nombre de Tipo Miembro!")]
        [Display(Name ="Tipo de Miembro")]
        public string TipoMiembro { get; set; }

        [Required]
        [Display(Name = "Iglesia")]
        public int IDiglesia { get; set; }

        [ForeignKey("IDiglesia")]
        public virtual Iglesias Iglesias { get; set; }
    }
}
