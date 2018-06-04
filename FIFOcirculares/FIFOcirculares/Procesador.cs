using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFOcirculares
{
    class Procesador
    {
        Proceso primero, ultimo, temp;

        public Procesador()
        {
            primero = null;
            ultimo = null;
        }

        public void enQueue(Proceso nuevoP)//agregar proceso a la cola
        {
            if (primero == null)
            {
                primero = nuevoP;
                ultimo = nuevoP;
                primero.Siguiente = nuevoP;
                primero.Anterior = nuevoP;

            }
            else
            {
                ultimo.Siguiente = nuevoP;
                nuevoP.Anterior = ultimo;
                nuevoP.Siguiente = primero;
                primero.Anterior = nuevoP;
                primero = nuevoP;//que siempre el que llegue sea el nuevo primero
                
            }
        }

        public Proceso deQueue()//sacar de la cola
        {

            if (primero == null)
                return null;


            else if (primero.Siguiente==primero )
            {
                temp = primero;
                primero = ultimo = null;
                
                return temp;
               
            }
            temp = primero;

                primero = primero.Siguiente;
                primero.Anterior = ultimo;               
                ultimo.Siguiente = primero;
                
                  
            return temp;

        }

        public void Avanzar()
        {
            if (primero!=null)
                primero = primero.Siguiente;
        }

        public Proceso Peek()//ver proceso actual
        {
            return primero;
        }

        public string Pendientes()
        {
            int procPen = 0;
            int sumaCiclosPen = 0;
            temp = primero;

            if(primero != null)
            do
            {
                sumaCiclosPen += temp.Ciclo;
                procPen++;
                temp = temp.Siguiente;

            } while (temp != ultimo);//valida si temp es dif del ultimo y al hacer el recorrido no lo toma 2 veces

                string pendientes = "Procesos pendientes: " + procPen + Environment.NewLine +
                "Suma de los ciclos pendientes: " + sumaCiclosPen;

            return pendientes;
        }
    }
}
