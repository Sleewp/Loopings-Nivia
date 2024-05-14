using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnwhile_Click(object sender, EventArgs e)
        {
            double num, x, i;
            num = Convert.ToDouble(txtnumero.Text);

            i = num;
            x = 1;
            while (i > 1) 
            {
                x *= i;
                i--;

                txtresultado.Text = String.Concat(txtresultado.Text,"\r\n",x.ToString());
            }
        }

        private void btndowhile_Click(object sender, EventArgs e)
        {
            double num, x, i;
            num = Convert.ToDouble(txtnumero.Text);

            i = num;
            x = 1;
            do
            {
                x *= i;
                i--;

                txtresultado.Text = String.Concat(txtresultado.Text, "\r\n", x.ToString());
            } while (i > 1);
        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            double num, x, i;
            num = Convert.ToDouble(txtnumero.Text);

            i = num;
            x = 1;
            for (i = num; i > 1; i--)
            {
                x *= i;
                txtresultado.Text = String.Concat(txtresultado.Text, "\r\n", x.ToString());
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnumero.Clear();
            txtresultado.Clear();
            txtnumero.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}
