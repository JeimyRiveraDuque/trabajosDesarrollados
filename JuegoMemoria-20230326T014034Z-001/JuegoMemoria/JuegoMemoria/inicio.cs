using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoMemoria
{
    public partial class Form2 : Form
    {
        string[] niveles = { "Facil", "Normal", "Dificil" };
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Facil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En este nivel tendras 3 minutos para completar el juego, si estas listo preciona 'Aceptar'");
            using (Facil ventanajuego = new Facil(nombre.Text))
                ventanajuego.ShowDialog();
        }

      
        private void nombre_TextChanged(object sender, EventArgs e)
        {
            ControlBotones();
    
        }
        private void ControlBotones()
        {
            if (nombre.Text.Trim() != string.Empty && nombre.Text.All(Char.IsLetter))
            {
                Facil.Enabled = true;
                Normal.Enabled = true;
                Dificil.Enabled = true;
                errorProvider1.SetError(nombre, "");
            }
            else
            {
                if (!(nombre.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(nombre, "El nombre debe sólo contener letras");
                }
                else
                {
                    errorProvider1.SetError(nombre, "Debe introducir su nombre");
                }

                Facil.Enabled = false;
                Normal.Enabled = false;
                Dificil.Enabled = false;
                nombre.Focus();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Facil.Enabled = false;
            Normal.Enabled = false;
            Dificil.Enabled = false;
        }

        private void Normal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En este nivel tendras 1 minutos con 50 segundos para completar el juego, si estas listo preciona 'Aceptar'");
            using (Normal ventanajuego = new Normal(nombre.Text))
                ventanajuego.ShowDialog();

        }

        private void Dificil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En este nivel tendras  30 segundos para completar el juego, si estas listo preciona 'Aceptar'");
            using (Dificil ventanajuego = new Dificil(nombre.Text))
                ventanajuego.ShowDialog();

        }
    }
}
