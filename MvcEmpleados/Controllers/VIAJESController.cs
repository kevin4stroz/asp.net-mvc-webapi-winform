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
    public class VIAJESController : Controller
    {
        private ENTREGANDO_SASEntities db = new ENTREGANDO_SASEntities();

        // GET: VIAJES
        public ActionResult Index()
        {
            var vIAJES = db.VIAJES.Include(v => v.EMPLEADOS).Include(v => v.VEHICULOS);
            return View(vIAJES.ToList());
        }

        // GET: VIAJES/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VIAJES vIAJES = db.VIAJES.Find(id);
            if (vIAJES == null)
            {
                return HttpNotFound();
            }
            return View(vIAJES);
        }

        // GET: VIAJES/Create
        public ActionResult Create()
        {
            ViewBag.ID_EMP = new SelectList(db.EMPLEADOS, "ID_EMP", "NOMBRE");
            ViewBag.ID_VEHICULO = new SelectList(db.VEHICULOS, "ID_VEHICULO", "PLACA");
            return View();
        }

        // POST: VIAJES/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_VIAJE,ORIGEN,DESTINO,T_TRANSCURRIDO_H,NOM_PASAJERO,ID_VEHICULO,ID_EMP,HORA_VIAJE")] VIAJES vIAJES)
        {
            if (ModelState.IsValid)
            {
                db.VIAJES.Add(vIAJES);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_EMP = new SelectList(db.EMPLEADOS, "ID_EMP", "NOMBRE", vIAJES.ID_EMP);
            ViewBag.ID_VEHICULO = new SelectList(db.VEHICULOS, "ID_VEHICULO", "PLACA", vIAJES.ID_VEHICULO);
            return View(vIAJES);
        }

        // GET: VIAJES/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VIAJES vIAJES = db.VIAJES.Find(id);
            if (vIAJES == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_EMP = new SelectList(db.EMPLEADOS, "ID_EMP", "NOMBRE", vIAJES.ID_EMP);
            ViewBag.ID_VEHICULO = new SelectList(db.VEHICULOS, "ID_VEHICULO", "PLACA", vIAJES.ID_VEHICULO);
            return View(vIAJES);
        }

        // POST: VIAJES/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_VIAJE,ORIGEN,DESTINO,T_TRANSCURRIDO_H,NOM_PASAJERO,ID_VEHICULO,ID_EMP,HORA_VIAJE")] VIAJES vIAJES)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vIAJES).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_EMP = new SelectList(db.EMPLEADOS, "ID_EMP", "NOMBRE", vIAJES.ID_EMP);
            ViewBag.ID_VEHICULO = new SelectList(db.VEHICULOS, "ID_VEHICULO", "PLACA", vIAJES.ID_VEHICULO);
            return View(vIAJES);
        }

        // GET: VIAJES/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VIAJES vIAJES = db.VIAJES.Find(id);
            if (vIAJES == null)
            {
                return HttpNotFound();
            }
            return View(vIAJES);
        }

        // POST: VIAJES/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VIAJES vIAJES = db.VIAJES.Find(id);
            db.VIAJES.Remove(vIAJES);
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
