using EPSLaUltimaMorada.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace EPSLaUltimaMorada.Controladores
{
    class CitaController:Conexion
    {
        public static void llenar(ComboBox combo1, TextBox consultorio, TextBox fecha)
        {
            MySqlCommand cm = new MySqlCommand(string.Format("Select cedula, nombre, fecha, consultorio from medico"), Conexion.obtenerConexion());
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);

            combo1.ValueMember = "cedula";
            combo1.DisplayMember = "nombre";

            combo1.DataSource = dt;



        }

        /*public static void datos(ComboBox combo, TextBox consultorio, TextBox fecha)
        {

            MySqlCommand comado = new MySqlCommand(string.Format("select consultorio, fecha from medico where cedula='{0}' and nombre={0}", combo.Text,combo.Text), Conexion.obtenerConexion());
            MySqlDataReader dr = comado.ExecuteReader();
            if (dr.Read() == true)
            { 

                
            }
        }*/

        public static int agregarcita(Cita citas)
        {
            int resultado = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("insert into cita (cedula, nombre_medico, nombre_paciente,estado_paciente, hora, fecha, consultorio) Values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                citas.cedula,citas.nombre_medico,citas.nombre_paciente,citas.estado,citas.hora,citas.fecha,citas.consultorio), Conexion.obtenerConexion());
            resultado = comando.ExecuteNonQuery();

            return resultado;
        }

    }
}
