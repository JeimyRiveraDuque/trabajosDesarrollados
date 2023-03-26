using EPSLaUltimaMorada.Controladores;
using EPSLaUltimaMorada.Modelos;
using EPSLaUltimaMorada.Vista;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class Inicio : Form

    {
       

        public Inicio()
        {
            InitializeComponent();


        }
        //Enviamos los parametros a la clase login



        private void btnIniciar_Click(object sender, EventArgs e)
        {
            

            //se crea un objeto de tipo afiliado al cual le asignamos las ropiedades que tenemos en la caja de texto
            String id, cedula, nombre;
            id = comboBox1.Text.Trim();
            
            nombre = txtNombre.Text.Trim();
            cedula = txtCedula.Text.Trim();


            login login = new login(id, nombre, cedula);


            int resultado = InicioController.ValidarUsuarioAdmistrador(login);

            if (resultado > 0)
            {
                MessageBox.Show("bienvenido");
                FromMenu from = new FromMenu();
                from.ShowDialog();
                
                
            }
            else
            {
                MessageBox.Show("herror");
            }
           

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = null;
            comboBox1.Items.Clear();
            InicioController.llenarcombo(comboBox1);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
