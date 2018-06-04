using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFOcirculares
{
    public partial class Form1 : Form
    {
        Proceso pross;
        static Random rnd = new Random();
        Procesador proc = new Procesador();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {

            int vacios = 0;
            int completos = 0;
            int llegaron = 0;
            for (int i = 0; i <300; i++)
            {
                if (rnd.Next(1, 101) <= 35)
                {
                    pross = new Proceso();
                    proc.enQueue(pross);
                    llegaron++;
                }

                Proceso process = proc.Peek();//ver primero/actual
                if (process != null)//-1 vuelve a leer el que se supone ya salió (arreglado)
                {
                    process.Ciclo--;

                    if (process.Ciclo == 0)
                    {
                        proc.deQueue();
                        completos++;
                    }//else
                  
                   proc.Avanzar();

                }
                else
                    vacios++;//si el procesador está vacío se suma 1 a vacíos, pero el ciclo sigue trabajando
            }
            txtProcesos.Text = "Procesos que llegaron" + llegaron + Environment.NewLine + "Ciclos que estuvo vacía: " + vacios + Environment.NewLine
                + proc.Pendientes() + Environment.NewLine + "Procesos completos: " + completos;
        }
    }
}

