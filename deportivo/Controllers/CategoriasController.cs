using deportivo.Models;
using Microsoft.AspNetCore.Mvc;

namespace deportivo.Controllers
{
    public class CategoriasController : Controller
    {
        private DeporteDbContext _context;

        public CategoriasController(DeporteDbContext c) {

            _context = c;
            
        }

        public IActionResult Registrar(){

            return View();

        }
        
        [HttpPost]
        public IActionResult Registrar(Categoria c)
        {
            if (ModelState.IsValid) {
                _context.Add(c);
                _context.SaveChanges();
                return RedirectToAction("Registrar");
            }
            return View(c);
        }

    }
}