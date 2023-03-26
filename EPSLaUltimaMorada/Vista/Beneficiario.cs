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
    public partial class Beneficiario : Form
    {
        public Beneficiario()
        {
            InitializeComponent();
        }

        private void Beneficiario_Load(object sender, EventArgs e)
        {
            BeneficiarioController.llenrcombo(comboBox1);
            dataGridView1.DataSource = BeneficiarioController.llenar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //boton crear
        private void button1_Click(object sender, EventArgs e)
        {
            Beneficiarios beneficiario = new Beneficiarios();
            beneficiario.cedula = txtcedula.Text.Trim();
            beneficiario.nombre = txtnombre.Text.Trim();
            beneficiario.apellido = txtapellido.Text.Trim();
            beneficiario.telefono = txtapellido.Text.Trim();
            beneficiario.email = txtapellido.Text.Trim();
            beneficiario.afiliado = Convert.ToInt32(comboBox1.SelectedValue);

            int resultado = BeneficiarioController.Crear(beneficiario);

            if (resultado > 0)
            {
                MessageBox.Show("Se agrego correctamente");
                dataGridView1.DataSource = BeneficiarioController.llenar();
                limpiar();


            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Beneficiarios beneficiario = new Beneficiarios();
            beneficiario.cedula = txtcedula.Text.Trim();
            DialogResult resul = MessageBox.Show("Seguro que quiere eliminar el Registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)

            {
                int resultado = BeneficiarioController.eliminar(beneficiario);
                if (resultado > 0)
                {


                    MessageBox.Show("El beneficiario se elimino correctamente");
                    dataGridView1.DataSource = BeneficiarioController.llenar();
                    limpiar();


                }
            }
            else if (resul == DialogResult.No)
            {
             
                MessageBox.Show("El beneficiario no se elimino correctamente");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcedula.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtapellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txttelefono.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
        void limpiar()
        {
            txtcedula.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txttelefono.Clear();
            txtemail.Clear();
        }

 

        private void btnCanelar_Click_1(object sender, EventArgs e)
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
    }
}
