using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Membresia.Data;
using Microsoft.EntityFrameworkCore;
using Membresia.Models;
using AutoMapper;
using Membresia.Models.ViewModels;
using System.Globalization;

namespace Membresia.Areas.Miembros.Controllers
{
    [Area("Miembros")]
    public class PersonasController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public PersonasController(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        //GET
        public async Task<IActionResult> Index()
        {
            //cambio de prueba
            return View(await _db.Personas.ToListAsync());
        }


        //GET - Crear nuevo registro
        public async Task<IActionResult> Nuevo()
        {
            
            ViewBag.FechaN = DateTime.Now.ToString("dd/MM/yyyy");
            ViewBag.EstadoCivil = await _db.tblEstadoCivil.ToListAsync();
           

            return View(); 
        }

        //POST - Nuevo Registro
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Nuevo(Personas tblPersona)
        {
            tblPersona.IDiglesia = 1;
            tblPersona.idEstatus = 1;
            tblPersona.FechaRegistro = DateTime.Now;
            tblPersona.IdMiembro = 1;
            _db.Personas.Add(tblPersona);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
            
        }

        //GET -DETALLE PERSONA
        public async Task<IActionResult> Detalle(int? id)
        {
            if (id == null){ return NotFound();}
            var tblPersona = await _db.Personas.FindAsync(id);
            if (tblPersona == null) { return NotFound(); }
            PersonaDetalleVM personaVM = _mapper.Map<PersonaDetalleVM>(tblPersona);

            //Seleccciona de la BD lista de tipoMiembro ***falta traer ID IGLESIA
            personaVM.TipoMiembroList = await (from tblTipoMiembro in _db.tblTipoMiembro
                                         where tblTipoMiembro.IDiglesia == 1
                                         select tblTipoMiembro).ToListAsync().ConfigureAwait(false);

            personaVM.EstatusList = await (from tblEstatus in _db.tblEstatus where tblEstatus.IdEstatus > 1 select tblEstatus).ToListAsync().ConfigureAwait(false);

            var listEscolaridad = await _db.tblEscolaridad.FindAsync(tblPersona.IdEscolaridad);
            if (listEscolaridad == null) { personaVM.Escolaridad = ""; } else { personaVM.Escolaridad = listEscolaridad.Escolaridad; }

            var listEdoCivil = await _db.tblEstadoCivil.FindAsync(tblPersona.IdEstadoCivil);
            if (listEdoCivil == null) { personaVM.EstadoCivil = ""; } else { personaVM.EstadoCivil = listEdoCivil.EstadoCivil; }

            ViewBag.FechaActual = DateTime.Now.ToString("dd/MM/yyyy");

            return View(personaVM);
        }

        //GET -EDIT
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null){ return NotFound();}
           
            var tblPersona = await _db.Personas.FindAsync(id);

            if (tblPersona == null){ return NotFound();}

            PersonaEditarVM pesonaVM = _mapper.Map<PersonaEditarVM>(tblPersona);

            pesonaVM.EstadoCivilList = await _db.tblEstadoCivil.ToListAsync();
            pesonaVM.EscolaridadList = await _db.tblEscolaridad.ToListAsync();

            return View(pesonaVM);
        }

        //POST - Editar Registro
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(PersonaEditarVM pesonaVM)
        {
            pesonaVM.EstadoCivilList = await _db.tblEstadoCivil.ToListAsync();
            pesonaVM.EscolaridadList = await _db.tblEscolaridad.ToListAsync();

            if (ModelState.IsValid)
            {

               Personas persona = _db.Personas.Find(pesonaVM.IdPersona);
               _mapper.Map(pesonaVM, persona);
                await _db.SaveChangesAsync();

                //return RedirectToAction(nameof(Detalle));
                return RedirectToAction("Detalle", "Personas", new { id = pesonaVM.IdPersona });
            }
            return View(pesonaVM);
        }

        [ActionName("CambiaTipoMiembro")]
        public async Task<IActionResult> CambiaTipoMiembro(int IdMiembro, int idPersona)
        {

            //if (idPersona == null) { return NotFound(); }
            if (IdMiembro != 0)
            {
                var result = _db.Personas.SingleOrDefault(p => p.IdPersona == idPersona);
                result.IdMiembro = IdMiembro;
                _db.SaveChanges();
            }

            return RedirectToAction("Detalle", "Personas", new { id = idPersona });
        }



        //Agrega o actualiza Nota
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AgregaNota(PersonaDetalleVM pesonaVM)
        {
            var result = await _db.Personas.SingleOrDefaultAsync(p => p.IdPersona == pesonaVM.IdPersona);
            result.Notas = pesonaVM.Notas;
            await _db.SaveChangesAsync();

            return RedirectToAction("Detalle", "Personas", new { id = pesonaVM.IdPersona });
        }





        //GET - Ver La línea de tiempo
        public IActionResult Timeline()
        {
            return View();
        }
    }
}