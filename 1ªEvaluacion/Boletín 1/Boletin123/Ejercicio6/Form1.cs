using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {   
            DialogResult yesNo = MessageBox.Show("Quieres poner \"" + texto1.Text.Trim() + "\" de titulo¿?", "CAMBIO DE TITULO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (yesNo == DialogResult.Yes)
            {
                this.Text = texto1.Text.Trim();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
