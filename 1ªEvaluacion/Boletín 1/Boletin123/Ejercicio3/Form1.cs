#define prueba
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Tragaperra : Form
    {
        Random rd = new Random();
        int creditoN = 50;
        public Tragaperra()
        {
            InitializeComponent();
        }

        private void Tragaperra_Load(object sender, EventArgs e)
        {

        }
        public (int, int, int) aleatorios(int min, int max)
        {
            return (rd.Next(min,max), rd.Next(min,max), rd.Next(min,max));
        }

        private void jugar_Click(object sender, EventArgs e)
        {
            creditoN -= 2;
            int n1 = aleatorios(1, 8).Item1;
            int n2 = aleatorios(1, 8).Item2;
            int n3 = aleatorios(1, 8).Item3;
            int premioN = 0;
            num1.Text = n1.ToString();
            num2.Text = n2.ToString();
            num3.Text = n3.ToString();
            if (n1 == n2 && n1 == n3)
            {
                premioN = 20;
                premio.Text = premioN.ToString() + "€";
                creditoN += premioN;
            }else if(n1 == n2 || n1 == n3 || n2 == n3)
            {
#if prueba
                premioN = -5;
                premio.Text = premioN.ToString() + "€";
                creditoN += premioN;
#else
                premioN = 5;
                premio.Text = premioN.ToString() + "€";
                creditoN += premioN;
#endif
            }
            else 
            {
                premioN = 0;
                premio.Text = premioN.ToString() + "€";
                creditoN += premioN;
            }
                credito.Text = creditoN.ToString() + "€";

        }

        private void num1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            creditoN += 10;
            credito.Text = creditoN.ToString() + "€";
        }
    }
}
