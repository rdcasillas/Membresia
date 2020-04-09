using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Membresia.Models
{
    public class tblFamilias
    {
        [Key]
        public int IdFamilia { get; set; }

        [Required(ErrorMessage = "Falta Nombre de Familia!")]
        [Display(Name = "Familia")]
        public string Familia { get; set; }

        [Required]
        [Display(Name = "Iglesia")]
        public int IDiglesia { get; set; }

        [ForeignKey("IDiglesia")]
        public virtual Iglesias Iglesias { get; set; }

    }
}
