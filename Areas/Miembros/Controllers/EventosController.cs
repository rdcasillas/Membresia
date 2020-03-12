using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Membresia.Data;
using Microsoft.EntityFrameworkCore;
using Membresia.Models;

namespace Membresia.Areas.Miembros.Controllers
{
    [Area("Miembros")]
    public class EventosController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EventosController(ApplicationDbContext db)
        {
            _db = db;
        }
        //GET
        public async Task<IActionResult> Index()
        {
            return View(await _db.Eventos.ToListAsync());
        }

        //GET - ir a nuevo registro
        public IActionResult Nuevo()
        {
            return View();
        }
    }
}