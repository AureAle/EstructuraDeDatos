using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadasOrdenadas
{
    class Producto
    {
        private int codigo;
        private int cantidad;
        private string nombre;
        private double costo;
        private Producto siguiente;
        private Producto anterior;

        public int Codigo { get => codigo; set => codigo = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Costo { get => costo; set => costo = value; }
        internal Producto Siguiente { get => siguiente; set => siguiente = value; }
        internal Producto Anterior { get => anterior; set => anterior = value; }

        public Producto(int codigo, string nombre, double costo, int cantidad)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.costo = costo;
            this.cantidad = cantidad;
            siguiente = null;


        }

        public override string ToString()
        {
            return "Código: " + codigo + " | " + "Nombre: " +
                nombre + " | " + "Precio: $" + costo + " | " +
                "Cantidad: " + cantidad;

        }
    }
}
