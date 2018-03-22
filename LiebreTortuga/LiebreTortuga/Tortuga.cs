using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiebreTortuga
{
    class Tortuga : Corredor
    {
        
        public Tortuga(string nombre) : base(nombre)
        {

        }
        //        Tortuga ->
        //paso rapido 50% +3pasos
        //resbalon 20% -6 pasos
        //paso lento 30% +1 paso

        public int Avanzar()
        {
            int correr = Correr();
            if (correr<6)
            {
                posicion += 3;
                return 3;
            }
            if (correr > 5 && correr < 8)
            {
                posicion -= 6;
                return -6;
            }
            if (correr > 7)
            {
                posicion += 1;
                return 1;
            }
            return 1000;

        }
    }
}

