using System.Linq;
using deportivo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace deportivo.Controllers
{
    public class ProductosController : Controller
    {
        private DeporteDbContext _context;

        public ProductosController(DeporteDbContext c) {
            _context = c;
        }

        public IActionResult Registrar()
        {
            ViewBag.Categorias = _context.Categorias.ToList();
            return View();
        }        

        [HttpPost]
        public IActionResult Registrar(Producto x)
        {
            ViewBag.Categorias = _context.Categorias.ToList();
            
            if (ModelState.IsValid) {
                _context.Add(x);
                _context.SaveChanges();
                return RedirectToAction("Zapatilla");
            }
            return View(x);
        }
        
        public IActionResult Zapatilla(){

            var lista = _context.Productos.Include(x => x.Categoria).ToList();
            return View(lista);
            
        }

    }
}