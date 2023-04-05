using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ejer63_hilos
{
    public partial class Form1 : Form
    {
        Thread T;

        public Form1()
        {
            InitializeComponent();
            T = new Thread(AsignarHora);
        }

   


        private void AsignarHora()
        {
            while (true)
            {
                if (this.lblHora.InvokeRequired)
                {
                    this.lblHora.BeginInvoke((MethodInvoker)delegate ()
                    {
                        lblHora.Text = DateTime.Now.ToLongTimeString();
                    }

                    );

                }
                else
                {
                    lblHora.Text = DateTime.Now.ToLongTimeString();
                }
            }
            
        }
            
        private void HoraActual_Tick(object sender, EventArgs e)
        {
            /*
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.T.Start();
        }
    }
}
