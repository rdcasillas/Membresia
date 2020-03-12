using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Membresia.Areas.Miembros.Controllers
{
    [Area("Miembros")]
    public class PersonasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //GET - Crear nuevo registro
        public IActionResult Nuevo()
        {
            return View();
        }


        //GET - Ver Detalle
        public IActionResult Detalle()
        {
            return View();
        }

        //GET - Ver La línea de tiempo
        public IActionResult Timeline()
        {
            return View();
        }
    }
}