using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPSLaUltimaMorada.Modelos
{
    class Reportes
    {
        public String cedula { get; set; }
        public String estado_cita { get; set; }
        public String observacion { get; set; }
        public Reportes() { }

        public Reportes (String cedula, String estadocita, String observacion)
        {
            this.cedula = cedula;
            this.estado_cita = estadocita;
            this.observacion = observacion;
        }
    }
}
