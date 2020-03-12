using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Membresia.Data;
using Microsoft.EntityFrameworkCore;
using Membresia.Models;

namespace Membresia.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class IglesiasController : Controller
    {
        private readonly ApplicationDbContext _db;
        public IglesiasController(ApplicationDbContext db)
        {
            _db = db;
        }
        //GET
        public async Task<IActionResult> Index()
        {
            return View(await _db.Iglesias.ToListAsync());
        }

        //GET - Crear nuevo registro
        public IActionResult Nuevo()
        {
            return View();
        }

        //POST - Nuevo Registro
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Nuevo(Iglesias tblIglesia)
        {
            //if (ModelState.IsValid)
            //{
                _db.Iglesias.Add(tblIglesia);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            //}
            //return View(tblIglesia);
        }

        //GET -EDIT
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var tblIglesia = await _db.Iglesias.FindAsync(id);
            if (tblIglesia == null)
            {
                return NotFound();
            }
            return View(tblIglesia);
        }

        //POST - Editar Registro
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(Iglesias tblIglesia)
        {
            if (ModelState.IsValid)
            {
                _db.Iglesias.Update(tblIglesia);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(tblIglesia);
        }


        //POST - BORRAR Registro
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Borrar(int? id)
        {
            
            var tblIglesia = await _db.Iglesias.FindAsync(id);
            if(tblIglesia == null)
            {
                return NotFound();
            }
            _db.Iglesias.Remove(tblIglesia);
            await _db.SaveChangesAsync();
           
            return RedirectToAction(nameof(Index));
        }






    }


}