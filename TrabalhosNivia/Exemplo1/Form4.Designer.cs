namespace Exemplo1
{
    partial class frmcidadania
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
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblcidadania = new System.Windows.Forms.Label();
            this.txtcidadania = new System.Windows.Forms.TextBox();
            this.lbllingua = new System.Windows.Forms.Label();
            this.txtlingua = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(97, 99);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(240, 13);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Insira o código que corresponde a sua cidadânia:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(373, 96);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 1;
            this.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblcidadania
            // 
            this.lblcidadania.AutoSize = true;
            this.lblcidadania.Location = new System.Drawing.Point(280, 149);
            this.lblcidadania.Name = "lblcidadania";
            this.lblcidadania.Size = new System.Drawing.Size(57, 13);
            this.lblcidadania.TabIndex = 2;
            this.lblcidadania.Text = "Cidadânia:";
            // 
            // txtcidadania
            // 
            this.txtcidadania.Enabled = false;
            this.txtcidadania.Location = new System.Drawing.Point(373, 146);
            this.txtcidadania.Name = "txtcidadania";
            this.txtcidadania.ReadOnly = true;
            this.txtcidadania.Size = new System.Drawing.Size(100, 20);
            this.txtcidadania.TabIndex = 3;
            this.txtcidadania.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbllingua
            // 
            this.lbllingua.AutoSize = true;
            this.lbllingua.Location = new System.Drawing.Point(189, 205);
            this.lbllingua.Name = "lbllingua";
            this.lbllingua.Size = new System.Drawing.Size(148, 13);
            this.lbllingua.TabIndex = 4;
            this.lbllingua.Text = "Língua nativa desse cidadão:";
            // 
            // txtlingua
            // 
            this.txtlingua.Enabled = false;
            this.txtlingua.Location = new System.Drawing.Point(377, 205);
            this.txtlingua.Name = "txtlingua";
            this.txtlingua.ReadOnly = true;
            this.txtlingua.Size = new System.Drawing.Size(100, 20);
            this.txtlingua.TabIndex = 5;
            this.txtlingua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(330, 272);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(93, 37);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(465, 272);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(93, 37);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(671, 376);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmcidadania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtlingua);
            this.Controls.Add(this.lbllingua);
            this.Controls.Add(this.txtcidadania);
            this.Controls.Add(this.lblcidadania);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblcodigo);
            this.Name = "frmcidadania";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cidadania";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblcidadania;
        private System.Windows.Forms.TextBox txtcidadania;
        private System.Windows.Forms.Label lbllingua;
        private System.Windows.Forms.TextBox txtlingua;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}