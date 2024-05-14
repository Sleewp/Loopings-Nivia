namespace Exemplo1
{
    partial class Form5
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
            this.lblnum = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnwhile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btndowhile = new System.Windows.Forms.Button();
            this.btnfor = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(141, 66);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(89, 13);
            this.lblnum.TabIndex = 0;
            this.lblnum.Text = "Digite um número";
            this.lblnum.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(270, 63);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 1;
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(270, 118);
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ReadOnly = true;
            this.txtresultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtresultado.Size = new System.Drawing.Size(100, 76);
            this.txtresultado.TabIndex = 2;
            // 
            // btnwhile
            // 
            this.btnwhile.Location = new System.Drawing.Point(119, 220);
            this.btnwhile.Name = "btnwhile";
            this.btnwhile.Size = new System.Drawing.Size(77, 39);
            this.btnwhile.TabIndex = 3;
            this.btnwhile.Text = "while";
            this.btnwhile.UseVisualStyleBackColor = true;
            this.btnwhile.Click += new System.EventHandler(this.btnwhile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Resultado";
            // 
            // btndowhile
            // 
            this.btndowhile.Location = new System.Drawing.Point(261, 220);
            this.btndowhile.Name = "btndowhile";
            this.btndowhile.Size = new System.Drawing.Size(80, 39);
            this.btndowhile.TabIndex = 5;
            this.btndowhile.Text = "do....while";
            this.btndowhile.UseVisualStyleBackColor = true;
            this.btndowhile.Click += new System.EventHandler(this.btndowhile_Click);
            // 
            // btnfor
            // 
            this.btnfor.Location = new System.Drawing.Point(415, 220);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(75, 39);
            this.btnfor.TabIndex = 6;
            this.btnfor.Text = "for";
            this.btnfor.UseVisualStyleBackColor = true;
            this.btnfor.Click += new System.EventHandler(this.btnfor_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(632, 371);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(95, 40);
            this.btnvoltar.TabIndex = 7;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(261, 304);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(80, 37);
            this.btnlimpar.TabIndex = 8;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnfor);
            this.Controls.Add(this.btndowhile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnwhile);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lblnum);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnwhile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndowhile;
        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimpar;
    }
}