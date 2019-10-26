using Microsoft.AspNetCore.Mvc;
using deportivo.Models;
using System.Linq;

namespace deportivo.Controllers
{
    public class HomeController : Controller
    {
        private DeporteDbContext _context;

        public HomeController(DeporteDbContext c){
            _context=c;
        }

        public IActionResult Index(){

            return View();

        }

        public IActionResult Login(){

            return View();

        }

        public IActionResult Registrar(){

            return View();

        }

        public IActionResult Mostrar(){

            var lista= _context.Usuarios.ToList();  

            return View(lista);

        }

        [HttpPost]
        public IActionResult ValidarUsuario(){
            var usu= _context.Usuarios.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarUsu(RegistrarUsuario r){
            if(ModelState.IsValid){
                _context.Add(r);
                _context.SaveChanges();

                return RedirectToAction("Mostrar");
            }else{
                return View(r); 
            }
        }

        public IActionResult Dezapatilla(){

            return View();
        
        }
        
        public IActionResult Ingresar(){

            return View();

        }

        [HttpPost]
        public IActionResult Login(string user, string pass){
                var empleado = _context.Usuarios.FirstOrDefault(e => e.Usuario == user && e.Contra == pass);
                if(empleado!=null){
                    return RedirectToAction("Index");
                    

                    /*if(empleado.Categoria=="Jefe de programación"){
                        return RedirectToAction("MenuJefe");
                    }else{
                        return RedirectToAction("MenuOtros");
                    }*/
                }else{
                    //return Ingresar("Usuario o contraseña incorrectos");
                    return RedirectToAction("Ingresar");
                }
        }

    }
}