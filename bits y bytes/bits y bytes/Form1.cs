using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bits_y_bytes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int desplazo(int num)
        {
            int x = num >> 1;//desplazamos uno para deshacernos del bit 0
            return x; //devolvemos el número con el que se trabajará

        }

        private int desplazoDir(int num)
        {
            int dir = desplazo(num) & 7;//se aplica la operación and para que devuelva los últimos 3 bits del número original (7 requiere de 3 bits)

            picDirecc.Image = imgListDirecc.Images[dir];
            //switch (dir)
            //{
            //    case 0:
            //        picDirecc.Image = imgListDirecc.Images[0];
            //        Console.WriteLine("norte");
            //        break;
            //    case 1:
            //        picDirecc.Image = imgListDirecc.Images[1];
            //        Console.WriteLine("noreste");
            //        break;
            //    case 2:
            //        picDirecc.Image = imgListDirecc.Images[2];
            //        Console.WriteLine("este");
            //        break;
            //    case 3:
            //        picDirecc.Image = imgListDirecc.Images[3];
            //        Console.WriteLine("sureste");
            //        break;
            //    case 4:
            //        picDirecc.Image = imgListDirecc.Images[4];
            //        Console.WriteLine("sur");
            //        break;
            //    case 5:
            //        picDirecc.Image = imgListDirecc.Images[5];
            //        Console.WriteLine("soroeste");
            //        break;
            //    case 6:
            //        picDirecc.Image = imgListDirecc.Images[6];
            //        Console.WriteLine("oeste");
            //        break;
            //    case 7:
            //        picDirecc.Image = imgListDirecc.Images[7];
            //        Console.WriteLine("noroeste");
            //        break;
            //}

            return dir;
                       
        }
        private int desplazoEstado(int num)
        {
            int state = desplazo(num)  >> 3 & 3;//3 requiere de 2 bits se recorre 3 posiciones para quitar los de direcc
            switch (state)
            {
                case 0:
                    picState1.Image = imgListState.Images[0]; picState2.Image = imgListState.Images[0];
                    break;
                case 1:
                    picState1.Image = imgListState.Images[0]; picState2.Image = imgListState.Images[1];
                    break;
                case 2:
                    picState1.Image = imgListState.Images[1]; picState2.Image = imgListState.Images[0];
                    break;
                case 3:
                    picState1.Image = imgListState.Images[1]; picState2.Image = imgListState.Images[1];
                    break;
            }
            return state;
        }

        private int desplazoNivel(int num)
        {
            int nivel = desplazo(num) >> 5 & 3;// al número desplazdo se le desplazan 5 para obtener los bits de nivel y se requieren 2 bits por lo tanto el and de 3 

           picNivel.Image = imgListNivel.Images[nivel];// implementar este

            //switch (nivel)
            //{
            //    case 0:
            //        picNivel.Image = imgListNivel.Images[0]; Console.WriteLine("vacío");
            //        break;
            //    case 1:
            //        picNivel.Image = imgListNivel.Images[1]; Console.WriteLine("medio");
            //        break;
            //    case 2:
            //        picNivel.Image = imgListNivel.Images[2]; Console.WriteLine("lleno");
            //        break;
            //    case 3:
            //        picNivel.Image = imgListNivel.Images[3]; Console.WriteLine("llenándose");
            //        break;

            //}

            return nivel;
        }

        private string desplazoFechaDia(int num)
        {
            int dd = desplazo(num) >> 7 & 31;//se desplza 7 bits y se requieren de 5 bits por lo tanto el and de 31                 
            int mm = desplazo(num) >> 12 & 15; // se desplaza 12 bits y se requieren de 4 bits por lo tanto el and de 15
            int aa = desplazo(num) >> 16 & 127; //se desplaza 16 bits y se requieren los 7 últimos por lo que and de 127
            int year = aa + 1900;

            string dia = Convert.ToString(dd);
            string mes = Convert.ToString(mm);
            string año = Convert.ToString(year);

            return  año + "/" + mes + "/" + dia ;
        }

        private int fechaNueva(string fe)
        {
            string[] fecha = fe.Split('/');
            int dia = Convert.ToInt32(fecha[0]);
            int mes = Convert.ToInt32(fecha[1])<<5;
            int año = Convert.ToInt32(fecha[2])-1900<<9 ;
            


            return año+mes+dia;
        }



        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtEntrada.Text);

            desplazoDir(num);
            desplazoEstado(num);
            desplazoNivel(num);
            desplazoFechaDia(num);
            lblFechaLectura.Text += " " + desplazoFechaDia(num);

        }

        private void btnAjustarFecha_Click(object sender, EventArgs e)
        {

            txtNewFecha.Text = Convert.ToString(fechaNueva(txtFecha.Text));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEntrada.Clear();
            txtFecha.Clear();
            txtNewFecha.Clear();
            lblFechaLectura.Text = string.Empty;
            picDirecc.Image = null;
            picNivel.Image = null;
            picState1.Image = null;
            picState2.Image = null;
            
        }



    }
}

