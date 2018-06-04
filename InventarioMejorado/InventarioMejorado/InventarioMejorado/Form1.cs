using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioMejorado
{
    public partial class Form1 : Form
    {
        Inventario inv = new Inventario();

        public Form1()
        {
            InitializeComponent();
        }



        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt16(txtCodigo.Text);
            string nombre = txtNombre.Text;
            double costo = Convert.ToInt16(txtCosto.Text);
            int cantidad = Convert.ToInt16(txtCant.Text);

            if (inv.posicionActual < inv.vec.Length)
            {

                inv.Agregar(new Producto(nombre, codigo, cantidad, costo));
            }

            else
                MessageBox.Show("El inventario está lleno");

            txtCant.Clear();
            txtCodigo.Clear();
            txtNombre.Clear();
            txtCosto.Clear();
            
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
                MessageBox.Show("Escriba el código de producto");
            else

                if (inv.Buscar(Convert.ToInt16(txtCodigo.Text)) == null)
                MessageBox.Show("No existe");
            else

                txtProducto.Text = inv.Buscar(Convert.ToInt16(txtCodigo.Text)).ToString();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
                MessageBox.Show("Escriba el código que desea eliminar");
            else
                if (inv.Buscar(Convert.ToInt16(txtCodigo.Text)) == null)
                MessageBox.Show("Inexistente");
            else
                inv.Eliminar(Convert.ToInt16(txtCodigo.Text));
            txtProducto.Text = inv.Mostrar();
        }

        private void btnReporte_Click_1(object sender, EventArgs e)
        {
            txtProducto.Text +=inv.Mostrar();
        }





        private void EsNumero(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Sólo Números");
                e.Handled = true;
            }
            else
                e.Handled = false;
           
        }
    }
}
