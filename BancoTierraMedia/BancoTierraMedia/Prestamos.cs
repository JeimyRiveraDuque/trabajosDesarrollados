using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoTierraMedia
{
    public partial class Prestamos : Form
    {
        string nombre_cliente;
        string[] raza_disponibles = { "Balrog", "Drúedain", "Enano", "Elfo", "Ent", "Goblin", "Hobbit", "Hombre", 
            "Istari (Mago)", "Orco", "Troll", "Uruk-hai" };
        int[] cuotas_disponibles = { 12, 24, 36, 60, 120, 180, 240};
        string[] lugares_disponibles;
        Dictionary<int, double> Interases_bases;


        public Prestamos(string nombre)
        {
            InitializeComponent();
            nombre_cliente = nombre;

            string listado_ciudades = Properties.Resources.lugares_text.ToString();
            lugares_disponibles = listado_ciudades.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            Interases_bases = new Dictionary<int, double>();
            int i;
            double interes;
            for (i = 0, interes = 3.0; i < cuotas_disponibles.Length; i++, interes += 0.5)
            {
                Interases_bases[cuotas_disponibles[i]] = interes;
            }
        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            popularCuotas();
            popularRazas();
            popularCiudades();
            saludo.Text += nombre_cliente;

        }

        void popularCuotas()
        {
            for (int i = 0; i < cuotas_disponibles.Length; i++)
            {
                cuotas.Items.Add(cuotas_disponibles[i]);
            }

        }
        void popularRazas()
        {
            for (int i = 0; i < raza_disponibles.Length; i++)
            {
               raza.Items.Add(raza_disponibles[i]);
            }

        }
        void popularCiudades()
        {
            for (int i = 0; i < lugares_disponibles.Length; i++)
            {
                lugares.Items.Add(lugares_disponibles[i]);
            }

        }

        private void volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        double calcularIntereces()
        {
            int cuotas_pedidas = (int)cuotas.SelectedItem;
            string raza_seleccionada = raza.SelectedItem.ToString().ToLower();
            string luagar_seleccionado = lugares.SelectedItem.ToString().ToLower();
            double interes = Interases_bases[cuotas_pedidas];
            if (new[] { "orco", "uruk-hai", "goblin", "troll", "balrog" }.Contains(raza_seleccionada)) 
            {

                interes += 0.3;
            }
            if (new[] { "rivendell", "tirion", "valinor", "hobbiton", "bree", "gondor" }.Contains(luagar_seleccionado))
            {
                interes -= 0.3;
            }
            return interes;


        }

        private void bntConfirmarSolicitud_Click(object sender, EventArgs e)
        {
            switch (validaciones())
            {
                case 0:{
                        errorProvider1.SetError(Datospersonales, "");
                        errorProvider1.SetError(Detallesprestamo, "");
                        double interes_mensual = calcularIntereces();
                        double monto_pedido = double.Parse(montoprestamo.Text);
                        int cuotas_pedidas = (int)cuotas.SelectedItem;
                        double interes_total = monto_pedido * (interes_mensual / 100) * cuotas_pedidas;
                        double monto_a_pagar = monto_pedido + interes_total;
                        string mensaje = "Su préstamo por " + monto_pedido + " en " + cuotas_pedidas + " cuotas se concederá con un interés del " + interes_mensual + "% mensual.\nEl monto final asciende a " + monto_a_pagar;
                        MessageBoxButtons botones = MessageBoxButtons.OK;
                        MessageBox.Show(mensaje, "Cálculo de intereses", botones);
                        break;


                   }
                case 1:
                    {
                        errorProvider1.SetError(Detallesprestamo, "Debe completar todos los datos personales");
                        errorProvider1.SetError(Datospersonales, "");
                        break;
                    }
                case 2:
                    {
                        errorProvider1.SetError(Detallesprestamo, "Debe ingresar un monto numérico y una cantidad de cuotas");
                        errorProvider1.SetError(Datospersonales, "");
                        break;
                    }
            }

            int validaciones()
            {
                if ((raza.SelectedIndex <= -1) || (lugares.SelectedIndex <= -1))
                {
                    return 1;
                }
                else
                {
                    if (!(montoprestamo.Text.All(Char.IsDigit)) || (montoprestamo.Text == "") || (cuotas.SelectedIndex <= -1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            
        }

        private void lugares_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
