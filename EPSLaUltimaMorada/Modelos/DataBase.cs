using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;





namespace EPSLaUltimaMorada.Modelos
{
    public class Conexion
    {
        public static MySqlConnection obtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server = localhost; user = root; database = eps; port = 3306; ");
            conectar.Open();
            return conectar;
        }
        
        //  "server=localhost;user=root;database=world;port=3306;password="
    }
}
