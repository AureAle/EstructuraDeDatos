using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Producto
    {
        private string nombre;
        private int codigo;
        private int cantidad;
        private double costo;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Costo { get => costo; set => costo = value; }

        public Producto(string nombre, int codigo, int cantidad, double costo)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.cantidad = cantidad;
            this.costo = costo;

        }

        public override string ToString()
        {
            string producto = "Código: " + codigo.ToString() + Environment.NewLine + "Nombre: " +
                nombre + Environment.NewLine + "Cantidad: " + cantidad + Environment.NewLine +
                "Precio: $" + costo;

            return producto;
                            
        }
    }
}
