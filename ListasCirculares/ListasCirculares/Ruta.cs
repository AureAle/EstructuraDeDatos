using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares
{
    class Ruta
    {
        Base primero, ultimo, temp, encontrado;

        public Ruta()
        {
            primero = null;
        }

        public void AgregarFin(Base nuevo)//agrega al final
        {
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
                primero.Siguiente = nuevo;
                primero.Anterior = nuevo;

            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Anterior = ultimo;
                nuevo.Siguiente = primero;
                ultimo = nuevo;
                primero.Anterior = ultimo;
                
            }
        }

        private void AgregarIncio(Base nuevoInicio)
        {
            if (primero == null)
            {
                primero = nuevoInicio;
                ultimo = nuevoInicio;

            }
            else
            {
                primero.Anterior = nuevoInicio;
                ultimo.Siguiente = nuevoInicio;
                nuevoInicio.Siguiente = primero;
                nuevoInicio.Anterior = ultimo;
                primero = nuevoInicio;
            }
        }

        public Base Buscar(string nombre)
        {
            temp = primero; ;
            encontrado = null;

            if (ultimo.Nombre == nombre)
                encontrado = ultimo;
            else
                while (encontrado == null && temp != primero.Anterior)
                    if (temp.Nombre == nombre)
                    { encontrado = temp; }
                    else { temp = temp.Siguiente; }
            return encontrado;
        }

        public Base Eliminar(string nombre)
        {
            if (Buscar(nombre) != null)
            {
                if (encontrado == primero)
                    EliminarInicio();
                if (encontrado == ultimo)
                    EliminarUltimo();
                else
                {
                    encontrado.Anterior.Siguiente = encontrado.Siguiente;
                    encontrado.Siguiente.Anterior = encontrado.Anterior;
                }
            }
            Console.WriteLine(encontrado);
            return encontrado;
        }

        public Base EliminarInicio()
        {
            temp = primero;
            if (primero != null)
                if (ultimo == primero)
                {
                    primero = null;
                    ultimo = null;
                }
                else
                {
                    primero = primero.Siguiente;
                    primero.Anterior = ultimo;
                    ultimo.Siguiente = primero;
                }
            Console.WriteLine(temp);
            return temp;


        }

        public Base EliminarUltimo()
        {
            temp = ultimo;
            if (primero != null)
            {
                if (ultimo == primero)
                {
                    
                    primero = null;
                    ultimo = null;
                    
                }

                else
                {
                    ultimo = ultimo.Anterior;
                    ultimo.Siguiente = primero;
                    primero.Anterior = ultimo;
                }
            }
            Console.WriteLine(temp);
            return temp;
        }

        public void Insertar(Base nueva, int pos)
        {
            
            if (pos == 1)
                AgregarIncio(nueva);
            else
            {
                temp = primero;
                for(int i = 1; i < pos - 1; i++)
                {
                    temp = temp.Siguiente;
                }
                
                    nueva.Siguiente = temp.Siguiente;
                    nueva.Anterior = temp;                   
                    temp.Siguiente.Anterior = nueva;
                    temp.Siguiente = nueva;                      
            }
        }

        public string Recorrido(string nombre, DateTime horaInicio, DateTime horaFin)
        {
            if (Buscar(nombre) == null)
                return "No se encontró la base";
            else
            {
                DateTime horaActual = horaInicio;
                string ruta = "";
                temp = encontrado;

                while(temp.Siguiente!= encontrado)
                {
                    ruta += temp.Nombre.ToString() + "           ";
                    temp = temp.Siguiente;
                }
                if (temp != null)
                    ruta += temp.Nombre.ToString() + Environment.NewLine;

                temp = encontrado;

                while (horaActual <= horaFin)
                {
                    temp = temp.Siguiente;
                    ruta += horaActual.Hour.ToString() + ":" + horaActual.Minute.ToString() + "           ";
                    horaActual = horaActual.AddMinutes(temp.Minutos);

                    if (temp == encontrado)
                        ruta += Environment.NewLine;
                }
                return ruta;
            }
        }

        public string Mostrar()
        {
            string Base = "";
            temp = primero;

            while (temp != ultimo)
            {
                Base += temp.ToString();
                temp = temp.Siguiente;
            }

            if (temp != null)
            {
                Base += temp.ToString();
                temp = temp.Siguiente;
            }


            return Base;
        }

        /* - private agregar(n,r){
         * si n<r 
         *    si r.izq es nula
         *     r.izq = nuevo;
         *    si no 
         *     agregar(n,r.izq)
         * }
         */ 
    }
}
