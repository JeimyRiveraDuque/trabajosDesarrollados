using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EPSLaUltimaMorada.Vista
{
    public partial class FromMenu : Form
    {
        
        public FromMenu()

        {
            InitializeComponent();
           

            

        }
        private void permisoMedico()
        {
            btnafiliado.Visible = false;
            btnbeneficiario.Visible = false;
            btncitas.Visible = false;
            btnmedico.Visible = false;
            pbAfiliado.Visible = false;
            pbBeneficiario.Visible = false;
            pbcita.Visible = false;
            pbMedico.Visible = false;
        }


        private void btncitas_Click(object sender, EventArgs e)
        {
            using (citas ventanacitas = new citas())
                ventanacitas.ShowDialog();
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            using (Reporte ventanareporte = new Reporte())
                ventanareporte.ShowDialog();
        }

        private void btnafiliado_Click(object sender, EventArgs e)
        {
            using (Afiliados ventanaafiliado = new Afiliados())
                ventanaafiliado.ShowDialog();
        }

        private void btnbeneficiario_Click(object sender, EventArgs e)
        {
            using (Beneficiario ventanabeneficiario = new Beneficiario())
                ventanabeneficiario.ShowDialog();
        }

        private void btnmedico_Click(object sender, EventArgs e)
        {
            using (medico ventanamedico = new medico())
                ventanamedico.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
