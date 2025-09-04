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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.visualizarCarrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fazerPedidoToolStripMenuItem});
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
            this.visualizarCarrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verMaisToolStripMenuItem});
            this.visualizarCarrosToolStripMenuItem.Name = "visualizarCarrosToolStripMenuItem";
            this.visualizarCarrosToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.visualizarCarrosToolStripMenuItem.Text = "Visualizar carros";
            this.visualizarCarrosToolStripMenuItem.Click += new System.EventHandler(this.visualizarCarrosToolStripMenuItem_Click);
            // 
            // verMaisToolStripMenuItem
            // 
            this.verMaisToolStripMenuItem.Name = "verMaisToolStripMenuItem";
            this.verMaisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verMaisToolStripMenuItem.Text = "Ver mais";
            this.verMaisToolStripMenuItem.Click += new System.EventHandler(this.verMaisToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
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
    }
}