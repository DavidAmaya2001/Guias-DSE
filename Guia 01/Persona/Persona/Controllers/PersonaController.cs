using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Persona.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string nombre, string apellido, string nacimiento, string direccion, string correo, int DUI = 1)
        {
            ViewBag.Mensaje = "Hola " + nombre + " " + apellido;
            ViewBag.DUI = "Numero de DUI: " + DUI;
            ViewBag.Nacimiento = "Fecha de Nacimiento: " + nacimiento;
            ViewBag.Direccion = "Direccion: " + direccion;
            ViewBag.Correo = "Correo Electronico: " + correo;
            return View();
        }
    }
}