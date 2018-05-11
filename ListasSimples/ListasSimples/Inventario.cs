using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasSimples
{
    class Inventario
    {
        Producto ultimo, primero, anterior, encontrado, temp;

        public Inventario()
        {
            primero = null;
        }

        public void Agregar(Producto nuevoP)
        {
            if (primero == null)
            {
                primero = nuevoP;
                ultimo = nuevoP;
            }
            else
            {               
               ultimo.Siguiente = nuevoP;
               ultimo = nuevoP;                                 
            }
        }

        public void AgregarInicio(Producto PInicio)
        {
            if (primero == null)
            {
                primero = PInicio;
                ultimo = PInicio;
            }
            else
            {
                PInicio.Siguiente = primero;
                primero = PInicio;
            }

        }

        public Producto Buscar(int codigoP)
        {
            temp = primero;
            encontrado = null;

            while (encontrado == null && temp != null)
                if (temp.Codigo == codigoP)
                    encontrado = temp;
                else
                {
                    anterior = temp;
                    temp = temp.Siguiente;

                }
            return encontrado;

        }

        public bool Eliminar(int codigoP)
        {
            if (Buscar(codigoP) != null)
            {
                if (encontrado == primero)
                    primero = primero.Siguiente;
                else
                    anterior.Siguiente = encontrado.Siguiente;
                return true;
            }
            else return false;
        } 

        public void EliminarInicio()
        {
            if (primero != null)
            {
                primero = primero.Siguiente;
                
            }
            
        }

        public void EliminarUltimo()
        {
            temp = primero;

            if (primero == ultimo)
            {
                primero = null;
            }
            else
            { 
                while (temp.Siguiente.Siguiente != null)//mientras que su sig sea dif de null (obtiene el anterior)
                    temp = temp.Siguiente;
            }
            temp.Siguiente = null;
      
        }

        public void Insertar(Producto nuevo, int posIns)
        {
            Producto t, t2;
            if (primero == null)
                primero = nuevo;
            else if (posIns == 1)
            {
                nuevo.Siguiente = primero;
                primero = nuevo;
            }
            else
            {
                t = primero;
                for (int i = 1; i < posIns - 1; i++)
                {
                    t = t.Siguiente;

                }
                t2 = t.Siguiente;
                t.Siguiente = nuevo;
                t.Siguiente.Siguiente = t2;
            }
        }
            
        public string Listar()
        {
            string producto = "";
            temp = primero;

            while (temp != null)
            {
                producto += temp.ToString() + Environment.NewLine;
                temp = temp.Siguiente;
            }
            return producto;
        }

        public string Inverso()
        {
            return ListarInverso(primero);
        }

        public string ListarInverso(Producto temp)
        {
            string producto = "";

            if (temp.Siguiente != null)
                producto = ListarInverso(temp.Siguiente);

            producto += temp.ToString() + Environment.NewLine;
            return producto;
        }

        public void Invertir()
        {
            Producto t2;
            temp = primero;

            while (temp.Siguiente != null)
            {
                t2 = temp.Siguiente;
                temp.Siguiente=t2.Siguiente;
                t2.Siguiente = primero;
                primero = t2;
            } 
                ultimo = temp;


        }
    }
}
