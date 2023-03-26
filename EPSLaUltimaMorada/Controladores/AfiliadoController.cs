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
    class AfiliadoController

    {

        private int validar(Afiliado afiliado)
        {
            int validar = 0;
            if (afiliado.cedula != "" && afiliado.telefono != "" && afiliado.apellido != "" && afiliado.telefono != ""
               && afiliado.email != "")
            {
                validar += 1;
                return validar;
            }
            else
            {
                return validar;
            }

        }


        public static int Agregar(Afiliado afiliado)
        {
            int retorno = 0;
            if  (afiliado.cedula != "" && afiliado.telefono != "" && afiliado.apellido != "" && afiliado.telefono != "")
            {
                
                
        MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO afiliado(cedula, nombre, apellido, telefono, email) values ('{0}','{1}','{2}','{3}','{4}')",
            afiliado.cedula, afiliado.nombre, afiliado.apellido, afiliado.telefono, afiliado.email), Conexion.obtenerConexion());

             retorno = comando.ExecuteNonQuery();
        

             return retorno;


            }
            else
            {
                return retorno;
            }



        }
       
        
        //para llenar la grilla
        public static List<Afiliado> llenar()
        {
            List<Afiliado> llenar = new List<Afiliado>();


            MySqlCommand cm = new MySqlCommand(String.Format("SELECT * FROM afiliado"), Conexion.obtenerConexion());
            MySqlDataReader dt = cm.ExecuteReader();
            while (dt.Read())
            {
                Afiliado afiliados = new Afiliado();
               
                afiliados.cedula = dt.GetString(0);
                afiliados.nombre = dt.GetString(1);
                afiliados.apellido = dt.GetString(2);
                afiliados.telefono = dt.GetString(3);
                afiliados.email = dt.GetString(4);

                llenar.Add(afiliados);
            }
            return llenar;

        }
    public static int Eliminar(Afiliado afiliado)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM afiliado WHERE cedula='{0}'",afiliado.cedula), Conexion.obtenerConexion());

            retorno = comando.ExecuteNonQuery();

            return retorno;

        }
    public static int Modificar(Afiliado afiliado)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("Update afiliado set nombre='{0}',apellido='{1}',telefono'{2}',email='{3} where cedula ='{4}'",
            afiliado.nombre, afiliado.apellido, afiliado.telefono, afiliado.email,afiliado.cedula), Conexion.obtenerConexion());

            retorno = comando.ExecuteNonQuery();


            return retorno;
        }
      

    }
}





