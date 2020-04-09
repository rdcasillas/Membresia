using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Membresia.Models.ViewModels
{
    public class PersonaEditarVM
    {
        
        public int IdPersona { get; set; }

        [Required(ErrorMessage = "Falta Nombre")]
        [StringLength(200, ErrorMessage = "Este campo solo acepta 200 caracteres.")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Falta Apellido Paterno")]
        [StringLength(200, ErrorMessage = "Este campo solo acepta 200 caracteres.")]
        [Display(Name = "Apellido Paterno")]
        public string ApPaterno { get; set; }

        [Display(Name = "Apellido Materno")]
        public string ApMaterno { get; set; }

        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "El formato de correo no es valido")]
        [StringLength(100, ErrorMessage = "Este campo solo acepta 12 caracteres.")]
        [Display(Name = "Correo Electrónico")]
        public string CorreoElectronico { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "El formato de teléfono no es valido")]
        [StringLength(12, ErrorMessage = "Este campo solo acepta 12 caracteres.")]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        [StringLength(200, ErrorMessage = "Este campo solo acepta 200 caracteres.")]
        public string Calle { get; set; }

        [StringLength(50, ErrorMessage = "Este campo solo acepta 50 caracteres.")]
        public string colonia { get; set; }

        [StringLength(50, ErrorMessage = "Este campo solo acepta 50 caracteres.")]
        public string Ciudad { get; set; }

        [Display(Name = "Código Postal")]
        public int? CP { get; set; }

        [Display(Name = "Género")]
        [RegularExpression("^[1-3]*$", ErrorMessage ="Selecciona Sexo")]
        public int? idsexo { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime? FechaNacimiento { get; set; }

        [Display(Name = "Estado Civil")]
        public int? IdEstadoCivil { get; set; }

        [Display(Name = "Escolaridad")]
        public int? IdEscolaridad { get; set; }

        [StringLength(50, ErrorMessage = "Este campo solo acepta 50 caracteres.")]
        public string Oficio { get; set; }

        public IEnumerable<tblEscolaridad> EscolaridadList { get; set; }

        public IEnumerable<tblEstadoCivil> EstadoCivilList { get; set; }

        public string MsjError { get; set; }



    }
}
