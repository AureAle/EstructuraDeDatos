using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiebreTortuga
{
    abstract class Corredor
    {
        protected string nombre;
        protected int posicion;
        private static Random rnd = new Random();

        public string Nombre { get => nombre; }
        public int Posicion { get => posicion; }

        public Corredor (string name)
        {
            nombre = name;
            posicion = 0;
        }

        public int Correr()
        {
            int random = rnd.Next(1, 11);
            return random;
        }

        public override string ToString()
        {
            return nombre + " está en " + posicion + Environment.NewLine;
        }
    }



}

