using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Inventario
    {

        public Producto[] vec = new Producto[15];
        public int posicionActual;
        

        public Inventario()
        {
            posicionActual = 0;
        }


        public void Agregar(Producto producto)
        {

            vec[posicionActual] = producto;
            posicionActual++;

        }


        public Producto Buscar(int codigoP)
        {
            for (int i = 0; i <posicionActual; i++)
            {
                if (vec[i].Codigo == codigoP)
                    return vec[i];


            }
           return null;
        }


        public void Eliminar(int codigoP)
        {

            for (int i = 0 ; i < posicionActual; i++)
            {          
                if(vec[i].Codigo== codigoP)
                 for(int j = i; j<posicionActual-1;j++)
                        vec[i] = vec[i + 1];
              
            }            
           vec[posicionActual - 1] = null;
            
            posicionActual--;
           
        }

        public void Insertar(Producto producto , int posicionInsertar)
        {
            //insertar y recorrer
            for (int i = posicionActual; i > posicionInsertar - 1; i--)
                vec[i] = vec[i - 1];
            vec[posicionInsertar - 1] = producto;
            posicionActual++;
        }

        public string Mostrar()
        {
            string producto = "";

            for (int i = 0; i < posicionActual; i++)
                producto += vec[i].ToString() + Environment.NewLine;

            return producto;
        }
    }
}
