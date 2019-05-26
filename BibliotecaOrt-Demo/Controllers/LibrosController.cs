using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BibliotecaOrt_Demo.Controllers
{
    public class LibrosController : Controller
    {
        // GET: Libros/Prueba
        public ActionResult Prueba()
        {
            var libro = new Models.Libro();
            
            return View(libro.LibroHardcodeado());
        }
    }
}