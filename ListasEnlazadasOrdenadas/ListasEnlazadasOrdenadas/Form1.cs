using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasEnlazadasOrdenadas
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
            if (Vacio())
                MessageBox.Show("Favor de llenar los campos incompletos. Gracias.");

            int codigo = Convert.ToInt16(txtCodigo.Text);
            string nombre = txtNombre.Text;
            double costo = Convert.ToDouble(txtCosto.Text);
            int cantidad = Convert.ToInt16(txtCant.Text);

            if (inv.Buscar(codigo) != null)
                MessageBox.Show("Producto ya existente.");

            inv.Agregar(new Producto(codigo, nombre, costo, cantidad));
            Clear();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtLista.Text += inv.Listar();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
                MessageBox.Show("Escriba el código");
            else
                if (inv.Buscar(Convert.ToInt16(txtCodigo.Text)) == null)
                MessageBox.Show("El producto no existe.");
            else
                txtLista.Text = inv.Buscar(Convert.ToInt16(txtCodigo.Text)).ToString();
            Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
                MessageBox.Show("Escriba el código");
            else
            {
                if (inv.Eliminar(Convert.ToInt16(txtCodigo.Text)))
                {

                    txtLista.Text = inv.Listar();
                }
                else
                    MessageBox.Show("El producto no existe");
            }
            Clear();
        }
    

        private void btnBorarInicio_Click(object sender, EventArgs e)
        {
            inv.EliminarInicio();
            txtLista.Text = inv.Listar();
        }

        private void btnBorrarUltimo_Click(object sender, EventArgs e)
        {
            inv.EliminarUltimo();
            txtLista.Text = inv.Listar();
        }

        public void Clear()
        {
            txtCodigo.Clear();
            txtCosto.Clear();
            txtNombre.Clear();
            txtCant.Clear();
        }

        private void btnListarInverso_Click(object sender, EventArgs e)
        {
            txtLista.Text = inv.Inverso();
        }

        public bool Vacio()
        {
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtCosto.Text == "" || txtCant.Text == "")
                return true;
            else
                return false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLista.Clear();
        }
    }
}
