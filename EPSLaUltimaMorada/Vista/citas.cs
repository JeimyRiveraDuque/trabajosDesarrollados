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
    public partial class citas : Form
    {
        public citas()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void citas_Load(object sender, EventArgs e)
        {
          
            CitaController.llenar(Cbmedico,txtconsultorio,txtfecha);
        }

        private void Cbmedico_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            Cita cita = new Cita();

            cita.cedula = txtcedula.Text.Trim();
            cita.nombre_medico = Convert.ToInt32(Cbmedico.SelectedValue);
            cita.nombre_paciente = txtnombre.Text.Trim();
            cita.estado = txtestado.Text.Trim();
            cita.hora = txthora.Text.Trim();
            cita.fecha = txtfecha.Text.Trim();
            cita.consultorio = txtconsultorio.Text.Trim();
            

            int resultado = CitaController.agregarcita(cita);

            if(resultado > 0)
            {
                MessageBox.Show("se creo la cita");
            }
            else
            {
                MessageBox.Show("No se creo la cita");
            }
        }
    }
}
