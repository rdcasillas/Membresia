using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Membresia.Models
{
    public class tblPersonasHistorial
    {
        [Key]
        public int IdCambio { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha de Cambio")]
        public DateTime FechaCambio { get; set; }

        [Required]
        public int IdPersona { get; set; }

        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Apellido Paterno")]
        public string ApPaterno { get; set; }

        [Display(Name = "Apellido Materno")]
        public string ApMaterno { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime? FechaNacimiento { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "El formato de teléfono no es valido")]
        [StringLength(12, ErrorMessage = "Este campo solo acepta 12 caracteres.")]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "El formato de correo no es valido")]
        [StringLength(100, ErrorMessage = "Este campo solo acepta 12 caracteres.")]
        [Display(Name = "Correo Electrónico")]
        public string CorreoElectronico { get; set; }

        [StringLength(200, ErrorMessage = "Este campo solo acepta 200 caracteres.")]
        public string Calle { get; set; }

        [StringLength(50, ErrorMessage = "Este campo solo acepta 50 caracteres.")]
        public string colonia { get; set; }

        [StringLength(50, ErrorMessage = "Este campo solo acepta 50 caracteres.")]
        public string Ciudad { get; set; }

        [Display(Name = "Código Postal")]
        public int? CP { get; set; }

        [StringLength(50, ErrorMessage = "Este campo solo acepta 50 caracteres.")]
        public string Oficio { get; set; }

        [Column(TypeName = "varchar(MAX)")]
        public string Notas { get; set; }

        [Column(TypeName = "varchar(MAX)")]
        public string NotasMedicas { get; set; }

        public string RutaFoto { get; set; }

        [Display(Name = "Género")]
        public int? idsexo { get; set; }

        [Display(Name = "Estado Civil")]
        public int? IdEstadoCivil { get; set; }

        public int? IdEscolaridad { get; set; }

        public int? IDiglesia { get; set; }

        public int? IdMiembro { get; set; }

        public int? IdFamilia { get; set; }

        public int? IdBautismo { get; set; }

        public int? idEstatus { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Estatus")]
        public  DateTime? FechaEstatus { get; set; }


        [ForeignKey("IdPersona")]
        public virtual Personas Personas { get; set; }

       


    }
}
