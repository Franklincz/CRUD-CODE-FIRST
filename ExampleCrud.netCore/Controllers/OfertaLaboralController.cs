using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleCrud.netCore.Models;

namespace ExampleCrud.netCore.Controllers
{
    public class OfertaLaboralController : Controller
    {

        //invocar al aplicationdbcontext  permite acceder a la base de datos

        public readonly ReclutamientoDBContext _context;
        public OfertaLaboralController(ReclutamientoDBContext context)
        {
            _context = context;
        }





        public IActionResult Index()
        {
            return View();
        }
       // [HttpPost]
        public IActionResult ListaOfertas()
        {
            //  List<OfertaLaboral> listaOfertas = new List<OfertaLaboral>();
            //listaOfertas.Add(new OfertaLaboral(1,titulo))



            IEnumerable<OfertaLaboral> listLibros = _context.OfertaLaboral;
            
            return View(listLibros);

        }


        //Http Get crear Una publicacion

        public IActionResult CrearOferta()
        {

            return View();


        }


        [HttpPost]
        public IActionResult CrearOferta(OfertaLaboral oferta)
        {

            if (ModelState.IsValid)
            {
                _context.OfertaLaboral.Add(oferta);
                _context.SaveChanges();
                //para dar mensaje que se ha registrado correctament
                TempData["Mensaje"] = "Se ha registrado correctamente la oferta laboral";
                //para retornar a la lista 
                return RedirectToAction("ListaOfertas");

            }

            return View();


        }

       /// [HttpGet]
        public IActionResult EditarOferta(int? id)
        {
            if(id==null || id == 0)
            {

                return NotFound();
            }


            //obtener el; libro
            var OfertaLaboral = _context.OfertaLaboral.Find(id);


            if (OfertaLaboral == null)
            {

                return NotFound();
            }

            return View(OfertaLaboral);
        }



        [HttpPost]
        public IActionResult EditarOferta(OfertaLaboral oferta)
        {


            if (ModelState.IsValid)
            {
                _context.OfertaLaboral.Update(oferta);
                _context.SaveChanges();
                //para dar mensaje que se ha registrado correctament
                TempData["Mensaje"] = "Se ha actualizado correctamente la oferta laboral";
                //para retornar a la lista 
                return RedirectToAction("ListaOfertas");

            }

            return View();


        }





        //Http Get Delete
        public IActionResult EliminarOferta(int? id)
        {
            if (id == null || id == 0)
            {

                return NotFound();
            }


            //obtener el; libro
            var oferta = _context.OfertaLaboral.Find(id);//--le digo buscala oferta


            if (oferta == null)
            {

                return NotFound();
            }

            return View(oferta);
        }


        //Http Post Delete
        /*
         
         Como no puede tener dos métodos con el mismo nombre y firma, debe usar el ActionNameatributo:
         
         */
        [HttpPost, ActionName("EliminarOferta")]
  
        public IActionResult EliminarOfertaPost(int? id)
        {
            //obtener la oferta
            var oferta=_context.OfertaLaboral.Find(id);

            if (oferta==null)
            {
                return NotFound();

               
            
            }
            
            _context.OfertaLaboral.Remove(oferta);
            _context.SaveChanges();
            TempData["mensaje"] = "Ellibr0 se elimino corretamete";
            return RedirectToAction(nameof(ListaOfertas));


        }














    }
    
}
