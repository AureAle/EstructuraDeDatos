using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dados
{
    public partial class Form1 : Form
    {
        Dado dado = new Dado();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            int[] cara = new int [6];
            for (int i = 0; i < 100; i++)
            {
                int d = dado.Lanzar();
                //txtDados.Text += d + Environment.NewLine;
                cara[d - 1]++; 
                                               
            }

            for(int i = 0; i < 6; i++)
            {
                txtDados.Text += "[" + (i + 1) + "]:" + cara[i]+Environment.NewLine;
            }
        }

        private void btnLanzarSuma_Click(object sender, EventArgs e)
        {
            int[] cara = new int[11];
            for (int i = 0; i < 100; i++)
            {
                int d = dado.Lanzar()+ dado.Lanzar();
                //txtDados.Text += d + Environment.NewLine;
               
                cara[d - 2]++;

            }

            for (int i = 0; i <11; i++)
            {
               txtDados.Text += "[ " + (i+2) + " ]:" + cara[i] + Environment.NewLine;
            }
        }
    }
}




