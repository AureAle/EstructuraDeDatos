using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiebreTortuga
{
    class Liebre : Corredor
    {
        public Liebre(string nombre) : base(nombre)
        {
            

        }

        //Liebre
        //domir 20% 0 avance
        //salto grande 20% +9 pasos
        //resbalon grande 10 -12 pasos
        //salto pequeño 30 % +1 paso
        //resbalon pequeño 20% -2 pasos

        public int Avanzar()
        {
            int correr = Correr();
            if (correr<3)//coratzon
            {
                
                return 0;
            }
            if (correr > 2 && correr < 5)
            {
                posicion += 9;
                return 9;
            }
            if (correr > 5 && correr<9)
            {
                posicion += 1;
                return 1;
            }
            if (correr == 5)
            {
                posicion -= 12;
                return -12;
            }
            if (correr>8 )
            {
                posicion -= 2;
                return -2;
            }

            return 1000;
        }
    }
}
