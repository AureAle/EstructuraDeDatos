using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasCirculares
{
    public partial class Form1 : Form
    {
       Ruta ruta = new Ruta();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarFin_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtMinutos.Text == "")
                MessageBox.Show("Hay campos vacíos");
            else
                ruta.AgregarFin(new Base(txtNombre.Text, Convert.ToInt16(txtMinutos.Text)));

           Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            if (txtNombre.Text == "")
                MessageBox.Show("Escriba el nombre de la base a buscar");
            else
                if (ruta.Buscar(nombre) == null)
                MessageBox.Show("La base no existe");
            else
            txtRutas.Text =ruta.Buscar(nombre).ToString();

            Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
                MessageBox.Show("Escriba el nombre de la base a eliminar");
            else if (ruta.Buscar(txtNombre.Text) == null)
                MessageBox.Show("La base no existe.");
            else
            {
                ruta.Eliminar(txtNombre.Text);
                txtRutas.Text = ruta.Mostrar();
            }                
               

            Clear();
        }

        private void btnEliminarFin_Click(object sender, EventArgs e)
        {
            
           
            ruta.EliminarUltimo();
            txtRutas.Text = ruta.Mostrar();
            
            Clear();
        }

        private void btnEliminarInicio_Click(object sender, EventArgs e)
        {
            ruta.EliminarInicio();
            txtRutas.Text = ruta.Mostrar();

            Clear();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int pos = Convert.ToInt16(txtPos.Text);
            if (txtNombre.Text == "" || txtMinutos.Text == "" || txtPos.Text == "")
                MessageBox.Show("Hay campos vacíos");
            else
                ruta.Insertar(new Base(txtNombre.Text, Convert.ToInt16(txtMinutos.Text)), pos);

            Clear();
            txtRutas.Text = ruta.Mostrar();

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtRutas.Text += ruta.Mostrar() + Environment.NewLine;
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (txtBaseInicial.Text == "")
                MessageBox.Show("Inserta el nombre de la base por la que empezará el recorrido");
            else
                txtRutas.Text = ruta.Recorrido(txtBaseInicial.Text, dtpHoraInicio.Value, dtpHoraFin.Value);
        }

        private void Clear()
        {
            txtMinutos.Clear();
            txtNombre.Clear();
            txtPos.Clear();
        }

        
    }
}
