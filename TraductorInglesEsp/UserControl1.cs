using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraductorInglesEsp
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void btnTraducir_Click(object sender, EventArgs e)
        {
            IDictionary<string, string> diccionario = new Dictionary<string,string>();
            diccionario.Add("Hi", "Hola");
            diccionario.Add("Bye", "Adios");
            diccionario.Add("How", "Como");
            diccionario.Add("Eat", "Comer");
            diccionario.Add("Sleep", "Dormir");
            diccionario.Add("Run", "Correr");
            diccionario.Add("Jump", "Saltar");
            diccionario.Add("Up", "Arriba");
            diccionario.Add("Left", "Izquierda");
            diccionario.Add("Back", "Detras");

            if (diccionario.ContainsKey(txtPalabra.Text))
            {
                lblTraduccion.Text = diccionario[txtPalabra.Text];
            }

        }
    }
}
