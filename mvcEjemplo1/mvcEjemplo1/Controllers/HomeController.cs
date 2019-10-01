using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcEjemplo1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Hola()
        {
            ViewBag.Message = "Prueba";
            string[] lista = new String[10];
            lista[1] = "Hola 1";
            lista[2] = "Hola 2";
            lista[3] = "Hola 3";
            lista[4] = "Hola 4";

            List<String> lstString = new List<String>();
            lstString.Add("Hola mundo 1");
            lstString.Add("Hola mundo 2");
            lstString.Add("Hola mundo 3");
            lstString.Add(" ");

            ViewBag.lista = lista;
            ViewBag.lista2 = lstString;

            return View();
        }

        [HttpGet]
        public ActionResult Formulario() {
            return View();
        }

        [HttpPost]
        public ActionResult Formulario(int num1, int num2) {
            ViewBag.suma = num1 + num2;
            ViewBag.resta = num1 - num2;
            ViewBag.multi = num1 * num2;
            ViewBag.div = num1 / num2;


            return View();
        }

        [HttpGet]
        public ActionResult Formulario2() {

            return View();
        }

        [HttpPost]
        public ActionResult Formulario2(string palabra, int cantidad) {
            ViewBag.palabra = palabra;
            ViewBag.cantidad = cantidad;
            return View();
        }
    }
}