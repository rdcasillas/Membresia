using AutoMapper;
using Membresia.Models;
using Membresia.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Membresia.Automapper
{
    public class PersonasProfile : Profile
    {
        public PersonasProfile() 
        {
            CreateMap<Personas, PersonaEditarVM>();
            CreateMap<PersonaEditarVM, Personas>();
            CreateMap<Personas, PersonaDetalleVM>();
            CreateMap<PersonaDetalleVM, Personas>();
        }
    }
}
