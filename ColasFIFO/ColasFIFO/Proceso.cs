using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasFIFO
{
    class Proceso
    {
        private int ciclo;
        private Proceso siguiente;
        static Random rnd = new Random();

        public int Ciclo { get => ciclo; set => ciclo = value; }
        internal Proceso Siguiente { get => siguiente; set => siguiente = value; }

        public Proceso()
        {
            siguiente = null;
            ciclo = rnd.Next(4, 15);
        }



    }
}
