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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            for (int i = 5; i <= 60; i+=5)
            {
                cbTiempo.Items.Add(i);
            }
            cbTiempo.SelectedItem = cbTiempo.Items[3];
            AcceptButton = btnGuardar;
            CancelButton = btnNoGuardar;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
