using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Form1 : Form
    {
        Inventario inv = new Inventario();
        public Form1()
        {
            
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt16(txtCodigo.Text);
            string nombre = txtNombre.Text;
            double costo = Convert.ToInt16(txtCosto.Text);
            int cantidad = Convert.ToInt16(txtCant.Text);

            if (inv.posicionActual < inv.vec.Length)

                inv.Agregar(new Producto(nombre, codigo, cantidad, costo));
            
            else
                MessageBox.Show("El inventario está lleno");

            txtCant.Clear();
            txtCodigo.Clear();
            txtNombre.Clear();
            txtCosto.Clear();

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            txtProducto.Text = inv.Mostrar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            

            if (txtCodigo.Text == "")
                MessageBox.Show("Escriba el código de producto");
            else

                if(inv.Buscar(Convert.ToInt16(txtCodigo.Text))== null)
                MessageBox.Show("No existe");
            else

            txtProducto.Text = inv.Buscar(Convert.ToInt16(txtCodigo.Text)).ToString();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt16(txtCodigo.Text);
            string nombre = txtNombre.Text;
            double costo = Convert.ToDouble(txtCosto.Text);
            int cantidad = Convert.ToInt16(txtCant.Text);
            int posicion = Convert.ToInt16(txtPosicion.Text);

            if (txtCodigo.Text == "" || txtCosto.Text == "" || txtNombre.Text == "" || txtCant.Text == "" || txtPosicion.Text == "") {
                MessageBox.Show("Ingrese el nuevo producto y posición");
                txtPosicion.Clear(); }

            else if (posicion > inv.vec.Length || posicion <= 0) { 
            MessageBox.Show("No se encuentra esta posición");
            txtPosicion.Clear(); }
            
            else
            if (inv.posicionActual < inv.vec.Length  )
            {
                

                inv.Insertar(new Producto(nombre, codigo, cantidad, costo), Convert.ToInt16(txtPosicion.Text));
                txtProducto.Text = inv.Mostrar();
            }
           
            txtCant.Clear();
            txtCodigo.Clear();
            txtNombre.Clear();
            txtCosto.Clear();
            txtPosicion.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
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
    }
}
