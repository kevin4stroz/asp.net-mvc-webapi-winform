using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionWindows.Clases
{
    class Viaje
    {
        public int ID_VIAJE { get; set; }
        public string ORIGEN { get; set; }
        public string DESTINO { get; set; }
        public System.TimeSpan T_TRANSCURRIDO_H { get; set; }
        public string NOM_PASAJERO { get; set; }
        public int ID_VEHICULO { get; set; }
        public int ID_EMP { get; set; }
        public System.DateTime HORA_VIAJE { get; set; }

    }
}
