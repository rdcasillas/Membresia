using System;
using System.Collections.Generic;
using System.Text;
using Membresia.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Membresia.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Iglesias> Iglesias { get; set; }
        public DbSet<Eventos> Eventos { get; set; }
        public DbSet<Personas> Personas { get; set; }
        public DbSet<tblEstadoCivil> tblEstadoCivil { get; set; }
        public DbSet<tblEscolaridad> tblEscolaridad { get; set; }
        public DbSet<tblTipoMiembro> tblTipoMiembro { get; set; }
        public DbSet<tblBautismo> tblBautismo { get; set; }
        public DbSet<tblFamilias> tblFamilia { get; set; }
        public DbSet<tblEstatus> tblEstatus { get; set; }
        public DbSet<tblPersonasHistorial> tblPersonasHistorial { get; set; }
    }
}
