using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TortugaDibujante
{
    public partial class Form1 : Form
    {
        Tortuga tor = new Tortuga();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tor.Llenar();
            txtPiso.Text = tor.Imprimir();
        }

        private void btnEstado1_Click(object sender, EventArgs e)
        {
            tor.SubirPluma();
        }

        private void btnEstado2_Click(object sender, EventArgs e)
        {
            tor.BajarPluma();
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            tor.Avanzar(Convert.ToInt16(txtPasos.Text));
            txtPiso.Text= tor.Imprimir();
            lblSentido.Text += tor.Sentido + " - " + tor.PosX + ", " + tor.PosY+ " ";
        }

        private void btnGirarIzq_Click(object sender, EventArgs e)
        {
            tor.Girarizquierda();
        }

        private void btnGirarDer_Click(object sender, EventArgs e)
        {
            tor.GirarDerecha();
        }
    }
}
