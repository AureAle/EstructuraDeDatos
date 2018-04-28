using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TortugaDibujante
{
    class Tortuga
    {
        private bool pluma;
        private int sentido, posX, posY;
        private int[,] piso = new int[20, 20];

        public int Sentido { get => sentido;  }
        public int PosX { get => posX;  }
        public int PosY { get => posY;}
        public int[,] Piso { get => piso; set => piso = value; }

        public Tortuga()
        {
            
            
            pluma = false;
            posX = 0;
            posY = 0;
           
        }

        public void Llenar()
        {
            for (int r = 0; r < piso.GetLength(0); r++)
                for (int c = 0; c < piso.GetLength(1); c++)
                    piso[r, c] = 0;
        }

        public string Imprimir()
        {
            string m = "";
            int ren = piso.GetLength(0);
            int col = piso.GetLength(1);

            for (int r = 0; r < ren; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    if (piso[r, c] == 1)
                        m += "*";
                    else
                        m += "0"
;                }
                m += Environment.NewLine;
            }

            return m;
        }

        public void SubirPluma()
        {
            pluma = false;
        }

        public void BajarPluma()
        {
            pluma = true;
        }

        public void GirarDerecha()
        {
            //1.-arriba, 2.-derecha, 3.-abajo, 4.-izquierda
            if (sentido == 4)
                sentido = 1;
            else
                sentido++;

        }

        public void Girarizquierda()
        {
            if (sentido == 1)
                sentido = 4;
            else
                sentido--;

        }

        public void Avanzar(int pasos)
        {


            if (pluma == false)
            { 
                switch (sentido)
                {
                    case 1://Arriba
                        posX = posX - pasos +1;//+1
                        break;
                    case 2://Derecha
                        posY = posY + pasos-1;//-1 prueba
                        break;
                    case 3://Abajo
                        posX = posX + pasos-1;//-1
                        break;
                    case 4://Izquierda
                        posY = posY - pasos+1;//+1
                        break;
                    default:
                        break;
                }
            }
            if (pluma == true)
                
            switch (sentido)//pinta sobre la misma posición en que se quedó en vez de ir a la posición que sigue 
                {
                    case 1://Arriba                        
                        for (int ren = posX; ren > (posX - pasos); ren--)//fallo                                               
                            piso[ren, posY] = 1;                                               
                        posX = posX - pasos+1; //+1                                            
                        break;

                    case 2://Derecha
                        for (int col = posY; col < (posY + pasos); col++)
                            piso[posX, col] = 1;
                        posY = posY + pasos -1;//-1 prueba 
                        break;
                    case 3://Abajo
                        for (int ren = posX+1; ren < (posX + pasos); ren++)
                            piso[ren, posY] = 1;
                        posX = posX + pasos -1;//-1
                        break;
                    case 4://Izquierda
                        for (int col = posY; col > (posY - pasos); col--)
                            piso[posX, col] = 1;
                        posY = posY - pasos+1;//+1
                        break;
                    default:
                        break;
                }

        }
    }

}

