using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procesos
{
    public partial class Form1 : Form
    {

        Procesos pro;
        public Form1()
        {
            InitializeComponent();

            }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            int tam = Convert.ToInt32(txtProcesos.Text);
            pro = new Procesos(tam);
        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            pro.Llenar(10);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        { //si le das mostrar muestra todos y si sólo  picas a un radiobutton sólo se ve el de ese

         
            
            //txtValores.Text += pro.Mostrar() +Environment.NewLine;
            //txtValores.Text += pro.MostrarFCFS() + Environment.NewLine;
            //txtValores.Text += pro.MostrarSJF() + Environment.NewLine;
            //txtValores.Text += pro.MostrarLJF() + Environment.NewLine;
        }


        private void Check(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            if (r == rbtnFCFS)
            {

                txtValores.Text = pro.Mostrar() + Environment.NewLine
                    + "Cmax=" + (pro.cmax()).ToString() + Environment.NewLine
                    + "FCFS: 0 "+pro.MostrarFCFS() + Environment.NewLine
                    + "Promedio de espera: " + pro.TimeEspera(pro.MostrarFCFS()) + Environment.NewLine
                    + "Tiempo de respuesta: " + pro.TimeRespuesta(pro.MostrarFCFS());
            }
            else if (r == rbtnSJF)
            {
                txtValores.Text = pro.Mostrar() + Environment.NewLine
                    + "Cmax=" + (pro.cmax()).ToString() + Environment.NewLine
                    + "SJF: 0 "+ pro.MostrarSJF() + Environment.NewLine
                    + "Promedio de espera: " + pro.TimeEspera(pro.MostrarSJF()) + Environment.NewLine
                    + "Tiempo de respuesta: " + pro.TimeRespuesta(pro.MostrarSJF());
            }
            else if (r == rbtnLSF)
            {
                txtValores.Text = pro.Mostrar() + Environment.NewLine
                    + "Cmax=" + (pro.cmax()).ToString() + Environment.NewLine
                    + "LSF: 0 "+ pro.MostrarLJF() + Environment.NewLine
                    + "Promedio de espera: " + pro.TimeEspera(pro.MostrarLJF()) + Environment.NewLine
                    + "Tiempo de respuesta: " + pro.TimeRespuesta(pro.MostrarLJF()); 
            }






        }

    }
}

