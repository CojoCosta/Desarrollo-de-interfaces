using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
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
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            byte[] rgb = new byte[3];
            string[] rgbStrings = { textBox1.Text, textBox2.Text, textBox3.Text };
            for (int i = 0; i < rgbStrings.Length; i++)
            {
                if (!byte.TryParse(rgbStrings[i], out rgb[i]))
                {
                    rgb[i] = 255;
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
                    if (tb.Name == textBox4.Name)
                    {
                        tb.Text = string.Empty;
                    }
                    else
                    {
                        tb.Text = "0";
                    }
                }
            }
            this.BackColor = colorFondo;
        }

        private void cargaImagen_Click(object sender, EventArgs e)
        {
            string urlImg = textBox4.Text;
            if (!string.IsNullOrEmpty(urlImg))
            {
                pictureBox1.Image = Image.FromFile(urlImg);
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
    }
}
