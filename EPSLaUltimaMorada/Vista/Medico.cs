using EPSLaUltimaMorada.Controladores;
using EPSLaUltimaMorada.Modelos;
using System;
using System.Windows.Forms;

namespace EPSLaUltimaMorada
{
    public partial class medico : Form
    {

        public medico()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MedicoController.llenrcombo(cbConsultorio);
            dataGridView1.DataSource = MedicoController.llenar();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico();
            medico.cedula = txtCedula.Text.Trim();
            medico.nombre = txtNombre.Text.Trim();
            medico.apellido = txtApellido.Text.Trim();
            medico.hora = txtHora.Text.Trim();
            medico.fecha = dtfecha.Value.Year + "/" + dtfecha.Value.Month + "/" + dtfecha.Value.Day;
            medico.consultorio = Convert.ToInt32(cbConsultorio.SelectedValue);

            int resultado = MedicoController.agregar(medico);

            if (resultado > 0)
            {
                MessageBox.Show("Se agrego correctamente");
                dataGridView1.DataSource = MedicoController.llenar();

            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCedula.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtHora.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dtfecha.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cbConsultorio.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
        void limpiar()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtHora.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea canselar?",
                               "Mensaje",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                limpiar();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico();
            medico.cedula = txtCedula.Text.Trim();



            DialogResult resul = MessageBox.Show("Seguro que quiere eliminar el Registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)

            {
                int resultado = MedicoController.Eliminar(medico);
                if (resultado > 0)
                {


                    MessageBox.Show("El afiliado se elimino correctamente");
                    limpiar();
                    dataGridView1.DataSource = MedicoController.llenar();
                }
            }
            else if (resul == DialogResult.No)
            {
                limpiar();
                MessageBox.Show("El medico no se elimino correctamente");
            }
        }
    }
}

