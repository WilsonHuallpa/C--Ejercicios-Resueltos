using System;
using System.IO;
using System.Security;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibloteca_ejer58;

namespace Ejer56
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Guardar();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarComo();
        }

        public void Abrir()
        {
            try
            {
                openFileDialog1.Title = "Abrir Archivos, ejercicion 56.";
                openFileDialog1.ShowDialog();

                PuntoDat file = new PuntoDat();
                file = file.Leer(openFileDialog1.FileName);
                richTextBox1.Text = file.Contenido;
            }
            catch (Exception)
            {
                MessageBox.Show("El archivo no se abrio correctamente.");
            }
        }

      /*  public void leer(string direccion)
        {
            try
            {
                StreamReader reader = new StreamReader(direccion, System.Text.Encoding.Default);
                richTextBox1.Text = reader.ReadToEnd();
                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("El Archivos no se leyo corectamente.");
            }
          
        }*/

        public void GuardarComo()
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    PuntoDat ar = new PuntoDat();
                    ar.Contenido = richTextBox1.Text;

                    if(ar.GuardarComo(saveFileDialog1.FileName, ar))
                    {
                        MessageBox.Show("se guardo correctamente. ");
                        richTextBox1.Clear();
                        richTextBox1.Focus();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error... a guardar." + e.Message);
            }
        }

        public void Guardar()
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    
                    if (File.Exists(saveFileDialog1.FileName))
                    {
                        StreamWriter textNuevo = File.CreateText(saveFileDialog1.FileName);
                     
                        textNuevo.Write(richTextBox1.Text);
                        textNuevo.Flush();
                        textNuevo.Close();

                    }
                    else
                    {
                        StreamWriter textNuevo = File.CreateText(saveFileDialog1.FileName);
                        textNuevo.Write(richTextBox1.Text);
                        textNuevo.Flush();
                        textNuevo.Close();
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error... a guardar.");
            }
        }

        private void archivosDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PuntoTxt text = new PuntoTxt();

                string ruta = AppDomain.CurrentDomain.BaseDirectory + "texto.txt";

                this.richTextBox1.Text = text.Leer(ruta);

            }
            catch (ArchivoIncorrectoException er)
            {
                MessageBox.Show(er.Message);
                throw;
            }
        }

        private void archivosDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {


            try
            {
                PuntoDat text = new PuntoDat();

                string ruta = AppDomain.CurrentDomain.BaseDirectory + "texto.dat";

                text = text.Leer(ruta);

                this.richTextBox1.Text = text.Contenido;


            }
            catch (ArchivoIncorrectoException er)
            {
                MessageBox.Show(er.Message);
                throw;
            }
        }

        private void archvoDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PuntoTxt puntoTxt = new PuntoTxt();

                string ruta = AppDomain.CurrentDomain.BaseDirectory + "texto.txt";

                MessageBox.Show(ruta);
                
                string text = this.richTextBox1.Text;

                puntoTxt.Guardar(ruta, text);
            }
            catch (ArchivoIncorrectoException er)
            {
                MessageBox.Show(er.Message);
                throw;
            }
        }

        private void archivoDeDatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PuntoDat puntoData = new PuntoDat();

                string ruta = AppDomain.CurrentDomain.BaseDirectory + "texto.dat";
                puntoData.Contenido = this.richTextBox1.Text;

                puntoData.Guardar(ruta, puntoData);
                MessageBox.Show( "Se guardo correctame, Ruta: " + ruta);
            }
            catch (ArchivoIncorrectoException er)
            {
                MessageBox.Show(er.Message);
                throw;
            }
        }
    }



    /*a. Agregar un menú superior (MenuStrip) con las opciones de Archivo->Guardar, ArchivoGuardar como... y Archivo->Abrir.
b. Agregar una barra de estado en la parte inferior (StatusStrip). Se debe informar el total de 
caracteres del archivo.
c. Al pulsar en el menú "Abrir" o "Guardar como...", se deberá abrir una ventana para 
seleccionar los archivos (ver nota al pie).
d. Al hacer click sobre "Guardar", se deberá guardar el mismo archivo abierto (último guardado 
o abierto desde la interfaz). En el caso que no haya ningún "último archivo", se comportará 
igual que el "Guardar Como…". Reutilizar código.
e. El editor (RichTextBox) deberá estar acoplado (Dock) al formulario.
NOTA: Utilizar OpenFileDialog y SaveFileDialog para buscar los archivos en las carpetas del sistema.*/
}
