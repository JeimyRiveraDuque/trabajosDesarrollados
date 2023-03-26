using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPSLaUltimaMorada.Vista;
using MySql.Data.MySqlClient;

namespace EPSLaUltimaMorada.Modelos
{
     class login
    {
        public String id;
        public String nombre;
        public String cedula;
    


        public login(string id, string nombre, string cedula)
        {
            this.id = id;
            this.nombre = nombre;
            this.cedula = cedula;
        
        }
    }
}
