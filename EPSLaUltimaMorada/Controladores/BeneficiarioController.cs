using EPSLaUltimaMorada.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPSLaUltimaMorada.Controladores
{
    class BeneficiarioController:Conexion
    {
        public static void llenrcombo(ComboBox combo1)
        {
            MySqlCommand cm = new MySqlCommand("Select cedula, nombre from afiliado", Conexion.obtenerConexion());
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);

            combo1.ValueMember = "cedula";
            combo1.DisplayMember = "nombre";
            combo1.DataSource = dt;
        }
        public static int Crear(Beneficiarios beneficiario)
        {
            int retorno = 0;
            if (beneficiario.cedula != "" && beneficiario.telefono != "" && beneficiario.apellido != "" && beneficiario.telefono != "")
            {


                MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO beneficiario(cedula, nombre, apellido, telefono, email, afiliado) values ('{0}','{1}','{2}','{3}','{4}',{5})",
                    beneficiario.cedula, beneficiario.nombre, beneficiario.apellido, 
                    beneficiario.telefono, beneficiario.email, beneficiario.afiliado), Conexion.obtenerConexion());

                retorno = comando.ExecuteNonQuery();


                return retorno;


            }
            else
            {
                return retorno;
            }
        }
        public static int eliminar(Beneficiarios beneficiario)
        {
            int resultado = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM beneficiario WHERE cedula='{0}'", beneficiario.cedula),Conexion.obtenerConexion());

            resultado = comando.ExecuteNonQuery();
            return resultado;
        }
        //llena la dataGri
        public static List<Beneficiarios> llenar()
        {
            List<Beneficiarios> llenar = new List<Beneficiarios>();


            MySqlCommand cm = new MySqlCommand(String.Format("SELECT * FROM beneficiario"), Conexion.obtenerConexion());
            MySqlDataReader dt = cm.ExecuteReader();
            while (dt.Read())
            {
                Beneficiarios beneficiario = new Beneficiarios();

                beneficiario.cedula = dt.GetString(0);
                beneficiario.nombre = dt.GetString(1);
                beneficiario.apellido = dt.GetString(2);
                beneficiario.telefono = dt.GetString(3);
                beneficiario.email = dt.GetString(4);
                beneficiario.afiliado = dt.GetInt32(5);



                llenar.Add(beneficiario);
            }
            return llenar;

        }
    }
}
