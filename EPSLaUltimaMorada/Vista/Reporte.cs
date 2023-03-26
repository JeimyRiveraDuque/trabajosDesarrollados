using EPSLaUltimaMorada.Controladores;
using EPSLaUltimaMorada.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPSLaUltimaMorada
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void dataGridreporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            dataGridreporte.DataSource = ReporteController.llenar();
        }
    }
}
