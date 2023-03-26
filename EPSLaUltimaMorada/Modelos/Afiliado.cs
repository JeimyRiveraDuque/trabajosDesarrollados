using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPSLaUltimaMorada.Modelos
{
    class Afiliado
    {

      
       public String cedula { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String telefono { get; set; }
        public String email { get; set; }

        public Afiliado() { }
        public Afiliado( string cedula, String nombre, String apellido, String telefono, String email)
        {
          
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.email = email;

        }

    }

    
}
