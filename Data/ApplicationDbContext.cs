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
    }
}
