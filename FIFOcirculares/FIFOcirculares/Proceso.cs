using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFOcirculares
{
    class Proceso
    {
        private int ciclo;
        private Proceso siguiente;
        private Proceso anterior;
        static Random rnd = new Random();

        public int Ciclo { get => ciclo; set => ciclo = value; }
        internal Proceso Siguiente { get => siguiente; set => siguiente = value; }
        internal Proceso Anterior { get => anterior; set => anterior = value; }

        public Proceso()
        {
            siguiente = null;
            anterior = null;
            ciclo = rnd.Next(4,14);
        }
    }
}
