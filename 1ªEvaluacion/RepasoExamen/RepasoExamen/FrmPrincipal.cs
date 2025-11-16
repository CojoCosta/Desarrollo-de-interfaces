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
        public FrmPrincipal()
        {
            InitializeComponent();
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
                ch.Size = new Size(30,30);
                ch.Location = new Point(x,y);
                ch.Text = i.ToString();
                x += 40;
                if (i % 9 == 0)
                {
                    x = 30;
                    y += 40;
                }
                Controls.Add(ch);
            }
        }
    }
}
