using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        Color btoriginal;
        public Form1()
        {
            InitializeComponent();
            btoriginal = btReset.BackColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 250;
            int y = 100;
            for (int i = 1; i <= 12; i++)
            {
                Button boton = new Button();
                boton.Location = new Point(x, y);
                boton.Size = new Size(40, 40);
                boton.Enabled = true;
                boton.Text = $"{i}";
                if (i == 10)
                {
                    boton.Text = "*";
                }
                else if (i == 11)
                {
                    boton.Text = "0";
                }
                else if (i == 12)
                {
                    boton.Text = "#";
                }
                this.Controls.Add(boton);
                x += 40;
                if (i % 3 == 0)
                {
                    x = 250;
                    y += 40;
                }
                boton.MouseDown += Boton_MouseDown;
                boton.MouseEnter += Boton_MouseEnter;
                boton.MouseLeave += Boton_MouseLeave;
            }
        }
        private void Boton_MouseDown(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            textBox1.Text += ((Button)sender).Text;
        }

        private void Boton_MouseEnter(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor != Color.Red)
            {
                ((Button)sender).BackColor = Color.Orange;
            }
        }

        private void Boton_MouseLeave(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor != Color.Red)
            {
                ((Button)sender).BackColor = btoriginal;
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control.BackColor == Color.Red)
                {
                    control.BackColor = btoriginal;
                }
            }
            textBox1.Text = "";
        }
    }
}