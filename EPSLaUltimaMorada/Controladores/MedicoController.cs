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
    class MedicoController : Conexion
    {
        //llena el combobox
        public static void llenrcombo(ComboBox combo1)
        {
            MySqlCommand cm = new MySqlCommand("Select idconsultorio, consultorio from consultorio", Conexion.obtenerConexion());
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);

            combo1.ValueMember = "idconsultorio";
            combo1.DisplayMember = "consultorio";
            combo1.DataSource = dt;
        }
        public static int agregar(Medico medico)
        {
            int resultado = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO medico(cedula, nombre,apellido,hora,fecha,consultorio) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", 
                medico.cedula, medico.nombre,medico.apellido,medico.hora,medico.fecha,medico.consultorio),Conexion.obtenerConexion());
            resultado = comando.ExecuteNonQuery();
            return resultado;

        }
        //llena la dataGri
        public static List<Medico> llenar()
        {
            List<Medico> llenar = new List<Medico>();


            MySqlCommand cm = new MySqlCommand(String.Format("SELECT * FROM medico"), Conexion.obtenerConexion());
            MySqlDataReader dt = cm.ExecuteReader();
            while (dt.Read())
            {
                Medico medico = new Medico();

                medico.cedula = dt.GetString(0);
                medico.nombre = dt.GetString(1);
                medico.apellido = dt.GetString(2);
                medico.hora = dt.GetString(3);
                medico.fecha = dt.GetString(4);
                medico.consultorio = dt.GetInt32(5);

               

                llenar.Add(medico);
            }
            return llenar;

        }
        public static int Eliminar(Medico medico)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM medico WHERE cedula='{0}'", medico.cedula), Conexion.obtenerConexion());

            retorno = comando.ExecuteNonQuery();

            return retorno;

        }
    }
}
