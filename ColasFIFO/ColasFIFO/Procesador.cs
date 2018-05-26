using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasFIFO
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
            }
            else
            {
                ultimo.Siguiente = nuevoP;
                ultimo = nuevoP;
            }               
        }

        public Proceso deQueue()//sacar de la cola
        {
            if (primero == null)
                return null;
            else
                temp = primero;
            primero = primero.Siguiente;
            return temp;

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

            while(temp!= null)
            {
                sumaCiclosPen += temp.Ciclo;
                procPen++;
                temp = temp.Siguiente;
            }

            string pendientes = "Procesos pendientes: " + procPen + Environment.NewLine +
                "Suma de los ciclos pendientes: " + sumaCiclosPen;

            return pendientes;
        }




    }
}
