using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1ªEv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Receta rc;
        Form2 f2;
        static List<string> recetas = new List<string>;
        private void btnAnadir_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.ShowDialog();
            if (f2.DialogResult == DialogResult.Yes)
            {
                rc = new Receta(f2.txtNombre.Text, f2.txtDescripcion.Text, int.Parse(f2.cbTiempo.SelectedItem.ToString()));
                lb.Items.Add(rc.ToString());
                recetas.Add($"{rc.ToString().Trim(),10} {rc.Tiempo,5}{Environment.NewLine}{rc.Descripcion.Trim()}{Environment.NewLine}");
                foreach (var receta in recetas)
                {
                    txtDatos.AppendText(receta);
                }
                if (lb.Items.Count % 2 == 0)
                {
                    txtDatos.AppendText($"{Environment.NewLine}{Environment.NewLine}");
                }
            }
        }

        private void evento_RadioButton(object sender, EventArgs e)
        {
            if (((RadioButton)sender).ForeColor == Color.Red)
            {
                ((RadioButton)sender).ForeColor = Color.Black;
            }
            else
            {
                ((RadioButton)sender).ForeColor = Color.Red;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lb.Items.Count > 0)
            {
                e.Cancel = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                if (rbEliminar.Checked)
                {
                    while (lb.SelectedIndices.Count > 0)
                    {
                        recetas.Remove(recetas[lb.SelectedIndex]);
                        lb.SelectedIndices.Remove(lb.SelectedIndex);
                    }
                }
                else if (rbMostrar.Checked)
                {

                }
                else
                {
                    MessageBox.Show("No hay un radiobutton seleccionado", "Sin funcionalidad en A", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }
    }
}
