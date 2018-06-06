using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÁrbolesAritmético
{
    class Funciones
    {

        Nodo primero, ultimo, temp; 
        string recorrido;


        public void Split(string funcion)
        {
            string[] cadena = new string[25];
            cadena = funcion.Split(' ');
            for(int i =0; i< cadena.Length; i++)
            {
                Nodo nuevo = new Nodo (Convert.ToChar(cadena[i]));
                AgregarLista(nuevo);
            }
            Arbol();
        } 

        public void AgregarLista(Nodo nuevo)
        {
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Anterior = ultimo;
                ultimo = nuevo;
            }
        }

        public void Arbol()
        {
            temp = primero;

            while (temp != null)
            {

                if (temp.Dato == '/' || temp.Dato == '*')
                {
                    temp.Hizq = temp.Anterior;
                    temp.Hder = temp.Siguiente;
                    Eliminar(temp.Anterior);
                    Eliminar(temp.Siguiente);

                }
                temp = temp.Siguiente;
            }
            temp = primero;
            while (temp != null)
            {
                if (temp.Dato == '+' || temp.Dato == '-')
                {
                    temp.Hizq = temp.Anterior;
                    temp.Hder = temp.Siguiente;
                    Eliminar(temp.Anterior);
                    Eliminar(temp.Siguiente);

                }
                temp = temp.Siguiente;

            }
        }      

        public Nodo Primero
        {
           get { return primero; }
        }

       public string Recorrido
        {
            get { return recorrido; }
            set { recorrido = value; }
        }
        public void PostOrder(Nodo primero)//IDR
        {
            
            if(primero!= null)
            {
                PostOrder(primero.Hizq); //hasta que primero = null ya baja
                PostOrder(primero.Hder);
                recorrido += primero.Dato;
            }
        }

        public void PreOrder(Nodo primero)//RID
        {
            if (primero != null)
            {
               
                recorrido += Convert.ToString(primero.Dato);
                PreOrder(primero.Hizq);
                PreOrder(primero.Hder);
            }
        }

        public string Mostrar()
        {
            return recorrido;
        }
        
        private void Eliminar(Nodo dato)
        {
            if (dato != primero)
            {
                dato.Anterior.Siguiente = dato.Siguiente;
                if (dato.Siguiente != null)
                {
                    dato.Siguiente.Anterior = dato.Anterior;
                    
                }
                else
                    ultimo = dato.Anterior;
            }
            else
            if (primero == ultimo)
                primero = ultimo = null;
            else
            {
                primero = primero.Siguiente;
                primero.Anterior = null;
            }
        }

    }
}
