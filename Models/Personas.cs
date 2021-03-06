﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Membresia.Models
{
    public class Personas
    {
        [Key]
        public int IdPersona { get; set; }

        [Required(ErrorMessage = "Falta Nombre")]
        [StringLength(200,ErrorMessage = "Este campo solo acepta 200 caracteres.")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Falta Apellido Paterno")]
        [StringLength(200, ErrorMessage = "Este campo solo acepta 200 caracteres.")]
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

        [Display(Name ="Código Postal")]
        public int? CP { get; set; }

        [StringLength(50, ErrorMessage = "Este campo solo acepta 50 caracteres.")]
        public string Oficio { get; set; }

        [Column(TypeName = "varchar(MAX)")]
        public string Notas { get; set; }

        [Column(TypeName = "varchar(MAX)")]
        public string NotasMedicas { get; set; }

        [Display(Name = "Fecha de Registro")]
        public DateTime FechaRegistro { get; set; }

        public string RutaFoto { get; set; }

        [Display(Name = "Género")]
        public int? idsexo { get; set; }

        [Display(Name = "Estado Civil")]
        public int? IdEstadoCivil { get; set; }

        public int? IdEscolaridad { get; set; }

        [Required]
        public int IDiglesia { get; set; }

        public int? IdMiembro { get; set; } 

        public int? IdFamilia { get; set; }
       
        public int? IdBautismo { get; set; }

        [Required]
        public int idEstatus { get; set; }


        [ForeignKey("IdEstadoCivil")]
        public virtual tblEstadoCivil TblEstadoCivil { get; set; }

        [ForeignKey("IDiglesia")]
        public virtual Iglesias Iglesias { get; set; }

        [ForeignKey("IdMiembro")]
        public virtual tblTipoMiembro TblTipoMiembro { get; set; }

        [ForeignKey("IdFamilia")]
        public virtual tblFamilias TblFamilias { get; set; }

        [ForeignKey("IdBautismo")]
        public virtual tblBautismo TblBautismo { get; set; }

        [ForeignKey("idEstatus")]
        public virtual tblEstatus TblEstatus { get; set; }


        [NotMapped]
        public string NombreCompleto
        {
            get
            {
                return Nombre + " " + ApPaterno + " " + ApMaterno;
            }
        }

        [NotMapped]
        public string FechaNacimientoText
        {
           
            get
            {

                var fechita = "";
                if(FechaNacimiento == null)
                {  fechita = ""; }
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
