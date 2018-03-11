using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesos
{
    class Procesos
    {
        Random rnd;
        private int[] vec;

        public Procesos(int tam)
        {
            vec = new int[tam];
            rnd = new Random();
        }

        //public void Llenar()//pruebas
        //{
        //    for (int i = 0; i < vec.Length; i++)
        //    {
        //        vec[i] = i + 1;
        //    }
        //}

        public void Llenar(int lim)
        {
            for (int i = 0; i < vec.Length; i++)
            {
                vec[i] = rnd.Next(1, lim);
            }
        }

        public string Mostrar()
        {
            string vector = "";
            for (int i = 0; i < vec.Length; i++)
            {
                vector += vec[i] + " ";
            }
            return vector;
        }

        public string MostrarFCFS()
        {
            int suma = 0;
            string vector = "";
            int a = 0;


            for (int i = 0; i < vec.Length; i++)
            {

                a += vec[i];
                vector += a + " ";
            }
            String[] v = vector.Split(' ');
            for (int i = 0; i < vec.Length; i++)
            {
                int x = Convert.ToInt32(v[i]);
                suma += x;

            }
            double promedio = Convert.ToDouble(suma) / vec.Length;

            return "FCFS: 0 " + vector/*.tostring*/ + Environment.NewLine + "TR: " + promedio;
        }

        public string MostrarSJF()
        {
            Array.Sort(vec);
            string vector = "";
            int a = 0;
            int suma = 0;
            for (int i = 0; i < vec.Length; i++)
            {

                a += vec[i];
                vector += a + " ";
            }

            String[] v = vector.Split(' ');
            for (int i = 0; i < vec.Length; i++)
            {
                int x = Convert.ToInt32(v[i]);
                suma += x;

            }
            double promedio = Convert.ToDouble(suma) / vec.Length;


            return "SJF: 0 " + vector + Environment.NewLine + "TR: " + promedio;
        }



        public string MostrarLJF()
        {
            Array.Reverse(vec);
            string vector = "";
            int a = 0;
            int suma = 0;
            for (int i = 0; i < vec.Length; i++)
            {

                a += vec[i];
                vector += a + " ";
            }
            String[] v = vector.Split(' ');
            for (int i = 0; i < vec.Length; i++)
            {
                int x = Convert.ToInt32(v[i]);
                suma += x;

            }
           double promedio = Convert.ToDouble(suma) / vec.Length;

            return "LJF: 0 " + vector + Environment.NewLine + "TR: " + promedio;
        }

        //public void OrdenarmM()
        //{
        //    for (int k = 0; k < vec.Length - 1; k++)
        //    {
        //        for (int f = 0; f < (vec.Length - 1) - k; f++)
        //        {
        //            if (vec[f] > vec[f + 1])
        //            {
        //                int aux;
        //                aux = vec[f];
        //                vec[f] = vec[f + 1];
        //                vec[f + 1] = aux;
        //            }
        //        }
        //    }

        //}




    }
}







