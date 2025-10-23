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
    //TODO icono(Hecho).
    //Coor botones(Hecho).
    //Confirmación cierre(Hecho).
    //Quitar bucles en mousedown y up(Hecho).
{
    public partial class Ejercicio1 : Form
    {
        string titulo;

        public Ejercicio1()
        {
            InitializeComponent();
            titulo = this.Text;
        }
        private void Ejercicio1_MouseMove(object sender, MouseEventArgs e)
        {

            int x = e.X;
            int y = e.Y;
            if (sender == this)
            {
                this.Text = $"X: {x} Y: {y}";
            }
            else
            {
                int xBt = ((Button)sender).Location.X;
                int yBt = ((Button)sender).Location.Y;
                this.Text = $"X: {x + xBt} Y: {y + yBt}";
            }

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
            if (MouseButtons.Right == e.Button)
            {
                button2.BackColor = Color.Empty;
            }
            else if (MouseButtons.Left == e.Button)
            {
                button1.BackColor = Color.Empty;
            }
            else
            {
                button1.BackColor = Color.Empty;
                button2.BackColor = Color.Empty;
            }
        }


        private void Ejercicio1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode is Keys.Escape)
            {
                this.Text = titulo;
            }
            else
            {
                this.Text = e.KeyCode.ToString();
            }
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {
            int x = 200;
            int y = 200;
            for (int i = 1; i <= 20; i++)
            {
                Button boton = new Button();
                boton.Text = $"Botón {i}";
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
                boton.MouseUp += Boton_MouseUp;
                boton.MouseDown += Boton_MouseDown;
                boton.MouseMove += Ejercicio1_MouseMove;
            }
        }
        private void Boton_MouseDown(object sender, MouseEventArgs e)
        {
            ((Button)sender).ForeColor = Color.Red;
        }
        private void Boton_MouseUp(object sender, MouseEventArgs e)
        {
            ((Button)sender).ForeColor = Color.Black;
        }

        private void Ejercicio1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Mi Aplicación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
