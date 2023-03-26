using EPSLaUltimaMorada.Controladores;
using EPSLaUltimaMorada.Modelos;
using MySql.Data.MySqlClient;
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
    public partial class Afiliados : Form
    {
        public Afiliados()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Afiliado afiliado = new Afiliado();//se crea un objeto de tipo afiliado al cual le asignamos las ropiedades que tenemos en la caja de texto
            afiliado.cedula = txtcedula.Text.Trim();
            afiliado.nombre = txtnombre.Text.Trim();
            afiliado.apellido = txtapellido.Text.Trim();
            afiliado.telefono = txttelefono.Text.Trim();
            afiliado.email = txtemail.Text.Trim();
           
            

            int resultado = AfiliadoController.Agregar(afiliado);

            if (resultado > 0)
            {
                
                
                    MessageBox.Show("El afiliado se agrego correctamente");

                    dataGridView1.DataSource = AfiliadoController.llenar();
                    Limpiar();
                
               
            }
            else
            {
                MessageBox.Show("El afiliado no se agrego correctamente, por favor llene todos los campos necesarios");
            }

        }
        void Limpiar()
        {
          
           txtcedula.Clear();
           txtnombre.Clear();
           txtapellido.Clear();
           txttelefono.Clear();
           txtemail.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea canselar?",
                               "Mensaje",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Limpiar();
            }
        }
        



        private void btnConsultar_Click(object sender, EventArgs e)
        {
           
        }

        private void Afiliados_Load(object sender, EventArgs e)
        {

           
            dataGridView1.DataSource = AfiliadoController.llenar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                txtcedula.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtnombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtapellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txttelefono.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtemail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            }
            catch
            {

            }
        }
       
        private void btneliminar_Click(object sender, EventArgs e)
        {

            Afiliado afiliado = new Afiliado();
            afiliado.cedula = txtcedula.Text.Trim();

            

            DialogResult resul = MessageBox.Show("Seguro que quiere eliminar el Registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)

                {
                    int resultado = AfiliadoController.Eliminar(afiliado);
                    if (resultado > 0)
                        {
                   

                        MessageBox.Show("El afiliado se elimino correctamente");
                            Limpiar();
                            dataGridView1.DataSource = AfiliadoController.llenar();
                        }
                }
                else  if (resul == DialogResult.No)
                {
                    Limpiar();
                MessageBox.Show("El afiliado no se elimino correctamente");
            }
           
                

           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Afiliado afiliado = new Afiliado();//se crea un objeto de tipo afiliado al cual le asignamos las ropiedades que tenemos en la caja de texto
           
            afiliado.nombre = txtnombre.Text.Trim();
            afiliado.apellido = txtapellido.Text.Trim();
            afiliado.telefono = txttelefono.Text.Trim();
            afiliado.email = txtemail.Text.Trim();
            afiliado.cedula = txtcedula.Text.Trim();



            DialogResult resul = MessageBox.Show("desa modificar el registro?", "modificar Registro", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)

            {

                int resultado = AfiliadoController.Modificar(afiliado);
                if (resultado > 0)
                {


                    MessageBox.Show("El afiliado se modifico correctamente");
                    Limpiar();
                    dataGridView1.DataSource = AfiliadoController.llenar();
                }
            }
            else if (resul == DialogResult.No)
            {
                Limpiar();
                MessageBox.Show("El afiliado no se modifico correctamente");

            }

            




        }
    }
}



