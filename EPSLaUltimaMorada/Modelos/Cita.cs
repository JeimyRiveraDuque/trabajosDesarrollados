using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPSLaUltimaMorada.Modelos
{
    class Cita
    {
        public String cedula { get; set; }
        public int nombre_medico { get; set; }
        public String nombre_paciente { get; set; }
        public String  estado { get; set; }
        public String hora { get; set; }
        public String fecha { get; set; }
        public String consultorio { get; set; }

        public Cita() { }



        public Cita(String cedula,  int nom_medico, String nom_pacien, String estado, String hora, String fecha,String consultorio)
        {
            this.cedula = cedula;
            this.nombre_medico = nom_medico;
            this.nombre_paciente = nom_pacien;
            this.estado = estado;
            this.hora = hora;
            this.fecha = fecha;
            this.consultorio = consultorio;

        }
    }
}
