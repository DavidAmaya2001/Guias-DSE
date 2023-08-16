using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPelicula.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /HelloWorld/Welcome/

        public ActionResult Welcome(string nombre, string apellido, int numVeces = 1)
        {
            //return "Este es el metodo de acción Bienvenido ...";
            //return HttpUtility.HtmlEncode("Hola " + nombre + ", NumVeces es: " + numVeces);
            //return HttpUtility.HtmlEncode("Hola " + nombre + ", ID: " + ID);

            ViewBag.Mensaje = "Hola " + nombre + " " + apellido + ", veces mostrado = ";
            ViewBag.NumVeces = numVeces;
            return View();
        }
    }
}