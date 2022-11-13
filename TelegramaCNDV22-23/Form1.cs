using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelegramaCNDV22_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bCalcularCNDV_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 1;
            double coste;
            int i = 0;
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;

            while (i <= textoTelegrama.Length - 1)
            {
                if (textoTelegrama[i] == ' ')
                {
                    numPalabras++;
                }
                i++;
            }

            // telegrama urgente?
            if (cbUrgente.Checked)
                tipoTelegrama = 'u';
            //Obtengo el número de palabras que forma el telegrama
            //x numPalabras = textoTelegrama.Length;
            //Si el telegrama es ordinario
            if (!cbUrgente.Checked) // codigo añadido para detectar un telegrama ordinario
                tipoTelegrama = 'o';
            if (tipoTelegrama == 'o')
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 2.5 + 0.5 * (numPalabras - 10);
            else
            //Si el telegrama es urgente
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;

                else
                    coste = 5 + 0.75 * (numPalabras - 10);

            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}
    

