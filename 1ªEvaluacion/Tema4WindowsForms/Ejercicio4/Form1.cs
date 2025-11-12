using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AcceptButton = btAñadir;
            timer1.Start();
        }

        private void btAñadir_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != string.Empty && !lista1.Items.Contains(textBox1.Text.Trim()))
            {
                lista1.Items.Add(textBox1.Text.Trim());
                nElementos.Text = lista1.Items.Count.ToString();
            }
            else
            {
                MessageBox.Show("Debe escribir algo o el texto ya ha sido añadido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btQuitar_Click(object sender, EventArgs e)
        {
            if (borrar1.Checked)
            {
                while (lista1.SelectedItems.Count > 0)
                {
                    lista1.Items.RemoveAt(lista1.SelectedIndex);
                }
                nElementos.Text = lista1.Items.Count.ToString();
            }
            else if (borrar2.Checked)
            {
                lista2.Items.Remove(lista2.SelectedItem);
            }
        }

        private void btTraspasar_Click(object sender, EventArgs e)
        {
            if (traspaso12.Checked)
            {
                while (lista1.SelectedItems.Count > 0)
                {
                    lista2.Items.Add(lista1.SelectedItem);
                    lista1.Items.Remove(lista1.SelectedItem);
                    nElementos.Text = lista1.Items.Count.ToString();
                }

            }
            else if (traspaso21.Checked)
            {
                lista1.Items.Add(lista2.SelectedItem);
                lista2.Items.Remove(lista2.SelectedItem);
            }
        }

        private void borrar1_CheckedChanged(object sender, EventArgs e)
        {
            btQuitar.Text = "Elimina de 1";
        }

        private void borrar2_CheckedChanged(object sender, EventArgs e)
        {
            btQuitar.Text = "Elimina de 2";
        }

        private void traspaso12_CheckedChanged(object sender, EventArgs e)
        {
            btTraspasar.Text = "Traspaso 1->2";
        }

        private void traspaso21_CheckedChanged(object sender, EventArgs e)
        {
            btTraspasar.Text = "Traspaso 2->1";
        }

        private void lista1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aux = "";
            foreach (var item in lista1.SelectedIndices)
            {
                aux += $" {item}";
            }
            elementosSelec.Text = aux;
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            string aux = "Formulario listas ";
            this.Icon = Properties.Resources.logo_chat_gpt_icon_267516;
            this.Text = aux.Substring(aux.Length - i - 1);
            i++;
            if (i >= aux.Length)
            {
                i = 0;
            }
            if (i % 2 == 0)
            {
                this.Icon = Properties.Resources.instagram_logo_icon_267526;
            }
        }

        private void lista2_MouseEnter(object sender, EventArgs e)
        {
            ayuda.ToolTipTitle =$"{lista2.Items.Count}";
        }

        private void lista2_MouseLeave(object sender, EventArgs e)
        {
            ayuda.ToolTipTitle = "";
        }
    }
}