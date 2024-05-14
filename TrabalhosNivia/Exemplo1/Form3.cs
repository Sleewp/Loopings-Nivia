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
    public partial class frmdescontoprodutos : Form
    {
        public frmdescontoprodutos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtdesconto_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtpreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtdesconto.Clear();
            txtpreco.Clear();
            txtcodigo.Clear();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double preco, cod, desconto, final, regiao ;

            preco = Convert.ToDouble(txtpreco.Text);
            cod = Convert.ToDouble(txtcodigo.Text);
            

            if (cod == 1)
            {
                desconto = (preco * 5) / 100;
                txtdesconto.Text = desconto.ToString();
                final = preco - desconto;
                txtfinal.Text = final.ToString();
                txtregiao.Text = "Região Norte";
            }
            else if(cod == 2)
            {
                desconto = (preco * 15) / 100;
                txtdesconto.Text = desconto.ToString();
                final = preco - desconto;
                txtfinal.Text = final.ToString();
                txtregiao.Text = "Região Sul";
            }
            else if (cod == 3)
            {
                desconto = (preco * 7) / 100;
                txtdesconto.Text = desconto.ToString();
                final = preco - desconto;
                txtfinal.Text = final.ToString();
                txtregiao.Text = "Região Sudeste";
            }
            else if(cod == 4)
            {
                desconto = (preco * 12) / 100;
                txtdesconto.Text = desconto.ToString();
                final = preco - desconto;
                txtfinal.Text = final.ToString();
                txtregiao.Text = "Região Nordeste";
            }
            else if (cod == 5)
            {
                desconto = (preco * 20) / 100;
                txtdesconto.Text = desconto.ToString();
                final = preco - desconto;
                txtfinal.Text = final.ToString();
                txtregiao.Text = "Região Centro-Oeste";
            }
            else
            {
                txtalert.Text = "Este produto é importado";
            }

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            this.Hide();
            menu.Show();
        }

        private void txtfinal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
