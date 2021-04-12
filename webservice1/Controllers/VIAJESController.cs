using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using webservice1;

namespace webservice1.Controllers
{
    public class VIAJESController : ApiController
    {
        private ENTREGANDO_SASEntities db = new ENTREGANDO_SASEntities();

        // GET: api/VIAJES/5
        [ResponseType(typeof(VIAJES))]
        public IHttpActionResult GetVIAJES(int id)
        {
            VIAJES vIAJES = db.VIAJES.Find(id);
            if (vIAJES == null)
            {
                return NotFound();
            }

            return Ok(vIAJES);
        }

        // GET: api/VIAJES/1/1/2020-04-11
        [ResponseType(typeof(VIAJES))]
        [Route("api/VIAJES/{id_emp}/{id_veh}/{fecha}/")]
        public IHttpActionResult GetVIAJES(int id_emp, int id_veh, System.DateTime fecha)
        {
            DateTime endDate = fecha.Date.AddDays(1);
            
            IQueryable vIAJES = db.VIAJES.Where(
                viaje => viaje.ID_EMP == id_emp && 
                viaje.ID_VEHICULO == id_veh &&
                viaje.HORA_VIAJE > fecha 
            );

            if (vIAJES == null)
            {
                return NotFound();
            }

            return Ok(vIAJES);
        }

        // POST: api/VIAJES
        [ResponseType(typeof(VIAJES))]
        public IHttpActionResult PostVIAJES(VIAJES vIAJES)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.VIAJES.Add(vIAJES);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = vIAJES.ID_VIAJE }, vIAJES);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VIAJESExists(int id)
        {
            return db.VIAJES.Count(e => e.ID_VIAJE == id) > 0;
        }
    }
}