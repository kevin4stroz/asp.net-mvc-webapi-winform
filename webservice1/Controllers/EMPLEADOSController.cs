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
    public class EMPLEADOSController : ApiController
    {
        private ENTREGANDO_SASEntities db = new ENTREGANDO_SASEntities();

        // GET: api/EMPLEADOS
        public IQueryable<EMPLEADOS> GetEMPLEADOS()
        {
            return db.EMPLEADOS;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EMPLEADOSExists(int id)
        {
            return db.EMPLEADOS.Count(e => e.ID_EMP == id) > 0;
        }
    }
}