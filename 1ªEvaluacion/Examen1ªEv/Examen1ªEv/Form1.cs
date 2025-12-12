using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            AcceptButton = btnAnadir;
        }
        Receta rc;
        Form2 f2;
        Label lbl;
        static List<string> recetas = new List<string>();
        private void btnAnadir_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.ShowDialog();
            if (f2.DialogResult == DialogResult.Yes)
            {
                rc = new Receta(f2.txtNombre.Text, f2.txtDescripcion.Text, int.Parse(f2.cbTiempo.SelectedItem.ToString()));
                lb.Items.Add(rc.ToString());
                recetas.Add($"{rc.ToString().Trim(),10} {rc.Tiempo,5}{Environment.NewLine}{rc.Descripcion.Trim()}{Environment.NewLine}");
            }
            txtDatos.AppendText(recetas[recetas.Count - 1]);
            if (lb.Items.Count % 2 == 0)
            {
                txtDatos.AppendText($"{Environment.NewLine}{Environment.NewLine}");
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

        int x = 10;
        int y = 10;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                if (rbEliminar.Checked)
                {
                    for (int i = lb.SelectedIndices.Count - 1; i >= 0; i--)
                    {
                        string contenidoDatos = recetas[lb.SelectedIndices[i]];
                        txtDatos.Text = txtDatos.Text.Replace(contenidoDatos, "");
                        recetas.RemoveAt(lb.SelectedIndices[i]);
                        lb.Items.RemoveAt(lb.SelectedIndices[i]);
                    }
                }
                else if (rbMostrar.Checked)
                {
                    for (int i = 0; i < lb.SelectedIndices.Count; i++)
                    {
                        panel1.Controls.Clear();
                        if (panel1.Controls.Count == 0)
                        {
                            x = 10;
                            y = 10;
                        }
                        lbl = new Label();
                        lbl.Text = lb.SelectedIndices[i].ToString();
                        lbl.Location = new Point(x, y);
                        panel1.Controls.Add(lbl);
                        y += 30;
                        if (lb.SelectedIndices[i] % 3 == 0)
                        {
                            x += 30;
                            y = 10;
                        }
                        if (lb.SelectedIndices[i] % 2 == 0)
                        {
                            lbl.ForeColor = Color.Green;
                        }
                        else
                        {
                            lbl.ForeColor = Color.Blue;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay un radiobutton seleccionado", "Sin funcionalidad en A", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }
    }
}
