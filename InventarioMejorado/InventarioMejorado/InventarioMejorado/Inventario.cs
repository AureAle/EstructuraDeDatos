using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioMejorado
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
            //vec[posicionActual] = producto;
            //if (posicionActual > 0)
            //    Ordenar();
            //posicionActual++;

            if (posicionActual != 0)
                for (int i = 0; i < posicionActual; i++)
                {
                    if (producto.Codigo < vec[i].Codigo)
                        Insertar(producto, i);
                    else if (i == (posicionActual - 1))
                        vec[posicionActual] = producto;
                }
            else
                vec[posicionActual] = producto;
            posicionActual++;


            

        }

        private void Insertar(Producto pro, int posicion)
        {
            //insertarlo en la posicion

            for (int i = posicionActual; i > posicion; i--)
            {
                vec[posicionActual] = vec[posicionActual - 1];
                
            }
            vec[posicion] = pro;


        }

        //public void Ordenar()
        //{
        //    Producto producto;

        //    for (int i = 0; i < posicionActual; i++)
        //    {
        //        for (int j = 0; j < posicionActual-i; j++)

        //            if (vec[j].Codigo > vec[j+1].Codigo)
        //            {
        //                producto = vec[j];
        //                vec[j] = vec[j+1];
        //                vec[j+1] = producto;

        //            }
        //    }
        //}           


        public Producto Buscar(int codigoP)
        {
            //método de búsqueda binaria
            int i = 0;
            int j = posicionActual - 1;
            int k = 0;

            while(i<=j)
            {
                k = i + (j - i) / 2;
                if (vec[k].Codigo == codigoP)
                    return vec[k];
                else if (vec[k].Codigo < codigoP)
                    i = k + 1;
                else if (vec[k].Codigo > codigoP)
                    j = k - 1;
            }
            return null;
        }

        //privado Buscar que devuelva la posicion para ser implementado en eliminar 
        private int BuscarPos(int codigoP)
        {

            //método de búsqueda binaria
            int i = 0;
            int j = posicionActual - 1;
            int k = 0;

            while (i <=j)
            {
                k = i + (j - i) / 2;
                if (vec[k].Codigo == codigoP)
                    return posicionActual;
                else if (vec[k].Codigo < codigoP)
                    i = k + 1;
                else if (vec[k].Codigo > codigoP)
                    j = k - 1;
            }
            return -1;
        }



        public void Eliminar(int codigoP)
        {

            //eliminar usando la busqueda sin recorrerlo todo
            for (int j = BuscarPos(codigoP); j < posicionActual - 1; j++)
                if (vec[BuscarPos(codigoP)].Codigo == codigoP)

                    vec[j] = vec[j + 1];
            vec[posicionActual - 1] = null;
            posicionActual--;





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
