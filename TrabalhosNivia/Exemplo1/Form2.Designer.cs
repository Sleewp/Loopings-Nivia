namespace Exemplo1
{
    partial class frmmenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.projetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descontoDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.somaDeNúmerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cidadâniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loopingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projetosToolStripMenuItem,
            this.sToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // projetosToolStripMenuItem
            // 
            this.projetosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descontoDeProdutosToolStripMenuItem,
            this.somaDeNúmerosToolStripMenuItem,
            this.cidadâniaToolStripMenuItem,
            this.loopingsToolStripMenuItem});
            this.projetosToolStripMenuItem.Name = "projetosToolStripMenuItem";
            this.projetosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.projetosToolStripMenuItem.Text = "Projetos";
            this.projetosToolStripMenuItem.Click += new System.EventHandler(this.projetosToolStripMenuItem_Click);
            // 
            // descontoDeProdutosToolStripMenuItem
            // 
            this.descontoDeProdutosToolStripMenuItem.Name = "descontoDeProdutosToolStripMenuItem";
            this.descontoDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.descontoDeProdutosToolStripMenuItem.Text = "Desconto de produtos";
            this.descontoDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.descontoDeProdutosToolStripMenuItem_Click);
            // 
            // somaDeNúmerosToolStripMenuItem
            // 
            this.somaDeNúmerosToolStripMenuItem.Name = "somaDeNúmerosToolStripMenuItem";
            this.somaDeNúmerosToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.somaDeNúmerosToolStripMenuItem.Text = "Soma de números";
            this.somaDeNúmerosToolStripMenuItem.Click += new System.EventHandler(this.somaDeNúmerosToolStripMenuItem_Click);
            // 
            // cidadâniaToolStripMenuItem
            // 
            this.cidadâniaToolStripMenuItem.Name = "cidadâniaToolStripMenuItem";
            this.cidadâniaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.cidadâniaToolStripMenuItem.Text = "Cidadânia";
            this.cidadâniaToolStripMenuItem.Click += new System.EventHandler(this.cidadâniaToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sToolStripMenuItem.Text = "Sair";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // loopingsToolStripMenuItem
            // 
            this.loopingsToolStripMenuItem.Name = "loopingsToolStripMenuItem";
            this.loopingsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.loopingsToolStripMenuItem.Text = "Loopings";
            this.loopingsToolStripMenuItem.Click += new System.EventHandler(this.loopingsToolStripMenuItem_Click);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem projetosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descontoDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem somaDeNúmerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cidadâniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loopingsToolStripMenuItem;
    }
}