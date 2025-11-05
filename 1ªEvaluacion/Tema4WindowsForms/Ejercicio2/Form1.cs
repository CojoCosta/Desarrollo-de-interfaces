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
using System.Windows.Forms.VisualStyles;

namespace Ejercicio2//TODO 
                    //Gestión AcceptButton. -> CHECK
                    //limpiar en reset. -> CHECK
{
    public partial class Form1 : Form
    {
        static Color colorDefault;
        static Color colorFondo;
        public Form1()
        {
            InitializeComponent();
            AcceptButton = btnColor;
            CancelButton = btnSalir;
            colorDefault = btnColor.BackColor;
            colorFondo = this.BackColor;
            this.Text = "Ejercicio 2";
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            byte[] rgb = new byte[3];
            string[] rgbStrings = { textBox1.Text, textBox2.Text, textBox3.Text };
            for (int i = 0; i < rgbStrings.Length; i++)
            {
                if (!byte.TryParse(rgbStrings[i], out rgb[i]))
                {
                    MessageBox.Show("Parámetros incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.BackColor = colorFondo;
                    break;
                }
            }
            this.BackColor = Color.FromArgb(rgb[0], rgb[1], rgb[2]);
        }


        private void reset_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox tb)
                {
                    if (control.Name == textBox4.Name)
                    {
                        control.Text = string.Empty;
                    }
                    else
                    {
                        control.Text = "0";
                    }
                }
            }
            pictureBox1.Image = null;
            this.BackColor = colorFondo;
        }

        private void cargaImagen_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox4.Text))
            {
                try
                {
                    pictureBox1.Image = new Bitmap(textBox4.Text);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("No encontramos la imagen", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("No encontramos la imagen", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                textBox4.Text = "PATH INCORRECTO";
            }
        }
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Blue;
        }
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = colorDefault;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Mi Aplicación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            AcceptButton = cargaImagen;
        }


        private void textBox4_Leave(object sender, EventArgs e)
        {
            AcceptButton = btnColor;
        }
    }
}
