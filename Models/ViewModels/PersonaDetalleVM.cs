using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Membresia.Models.ViewModels
{
    public class PersonaDetalleVM
    {
        public int IdPersona { get; set; }

        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

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
        [RegularExpression("^[1-3]*$", ErrorMessage = "Selecciona Sexo")]
        public int? idsexo { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime? FechaNacimiento { get; set; }

        [Display(Name = "Estado Civil")]
        public int? IdEstadoCivil { get; set; }

        public string Oficio { get; set; }

        [Column(TypeName = "varchar(MAX)")]
        public string Notas { get; set; }

        [Column(TypeName = "varchar(MAX)")]
        public string NotasMedicas { get; set; }

        public int? IdMiembro { get; set; }

        public int? IdFamilia { get; set; }

        public int? IdBautismo { get; set; }

        public int IdEstatus { get; set; }

        public int IdEscolaridad { get; set; }

        [Display(Name = "Escolaridad")]
        public string Escolaridad { get; set; }

        [Display(Name = "Estado Civil")]
        public string EstadoCivil { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Cambio Estatus")]
        public DateTime? FechaEstatus { get; set; }
        

        public IEnumerable<tblTipoMiembro> TipoMiembroList { get; set; }

        public IEnumerable<tblEstatus> EstatusList { get; set; }

        public int Edad
        {
            get
            {
                var today = DateTime.Today;
                var age = 0;
                if (FechaNacimiento != null)
                {
                    age = today.Year - FechaNacimiento.Value.Year;
                    if (FechaNacimiento.Value.Date > today.AddYears(-age)) age--;
                }
                
                

                return age;
            }
        }
        public string Genero
        {
            get
            {
                return idsexo == 1 ? "Hombre" : "Mujer";
            }
        }

        public string NombreCompleto
        {
            get
            {
                return Nombre + " " + ApPaterno + " " + ApMaterno;
            }
        }

        public string FechaNacimientoText
        {
            get
            {
                var fechita = "";
                if (FechaNacimiento == null)
                { fechita = ""; }
                else
                {
                    var fecha = DateTime.Parse(FechaNacimiento.ToString());
                    fechita = fecha.ToString("d MMMM,yyyy", CultureInfo.CreateSpecificCulture("es-MX"));
                }
                return fechita;
            }
        }

    }
}
