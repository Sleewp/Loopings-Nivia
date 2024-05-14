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
    public partial class frmcidadania : Form
    {
        public frmcidadania()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double codigo;

            codigo = Convert.ToDouble(txtcodigo.Text);
           

            if(codigo == 1)
            {
                txtcidadania.Text = "Brasileiro";
                txtlingua.Text = "Português";
            }

            if (codigo == 2)
            {
                txtcidadania.Text = "Alemão";
                txtlingua.Text = "Alemão";
            }

            if (codigo == 3)
            {
                txtcidadania.Text = "Inglês";
                txtlingua.Text = "Ingês Britânico";
            }

            if (codigo == 4)
            {
                txtcidadania.Text = "Italiano";
                txtlingua.Text = "Italiano";
            }

            if (codigo == 5)
            {
                txtcidadania.Text = "Espanhol";
                txtlingua.Text = "Espanhol";
            }

            if (codigo == 6)
            {
                txtcidadania.Text = "Francês";
                txtlingua.Text = "Francês";
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcodigo.Clear();
            txtcidadania.Clear();
            txtlingua.Clear();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            this.Hide();
            menu.Show();
        }
    }
}
