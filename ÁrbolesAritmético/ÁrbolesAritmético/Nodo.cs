using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÁrbolesAritmético
{
    class Nodo
    {
        private char dato;
        private Nodo siguiente;
        private Nodo anterior;
        private Nodo hizq;
        private Nodo hder;

        public char Dato { get => dato; set => dato = value; }
        internal Nodo Siguiente { get => siguiente; set => siguiente = value; }
        internal Nodo Anterior { get => anterior; set => anterior = value; }
        internal Nodo Hizq { get => hizq; set => hizq = value; }
        internal Nodo Hder { get => hder; set => hder = value; }

        public Nodo(char elemento)
        {
            dato = elemento;
            anterior = null;
            siguiente = null;
            Hizq = null;
            Hder = null;      

        }

        public override string ToString()
        {
          
            
            return "Dato: " + dato;
        }


    }
}
