using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coladera
{
    class Coladera
    {
        static  int[] vec;

        public Coladera(int tamaño)
        {
            vec = new int[tamaño];

            for (int i = 0; i < vec.Length; i++)//llenar
            {
                vec[i] = i + 2;

            }
        }

        public string Colar()
        {
            string a = "";
            bool[] marcado = new bool[vec.Length + 1];//marcador true false

            for (int i = 2; i <= Math.Sqrt(vec.Length); i++)
            {
                if (marcado[i] == false)//si  no está marcado
                    for (int j = i * 2; j <= vec.Length; j += i)
                        marcado[j] = true;//se marcan los que no son primos que 
                                          //serían múltiplos del que se analiza
            }

            for (int i = 2; i < marcado.Length; i++)
            {
                if (marcado[i] == false)//los primos son los que no se marcaron
                    a += i.ToString() + ", ";
            }
            return a;
        }



            public  string Mostrar()
        {
            
            string a = "";


            for (int i = 0; i < vec.Length; i++)
            {
                
                 a +=vec[i].ToString() + Environment.NewLine;
               
            }
            return a;
        }


    }
}
