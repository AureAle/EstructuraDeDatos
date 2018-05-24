using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares
{
    class Base
    {
        private string nombre;
        private int minutos;
        private Base anterior;
        private Base siguiente;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Minutos { get => minutos; set => minutos = value; }
        internal Base Anterior { get => anterior; set => anterior = value; }
        internal Base Siguiente { get => siguiente; set => siguiente = value; }

        public Base (string nombre, int minutos)
        {
            this.nombre = nombre;
            this.minutos = minutos;
            anterior = null;
            siguiente = null;
        }

        public override string ToString()
        {
            return "Nombre: " + nombre +
                Environment.NewLine+ "Minutos: "+ minutos.ToString() + Environment.NewLine;
        }
    }
}
