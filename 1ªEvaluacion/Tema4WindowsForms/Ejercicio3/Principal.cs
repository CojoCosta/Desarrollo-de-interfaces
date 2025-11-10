using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Principal : Form
    {
        int segundos;
        int minutos;
        public Principal()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.ForeColor = Color.Red;
            }
            else
            {
                checkBox1.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Seleciciona una imagen";
            of.InitialDirectory = "c:\\";
            of.Filter = "Imagenes (*.png) |*.png| Imagenes (*.jpg) |*.jpg| Todos los archivos (*.*) |*.*";
            of.ShowDialog();
            try
            {
            Secundario secundario = new Secundario();
            if (checkBox1.Checked)
            {
                secundario.ShowDialog();
            }
            else
            {
                secundario.Show();
            }
            secundario.Text = Path.GetFileName(of.FileName);
            secundario.cargarImagen(of.FileName);
            }
            catch (IOException)
            {
                MessageBox.Show("Error de archivo", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("Error con la imagen", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Has salido sin seleccionar imagen", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;
            if (segundos == 60)
            {
                segundos = 0;
                minutos++;
            }
            this.Text = $"Visor de imágenes - {minutos:d2}:{segundos:d2}";
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Mi Aplicación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
