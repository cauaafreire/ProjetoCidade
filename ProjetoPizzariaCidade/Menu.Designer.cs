namespace ProjetoPizzariaCidade
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fazerPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarCarrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumBlue;
            this.menuStrip1.BackgroundImage = global::ProjetoPizzariaCidade.Properties.Resources.ChatGPT_Image_10_de_set__de_2025__16_23_03__2_;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.visualizarCarrosToolStripMenuItem,
            this.outrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fazerPedidoToolStripMenuItem});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(66, 20);
            this.toolStripMenuItem1.Text = "Comprar";
            // 
            // fazerPedidoToolStripMenuItem
            // 
            this.fazerPedidoToolStripMenuItem.Name = "fazerPedidoToolStripMenuItem";
            this.fazerPedidoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fazerPedidoToolStripMenuItem.Text = "Fazer pedido";
            this.fazerPedidoToolStripMenuItem.Click += new System.EventHandler(this.fazerPedidoToolStripMenuItem_Click);
            // 
            // visualizarCarrosToolStripMenuItem
            // 
            this.visualizarCarrosToolStripMenuItem.BackColor = System.Drawing.Color.MediumBlue;
            this.visualizarCarrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verMaisToolStripMenuItem});
            this.visualizarCarrosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.visualizarCarrosToolStripMenuItem.Name = "visualizarCarrosToolStripMenuItem";
            this.visualizarCarrosToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.visualizarCarrosToolStripMenuItem.Text = "Visualizar carros";
            // 
            // verMaisToolStripMenuItem
            // 
            this.verMaisToolStripMenuItem.Name = "verMaisToolStripMenuItem";
            this.verMaisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verMaisToolStripMenuItem.Text = "Ver mais";
            this.verMaisToolStripMenuItem.Click += new System.EventHandler(this.verMaisToolStripMenuItem_Click);
            // 
            // outrosToolStripMenuItem
            // 
            this.outrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.outrosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.outrosToolStripMenuItem.Name = "outrosToolStripMenuItem";
            this.outrosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.outrosToolStripMenuItem.Text = "Outros";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = global::ProjetoPizzariaCidade.Properties.Resources.ChatGPT_Image_10_de_set__de_2025__16_23_03__2_;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fazerPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarCarrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}