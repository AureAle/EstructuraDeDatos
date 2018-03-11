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
        private int[] _vec;

        public Procesos(int tam)
        {
            _vec = new int[tam];
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
            for (int i = 0; i < _vec.Length; i++)
            {
                _vec[i] = rnd.Next(1, lim);
            }
        }

        public int cmax()
        {
            int cmax = 0;
            for(int i = 0; i < _vec.Length; i++)
            {
                cmax += _vec[i];
            }
            return cmax;
        }

        public string Mostrar()
        {
            string vector = "";
            for (int i = 0; i < _vec.Length; i++)
            {
                vector += _vec[i] + " ";
            }
            return vector;
        }

        public string MostrarFCFS()
        {
            string vector = "";
            int a= 0;
            
            for (int i = 0; i < _vec.Length; i++)
            { 
                a += _vec[i];
                vector += a + " ";        
            }         
            return vector;
        }


        public string MostrarSJF()
        {
            Array.Sort(_vec);
            string vector ="";
            int a = 0;

            for (int i = 0; i < _vec.Length; i++)
            {

                a += _vec[i];
                vector += a + " ";
            }
            return vector;
        }



        public string MostrarLJF()
        {
            Array.Reverse(_vec);
            string vector ="" ;
            int a = 0;

            for (int i = 0; i < _vec.Length; i++)
            {

                a += _vec[i];
                vector += a + " ";
            }
            return  vector;
        }

        public double TimeEspera(string process)
        {
            int suma = 0;
            String[] v = process.Split(' ');
            for (int i = 0; i < _vec.Length-1; i++)
            {
                int x = Convert.ToInt32(v[i]);
                suma += x;

            }
            double promedio = Convert.ToDouble(suma) / _vec.Length;

            return promedio;
        }

        public double TimeRespuesta(string process)
        {
            int suma = 0;
            String[] v = process.Split(' ');
            for (int i = 0; i < _vec.Length; i++)
            {
                int x = Convert.ToInt32(v[i]);
                suma += x;

            }
            double promedio = Convert.ToDouble(suma) / _vec.Length;

            return promedio;
          
        }


        //public int Sumar()
        //{
        //    int suma = 0;
        //    for (int i = 0; i < vec.Length; i++)
        //    {
        //        suma += vec[i];
        //    }
        //    return suma;
        //}

        //public double Promedio()
        //{
        //    return (Convert.ToDouble(Sumar()) / vec.Length);
        //}

        //public void MostrarRRQ()
        //{

        //}

    }





}

