using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Membresia.Models
{
    public class Eventos
    {
        [Key]
        public int IDevento { get; set; }

        [Required(ErrorMessage = "Falta Nombre de Evento!")]
        public string evento { get; set; }
        public bool estatus { get; set; }
        public int IDiglesia { get; set; }
    }
}
