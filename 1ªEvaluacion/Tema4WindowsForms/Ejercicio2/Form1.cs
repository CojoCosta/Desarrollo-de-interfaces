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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AcceptButton = btnColor;
            CancelButton = btnSalir;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            byte[] rgb = new byte[3];
            string[] rgbStrings = {textBox1.Text, textBox2.Text, textBox3.Text};
            for (int i = 0; i < rgbStrings.Length; i++)
            {
                if (!byte.TryParse(rgbStrings[i], out rgb[i]))
                {
                    rgb[i] = 255;
                }
            }
            this.BackColor = Color.FromArgb(rgb[0], rgb[1], rgb[2]);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Mi Aplicación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            
        }
    }
}
