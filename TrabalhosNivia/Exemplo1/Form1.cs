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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, result;

            num1 = Convert.ToDouble(txtnumero.Text);
            num2 = Convert.ToDouble(txtnumero2.Text);

            result = num1 + num2;

            txtresultado.Text = result.ToString();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnumero.Clear();
            txtnumero2.Clear();
            txtresultado.Clear();
            txtnumero.Focus();

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void txtresultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
