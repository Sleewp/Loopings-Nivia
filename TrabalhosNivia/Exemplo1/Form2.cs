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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void projetosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void descontoDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmdescontoprodutos desconto = new frmdescontoprodutos();
            desconto.Show();
        }

        private void somaDeNúmerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 soma = new Form1();
            soma.Show();
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cidadâniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmcidadania cidadania = new frmcidadania();
            cidadania.Show();
        }

        private void loopingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 loopings = new Form5();
            loopings.Show();
        }
    }
}
