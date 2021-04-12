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
    public class VEHICULOSController : ApiController
    {
        private ENTREGANDO_SASEntities db = new ENTREGANDO_SASEntities();

        // GET: api/VEHICULOS
        public IQueryable<VEHICULOS> GetVEHICULOS()
        {
            return db.VEHICULOS;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VEHICULOSExists(int id)
        {
            return db.VEHICULOS.Count(e => e.ID_VEHICULO == id) > 0;
        }
    }
}