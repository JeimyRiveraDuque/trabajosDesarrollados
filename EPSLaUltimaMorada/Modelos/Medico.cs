using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EPSLaUltimaMorada.Modelos
{
    class Medico
    {
        public String cedula { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String hora { get; set; }
        public String fecha { get; set; }
        public int consultorio {get; set;}
        public Medico() { }


        public Medico(String cedula, String nombre, String apellido,String hora, String fecha,int consultorio )
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.hora = hora;
            this.fecha = fecha;
            this.consultorio = consultorio;

        }
    }
}
