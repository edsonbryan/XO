using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using XO.DB.SQL;
using XO.DB.SqlEf;

namespace XO.UI.Mvc.Controllers
{
    public class TipoProductoController : Controller
    {
        private Contexto db = new Contexto();

        // GET: TipoProducto
        public ActionResult Index()
        {
            var tipos = db.TiposProducto;
            return View(tipos.ToList());
        }

        public ActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(TipoProducto tipoProducto)
        {
            db.TiposProducto.Add(tipoProducto);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Editar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var tipo = db.TiposProducto.Find(id);

            if (tipo == null)
            {
                return HttpNotFound();
            }

            return View(tipo);
        }

        [HttpPost]
        public ActionResult Editar(TipoProducto tipoProducto)
        {
            db.Entry(tipoProducto).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}