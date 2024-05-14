namespace Exemplo1
{
    partial class frmdescontoprodutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblpreco = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lbldesconto = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtdesconto = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.txtalert = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblregiao = new System.Windows.Forms.Label();
            this.txtfinal = new System.Windows.Forms.TextBox();
            this.txtregiao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblpreco
            // 
            this.lblpreco.AutoSize = true;
            this.lblpreco.Location = new System.Drawing.Point(274, 110);
            this.lblpreco.Name = "lblpreco";
            this.lblpreco.Size = new System.Drawing.Size(130, 13);
            this.lblpreco.TabIndex = 0;
            this.lblpreco.Text = "Digite o preço do produto:";
            this.lblpreco.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(269, 159);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(135, 13);
            this.lblcodigo.TabIndex = 1;
            this.lblcodigo.Text = "Digite o código do produto:";
            // 
            // lbldesconto
            // 
            this.lbldesconto.AutoSize = true;
            this.lbldesconto.Location = new System.Drawing.Point(295, 204);
            this.lbldesconto.Name = "lbldesconto";
            this.lbldesconto.Size = new System.Drawing.Size(109, 13);
            this.lbldesconto.TabIndex = 2;
            this.lbldesconto.Text = "Desconto concedido:";
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(429, 107);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(100, 20);
            this.txtpreco.TabIndex = 3;
            this.txtpreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpreco.TextChanged += new System.EventHandler(this.txtpreco_TextChanged);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(429, 156);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 4;
            this.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtdesconto
            // 
            this.txtdesconto.Enabled = false;
            this.txtdesconto.Location = new System.Drawing.Point(429, 204);
            this.txtdesconto.Name = "txtdesconto";
            this.txtdesconto.ReadOnly = true;
            this.txtdesconto.Size = new System.Drawing.Size(100, 20);
            this.txtdesconto.TabIndex = 5;
            this.txtdesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdesconto.TextChanged += new System.EventHandler(this.txtdesconto_TextChanged);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(310, 361);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(683, 392);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 7;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(442, 361);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 8;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // txtalert
            // 
            this.txtalert.Enabled = false;
            this.txtalert.Location = new System.Drawing.Point(194, 3);
            this.txtalert.Name = "txtalert";
            this.txtalert.ReadOnly = true;
            this.txtalert.Size = new System.Drawing.Size(420, 20);
            this.txtalert.TabIndex = 9;
            this.txtalert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Por favor, digite o preço e o código do produto para calcular o desconto dele";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(339, 256);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(56, 13);
            this.lbltotal.TabIndex = 11;
            this.lbltotal.Text = "Valor final:";
            // 
            // lblregiao
            // 
            this.lblregiao.AutoSize = true;
            this.lblregiao.Location = new System.Drawing.Point(351, 309);
            this.lblregiao.Name = "lblregiao";
            this.lblregiao.Size = new System.Drawing.Size(44, 13);
            this.lblregiao.TabIndex = 12;
            this.lblregiao.Text = "Região:";
            // 
            // txtfinal
            // 
            this.txtfinal.Enabled = false;
            this.txtfinal.Location = new System.Drawing.Point(429, 256);
            this.txtfinal.Multiline = true;
            this.txtfinal.Name = "txtfinal";
            this.txtfinal.ReadOnly = true;
            this.txtfinal.Size = new System.Drawing.Size(100, 20);
            this.txtfinal.TabIndex = 13;
            this.txtfinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtfinal.TextChanged += new System.EventHandler(this.txtfinal_TextChanged);
            // 
            // txtregiao
            // 
            this.txtregiao.Enabled = false;
            this.txtregiao.Location = new System.Drawing.Point(429, 302);
            this.txtregiao.Name = "txtregiao";
            this.txtregiao.ReadOnly = true;
            this.txtregiao.Size = new System.Drawing.Size(100, 20);
            this.txtregiao.TabIndex = 14;
            this.txtregiao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmdescontoprodutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtregiao);
            this.Controls.Add(this.txtfinal);
            this.Controls.Add(this.lblregiao);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtalert);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtdesconto);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.lbldesconto);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.lblpreco);
            this.Name = "frmdescontoprodutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpreco;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lbldesconto;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtdesconto;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.TextBox txtalert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblregiao;
        private System.Windows.Forms.TextBox txtfinal;
        private System.Windows.Forms.TextBox txtregiao;
    }
}