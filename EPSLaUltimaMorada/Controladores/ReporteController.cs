using EPSLaUltimaMorada.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPSLaUltimaMorada.Controladores
{
    class ReporteController:Conexion
    {
        public static List<Reportes> llenar()
        {
            List<Reportes> llenar = new List<Reportes>();

            
            MySqlCommand cm = new MySqlCommand(String.Format("SELECT * FROM reporte"), Conexion.obtenerConexion());
            MySqlDataReader dt = cm.ExecuteReader();
            while (dt.Read())
            {
                Reportes datos = new Reportes();
                
                datos.cedula = dt.GetString(0);
                datos.estado_cita = dt.GetString(1);
                datos.observacion = dt.GetString(2);


                llenar.Add(datos);
            }
            return llenar;

        }
    }
}
