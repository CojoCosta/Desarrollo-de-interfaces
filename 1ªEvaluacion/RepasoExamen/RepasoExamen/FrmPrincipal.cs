using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoExamen
{
    public partial class FrmPrincipal : Form
    {
        CheckBox ch;
        Button[] botones;
        ToolTip toolTip = new ToolTip();
        public FrmPrincipal()
        {
            InitializeComponent();
            timer1.Start();
            botones = new Button[] { btnJugar, btnReset, btnSalir };
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            int x = 30;
            int y = 30;
            for (int i = 1; i < 50; i++)
            {
                ch = new CheckBox();
                ch.Enabled = true;
                ch.Visible = true;
                ch.Size = new Size(30, 30);
                ch.Location = new Point(x, y);
                ch.Text = i.ToString();
                x += 40;
                if (i % 9 == 0)
                {
                    x = 30;
                    y += 40;
                }
                ch.CheckedChanged += checkBox_Checked;
                Controls.Add(ch);
                toolTip.SetToolTip(ch, "No marcado");
            }
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Button boton in botones)
            {
                boton.BackColor = Color.Beige;
            }
            botones[i].BackColor = Color.Yellow;
            i++;
            if (i >= botones.Length)
            {
                i = 0;
            }
        }

        int contadorChecks = 0;
        private void checkBox_Checked(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                toolTip.SetToolTip((CheckBox)sender, "Marcado");
                contadorChecks++;
            }
            else
            {
                toolTip.SetToolTip((CheckBox)sender, "No marcado");
                contadorChecks--;
            }
        }
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (LstNombres.Items.Count > 0)
            {
                if (MessageBox.Show("Se saldrá de la aplicacion", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = false;
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblResultados.Text = "Resultados";
            foreach (Control c in Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                    ((CheckBox)c).BackColor = Color.White;
                    toolTip.SetToolTip((CheckBox)c, "No marcado");
                }
            }
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int[] aleatorios;
        private void btnJugar_Click(object sender, EventArgs e)
        {
            if (contadorChecks != 6)
            {
                MessageBox.Show("Usted debe marcar exactamente 6 checkBoxes", "ERROR DE USO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Random random = new Random();
                int aleatorio = random.Next(1, 50);
                aleatorios = new int[6];
                for (int i = 0; i < aleatorios.Length; i++)
                {
                    while (aleatorios.Contains(aleatorio))
                    {
                        aleatorio = random.Next(1, 50);
                    }
                    aleatorios[i] = aleatorio;
                    lblResultados.Text += $", {aleatorios[i]}";
                  
                }
            }

        }
    }
}