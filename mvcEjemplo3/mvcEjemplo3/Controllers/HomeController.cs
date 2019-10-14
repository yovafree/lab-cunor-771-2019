using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcEjemplo3.Controllers
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

        [HttpGet]
        public JsonResult ListaEstudiantes() {
            string[] lista = new string[10];

            lista[0] = "Elemento 1";
            lista[1] = "Elemento 2";
            lista[2] = "Elemento 3";
            lista[3] = "Elemento 4";
            lista[4] = "Elemento 5";

            return Json(lista, JsonRequestBehavior.AllowGet);
        }
    }
}