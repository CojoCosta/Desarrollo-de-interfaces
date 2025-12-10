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

namespace Ejercicio5
{
    public partial class Form1 : Form
    //   titulo  
    //   agenda si se cierra ya no funciona). 
    //   excepciones archivo lectura
    //  )
    // 
    // 
    {
        Color btoriginal;
        bool close = false;
        GrabarNumero grabar;
        static string homedrive = Environment.GetEnvironmentVariable("HOMEDRIVE");
        string ruta = homedrive + "\\Pruebas_DI";
        public Form1()
        {
            InitializeComponent();
            btoriginal = btReset.BackColor;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 20;
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
                x += 40;
                if (i % 3 == 0)
                {
                    x = 20;
                    y += 40;
                }
                boton.MouseDown += Boton_MouseDown;
                boton.MouseEnter += Boton_MouseEnter;
                boton.MouseLeave += Boton_MouseLeave;
                this.Controls.Add(boton);
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


        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa que simula un teléfono numérico antiguo realiza por Diego Costa en base a un ejercicio de Curro", "Información de la app", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close == false)
            {
                if (MessageBox.Show("Seguro que desea salir del programa?", "CERRAR PROGRAMA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            close = true;
            this.Close();
        }

        private void grabarNúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string contactoCompleto = "";
            StreamReader sr;
            string line = null;
            StreamWriter sw;
            GrabarNumero grabar = new GrabarNumero();
            grabar.AcceptButton = grabar.btnAceptar;
            grabar.btnAceptar.Click += (sender2, e2) =>
            {
                if (textBox1.Text.Trim() != "" && grabar.txtNombre.Text.Trim() != "")
                {
                    if (!Directory.Exists(ruta))
                    {
                        Directory.CreateDirectory(ruta);
                    }
                    try
                    {
                        using (sw = new StreamWriter($"{ruta}\\ejercicio5_DI.txt", true))
                        {

                            contactoCompleto = grabar.txtNombre.Text + " : " + textBox1.Text;
                            MessageBox.Show(contactoCompleto);
                            sw.WriteLine(contactoCompleto);
                        }

                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show("Archivo no encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    grabar.Close();
                }
                else
                {
                    MessageBox.Show("Algun textbox está vacio", "No se puede guardar el contacto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            grabar.ShowDialog();
        }

        private void mostrarAgendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string line;
            string[] datos = new string[2];
            StreamReader sr;
            Agenda agenda = null;
            if (agenda == null)
            {
                agenda = new Agenda();
                try
                {

                    using (sr = new StreamReader($"{ruta}\\ejercicio5_DI.txt"))
                    {
                        line = sr.ReadLine();
                        while (line != null)
                        {
                            datos = line.Split(':');
                            agenda.txtAgenda.Text += string.Format($"{datos[0].Trim(),-15}{datos[1].Trim(),-15}{System.Environment.NewLine}");
                            line = sr.ReadLine();
                        }
                    }
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("Archivo no encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                agenda.Show();
            }
        }
    }
}