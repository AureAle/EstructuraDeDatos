using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÁrbolesAritmético
{
    public partial class Form1 : Form
    {
        Funciones arbol = new Funciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            arbol.Split(txtDatos.Text);

           
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            arbol.Recorrido = "";
            arbol.PostOrder(arbol.Primero);           
            txtResultado.Text = arbol.Mostrar() ;
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            arbol.Recorrido = "";
            arbol.PreOrder(arbol.Primero);
            txtResultado.Text = arbol.Mostrar();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
        }
    }
}
