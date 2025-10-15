using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema4WindowsForms
{
    public partial class Ejercicio1 : Form
    {
        string titulo;
        Button boton;
        public Ejercicio1()
        {
            InitializeComponent();
            titulo = this.Text;
        }
        private void Ejercicio1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X: {MousePosition.X} , Y: {MousePosition.Y}";
        }

        private void Ejercicio1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = titulo;
        }


        private void Ejercicio1_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Right == e.Button)
            {
                button2.BackColor = Color.Red;
            }
            else if (MouseButtons.Left == e.Button)
            {
                button1.BackColor = Color.Green;
            }
            else
            {
                button1.BackColor = Color.Blue;
                button2.BackColor = Color.Blue;
            }
        }

        private void Ejercicio1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Empty;
            button2.BackColor = Color.Empty;
        }

        private void Ejercicio1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar is (char)Keys.Escape)
            {
                this.Text = titulo;
            }
            else
            {
                this.Text = e.KeyChar.ToString();
            }
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {
            int x = 200;
            int y = 200;
            for (int i = 1; i <= 20; i++)
            {
                boton = new Button();
                boton.Text = $"{i}";
                boton.Location = new Point(x, y);
                boton.Size = new Size(80, 20);
                boton.Enabled = true;
                this.Controls.Add(boton);
                x += 100;
                if (i % 5 == 0)
                {
                    x = 200;
                    y += 40;
                }
                this.boton.Click += new System.EventHandler(this.botonClick);
            }
        }

        private void botonClick(object sender, EventArgs e)
        {
            
        }
    }
}
