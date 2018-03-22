using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiebreTortuga
{
    public partial class Form1 : Form
    {
        
        Liebre liebre;
        Tortuga tortuga;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCorrer_Click(object sender, EventArgs e)
        {
            liebre = new Liebre("Liebre");
            tortuga = new Tortuga("Tortuga");

            do
            {
                liebre.Avanzar();
                tortuga.Avanzar();

                txtCarrera.Text += liebre.ToString() + tortuga.ToString();
            } while (liebre.Posicion < 80 && tortuga.Posicion < 80);

            if (tortuga.Posicion > 80 && liebre.Posicion > 80)
                txtCarrera.Text += "Empate";

            if (tortuga.Posicion >= 80 && liebre.Posicion < 80) { txtCarrera.Text += tortuga.Nombre + " ha ganado!"; }
            if (liebre.Posicion >= 80 && tortuga.Posicion < 80) { txtCarrera.Text += liebre.Nombre + " ha ganado!"; }

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtCarrera.Clear();
        }
    }
}
