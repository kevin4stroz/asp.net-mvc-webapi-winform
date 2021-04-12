using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AplicacionWindows.Clases
{
    class Empleado
    {
        public int ID_EMP { get; set; }
        public long CEDULA { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string SEXO { get; set; }
        public Nullable<System.DateTime> F_NACIMIENTO { get; set; }
        public System.DateTime F_REGISTRO { get; set; }
    }
}
