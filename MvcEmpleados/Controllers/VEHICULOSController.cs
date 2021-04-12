using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcEmpleados;

namespace MvcEmpleados.Controllers
{
    public class VEHICULOSController : Controller
    {
        private ENTREGANDO_SASEntities db = new ENTREGANDO_SASEntities();

        // GET: VEHICULOS
        public ActionResult Index()
        {
            return View(db.VEHICULOS.ToList());
        }

        // GET: VEHICULOS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VEHICULOS vEHICULOS = db.VEHICULOS.Find(id);
            if (vEHICULOS == null)
            {
                return HttpNotFound();
            }
            return View(vEHICULOS);
        }

        // GET: VEHICULOS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VEHICULOS/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_VEHICULO,PLACA,MODELO")] VEHICULOS vEHICULOS)
        {
            if (ModelState.IsValid)
            {
                db.VEHICULOS.Add(vEHICULOS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vEHICULOS);
        }

        // GET: VEHICULOS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VEHICULOS vEHICULOS = db.VEHICULOS.Find(id);
            if (vEHICULOS == null)
            {
                return HttpNotFound();
            }
            return View(vEHICULOS);
        }

        // POST: VEHICULOS/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_VEHICULO,PLACA,MODELO")] VEHICULOS vEHICULOS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vEHICULOS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vEHICULOS);
        }

        // GET: VEHICULOS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VEHICULOS vEHICULOS = db.VEHICULOS.Find(id);
            if (vEHICULOS == null)
            {
                return HttpNotFound();
            }
            return View(vEHICULOS);
        }

        // POST: VEHICULOS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VEHICULOS vEHICULOS = db.VEHICULOS.Find(id);
            db.VEHICULOS.Remove(vEHICULOS);
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
