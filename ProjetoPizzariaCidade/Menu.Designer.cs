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
            this.btnSairMenu = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnFazerPedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSairMenu
            // 
            this.btnSairMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairMenu.Location = new System.Drawing.Point(759, 536);
            this.btnSairMenu.Name = "btnSairMenu";
            this.btnSairMenu.Size = new System.Drawing.Size(213, 72);
            this.btnSairMenu.TabIndex = 3;
            this.btnSairMenu.Text = "Sair";
            this.btnSairMenu.UseVisualStyleBackColor = true;
            this.btnSairMenu.Click += new System.EventHandler(this.btnSairMenu_Click);
            // 
            // btnVer
            // 
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Location = new System.Drawing.Point(483, 536);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(213, 72);
            this.btnVer.TabIndex = 4;
            this.btnVer.Text = "Ver carros";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnFazerPedido
            // 
            this.btnFazerPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFazerPedido.Location = new System.Drawing.Point(205, 536);
            this.btnFazerPedido.Name = "btnFazerPedido";
            this.btnFazerPedido.Size = new System.Drawing.Size(213, 72);
            this.btnFazerPedido.TabIndex = 5;
            this.btnFazerPedido.Text = "Fazer pedido";
            this.btnFazerPedido.UseVisualStyleBackColor = true;
            this.btnFazerPedido.Click += new System.EventHandler(this.btnFazerPedido_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = global::ProjetoPizzariaCidade.Properties.Resources.ChatGPT_Image_10_de_set__de_2025__16_23_03__2_;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.btnFazerPedido);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnSairMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSairMenu;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnFazerPedido;
    }
}