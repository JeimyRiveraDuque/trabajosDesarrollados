using EPSLaUltimaMorada.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections;

using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPSLaUltimaMorada.Controladores
{
    class InicioController:Conexion
    {

        public static void llenarcombo(ComboBox combo1)
        {
            MySqlCommand cm = new MySqlCommand("select id,rol from login", Conexion.obtenerConexion());
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);

            combo1.ValueMember = "id";
            combo1.DisplayMember = "rol";
            combo1.DataSource = dt;
                
                
        }

        public static int ValidarUsuarioAdmistrador(login login)
        {
            int validar = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("select * from login where id = '{0}',nombre='{1}' and cedula='{2}'",login.id, login.nombre, login.cedula),Conexion.obtenerConexion());
            validar = comando.ExecuteNonQuery();
            return validar;
       }


       
      

    }


      
    
}


