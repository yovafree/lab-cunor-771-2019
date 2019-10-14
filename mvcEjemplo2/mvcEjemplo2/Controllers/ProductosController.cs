using mvcEjemplo2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcEjemplo2.Controllers
{
    public class ProductosController : Controller
    {
        ctxEjemplo2 ctx = new ctxEjemplo2();

        // GET: Productos
        public ActionResult Index()
        {
            var consulta = from m in ctx.producto
                           orderby m.nombre ascending
                           select m;

            ViewBag.lstProductos = consulta.ToArray();

            return View();
        }

        public ActionResult Create() {
            return View();
        }

        [HttpPost]
        public ActionResult Create(producto item) {
            try
            {
                ctx.producto.Add(item);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception x) {

            }
            return View();
        }


        public ActionResult Edit(int id) {
            producto item = null;

            item = (from m in ctx.producto
                   where m.cod_producto == id
                   select m).FirstOrDefault();


            return View(item);
        }

        [HttpPost]
        public ActionResult Edit(producto item) {
            try
            {
                ctx.Entry(item).State = EntityState.Modified;
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception x) { }

            return View();
        }

        public ActionResult Delete(int id)
        {
            producto item = null;

            item = (from m in ctx.producto
                    where m.cod_producto == id
                    select m).FirstOrDefault();

            if (item != null) {
                ctx.Entry(item).State = EntityState.Deleted;
                ctx.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}