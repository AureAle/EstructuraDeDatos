using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadasOrdenadas
{
    class Inventario
    {
        Producto ultimo, primero, encontrado, temp;

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
                if(primero.Siguiente==null)
                    if(primero.Codigo >nuevoP.Codigo)
                    {
                        nuevoP.Siguiente = primero;
                        ultimo = primero;
                        primero = nuevoP;
                        primero.Siguiente = ultimo;
                        ultimo.Anterior = primero;
                    }
                    else
                    {
                        primero.Siguiente = nuevoP;
                        ultimo = nuevoP;
                        ultimo.Anterior = primero;
                    }
                else
                {
                    if(primero.Codigo >nuevoP.Codigo)
                    {
                        nuevoP.Siguiente = primero;
                        primero.Anterior = nuevoP;
                        primero = nuevoP;
                        
                    }
                    else if(ultimo.Codigo < nuevoP.Codigo)
                    {
                        ultimo.Siguiente = nuevoP;
                        nuevoP.Anterior = ultimo;
                        ultimo = nuevoP;
                       
                    }
                    else
                    {
                        temp = primero;

                        while (temp.Siguiente.Codigo < nuevoP.Codigo && temp.Siguiente != ultimo)
                        {
                            temp = temp.Siguiente;
                        }

                        nuevoP.Siguiente = temp.Siguiente;
                        temp.Siguiente.Anterior = nuevoP;
                        temp.Siguiente = nuevoP;
                        nuevoP.Anterior = temp;
                    }

                }

            }
        }

        //public void AgregarInicio(Producto pInicio)
        //{
        //    if (primero == null)
        //    {
        //        primero = pInicio;
        //        ultimo = pInicio;
        //    }
        //    else
        //    {
        //        primero.Anterior = pInicio;
        //        pInicio.Siguiente = primero;
        //        primero = pInicio;
        //    }
        //}

        //public void Insertar(Producto prodAInsertar, int posicion)
        //{
        //    if (posicion == 1)
        //        AgregarInicio(prodAInsertar);
        //    else
        //    {
        //        int vcont = 2;
        //        temp = primero;

        //        while (vcont < posicion)
        //        {
        //            temp = temp.Siguiente;
        //            vcont++;
        //        }

        //        prodAInsertar.Siguiente = temp.Siguiente;
        //        prodAInsertar.Anterior = temp;
        //        temp.Siguiente.Anterior = prodAInsertar;
        //        temp.Siguiente = prodAInsertar;
        //    }
        //}

        public Producto Buscar(int codigoP)
        {
            temp = primero;
            encontrado = null;

            while (encontrado == null && temp != null)
                if (temp.Codigo == codigoP)
                    encontrado = temp;
                else
                    
                    temp = temp.Siguiente;

            return encontrado;
        }

        public bool Eliminar(int codigoP)
        {
            if (Buscar(codigoP) != null)
            {
                if (encontrado == primero)
                    EliminarInicio();
                else
                {
                    encontrado.Anterior.Siguiente = encontrado.Siguiente;

                    if (encontrado.Siguiente != null)
                        encontrado.Siguiente.Anterior = encontrado.Anterior;
                    else
                        ultimo = encontrado.Anterior;
                }

                return true;
            }
            else
                return false;
        }

        public void EliminarInicio()
        {

            if (primero == ultimo)
            {
                primero = null;
            }
            else
            {
                primero = primero.Siguiente;
                primero.Anterior = null;
                
            }
        }

        public void EliminarUltimo()
        { 
            if (primero == ultimo)
                primero = null;
            else
            {
                ultimo = ultimo.Anterior;
                ultimo.Siguiente = null;
                
            }
        }

        public string Listar()
        {
            string vProducto = "";
            temp = primero;

            while (temp != null)
            {
                vProducto += temp.ToString() + Environment.NewLine;
                temp = temp.Siguiente;
            }

            return vProducto;
        }

        public string Inverso()
        {
            return ListarInverso(primero);
        }

        private string ListarInverso(Producto temp)
        {
            string vProducto = "";

            if (temp.Siguiente != null)
                vProducto = ListarInverso(temp.Siguiente);

            vProducto += temp.ToString() + Environment.NewLine;
            return vProducto;
        }
    }
}


