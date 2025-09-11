namespace ProjetoPizzariaCidade
{
    partial class Pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedido));
            this.btnNovo = new System.Windows.Forms.Button();
            this.cmbCarros = new System.Windows.Forms.ComboBox();
            this.lblValorCarro = new System.Windows.Forms.Label();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.grpOpicionais = new System.Windows.Forms.GroupBox();
            this.chkPortaMalas = new System.Windows.Forms.CheckBox();
            this.chkCapa = new System.Windows.Forms.CheckBox();
            this.chkTapete = new System.Windows.Forms.CheckBox();
            this.chkCarregador = new System.Windows.Forms.CheckBox();
            this.chkSensor = new System.Windows.Forms.CheckBox();
            this.chkCamera = new System.Windows.Forms.CheckBox();
            this.txtValorCarro = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblValorPagar = new System.Windows.Forms.Label();
            this.lblValorOpicionais = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtValorAcessorios = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtValorPagar = new System.Windows.Forms.TextBox();
            this.lblCompra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.grpOpicionais.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(861, 550);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(102, 54);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // cmbCarros
            // 
            this.cmbCarros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCarros.ForeColor = System.Drawing.Color.Black;
            this.cmbCarros.FormattingEnabled = true;
            this.cmbCarros.Location = new System.Drawing.Point(64, 182);
            this.cmbCarros.Name = "cmbCarros";
            this.cmbCarros.Size = new System.Drawing.Size(349, 28);
            this.cmbCarros.TabIndex = 7;
            this.cmbCarros.Text = "TIPO DE CARRO";
            this.cmbCarros.SelectedIndexChanged += new System.EventHandler(this.cmbCarros_SelectedIndexChanged);
            // 
            // lblValorCarro
            // 
            this.lblValorCarro.AutoSize = true;
            this.lblValorCarro.BackColor = System.Drawing.Color.Transparent;
            this.lblValorCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCarro.ForeColor = System.Drawing.Color.White;
            this.lblValorCarro.Location = new System.Drawing.Point(536, 104);
            this.lblValorCarro.Name = "lblValorCarro";
            this.lblValorCarro.Size = new System.Drawing.Size(168, 20);
            this.lblValorCarro.TabIndex = 2;
            this.lblValorCarro.Text = "VALOR DO CARRO";
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(525, 375);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(630, 160);
            this.dgvPedido.TabIndex = 3;
            this.dgvPedido.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // grpOpicionais
            // 
            this.grpOpicionais.BackColor = System.Drawing.Color.Transparent;
            this.grpOpicionais.Controls.Add(this.chkPortaMalas);
            this.grpOpicionais.Controls.Add(this.chkCapa);
            this.grpOpicionais.Controls.Add(this.chkTapete);
            this.grpOpicionais.Controls.Add(this.chkCarregador);
            this.grpOpicionais.Controls.Add(this.chkSensor);
            this.grpOpicionais.Controls.Add(this.chkCamera);
            this.grpOpicionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOpicionais.ForeColor = System.Drawing.Color.White;
            this.grpOpicionais.Location = new System.Drawing.Point(30, 316);
            this.grpOpicionais.Name = "grpOpicionais";
            this.grpOpicionais.Size = new System.Drawing.Size(416, 209);
            this.grpOpicionais.TabIndex = 4;
            this.grpOpicionais.TabStop = false;
            this.grpOpicionais.Text = "ACESSÓRIOS";
            this.grpOpicionais.Enter += new System.EventHandler(this.grpOpicionais_Enter);
            // 
            // chkPortaMalas
            // 
            this.chkPortaMalas.AutoSize = true;
            this.chkPortaMalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPortaMalas.Location = new System.Drawing.Point(17, 171);
            this.chkPortaMalas.Name = "chkPortaMalas";
            this.chkPortaMalas.Size = new System.Drawing.Size(397, 24);
            this.chkPortaMalas.TabIndex = 53123;
            this.chkPortaMalas.Text = "Organizador de porta-malas dobrável à prova d\'água";
            this.chkPortaMalas.UseVisualStyleBackColor = true;
            // 
            // chkCapa
            // 
            this.chkCapa.AutoSize = true;
            this.chkCapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCapa.Location = new System.Drawing.Point(17, 144);
            this.chkCapa.Name = "chkCapa";
            this.chkCapa.Size = new System.Drawing.Size(268, 24);
            this.chkCapa.TabIndex = 42313;
            this.chkCapa.Text = "Capa de banco de couro universal";
            this.chkCapa.UseVisualStyleBackColor = true;
            // 
            // chkTapete
            // 
            this.chkTapete.AutoSize = true;
            this.chkTapete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTapete.Location = new System.Drawing.Point(17, 114);
            this.chkTapete.Name = "chkTapete";
            this.chkTapete.Size = new System.Drawing.Size(345, 24);
            this.chkTapete.TabIndex = 11;
            this.chkTapete.Text = "Tapete de borracha BRB Unicol para Stratus";
            this.chkTapete.UseVisualStyleBackColor = true;
            // 
            // chkCarregador
            // 
            this.chkCarregador.AutoSize = true;
            this.chkCarregador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCarregador.Location = new System.Drawing.Point(17, 88);
            this.chkCarregador.Name = "chkCarregador";
            this.chkCarregador.Size = new System.Drawing.Size(378, 24);
            this.chkCarregador.TabIndex = 10;
            this.chkCarregador.Text = "Carregador de carro USB-A/USB-C 30W Essager";
            this.chkCarregador.UseVisualStyleBackColor = true;
            // 
            // chkSensor
            // 
            this.chkSensor.AutoSize = true;
            this.chkSensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSensor.Location = new System.Drawing.Point(17, 65);
            this.chkSensor.Name = "chkSensor";
            this.chkSensor.Size = new System.Drawing.Size(287, 24);
            this.chkSensor.TabIndex = 9;
            this.chkSensor.Text = "Sensor de estacionamento Tay Tech";
            this.chkSensor.UseVisualStyleBackColor = true;
            // 
            // chkCamera
            // 
            this.chkCamera.AutoSize = true;
            this.chkCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCamera.Location = new System.Drawing.Point(17, 38);
            this.chkCamera.Name = "chkCamera";
            this.chkCamera.Size = new System.Drawing.Size(195, 24);
            this.chkCamera.TabIndex = 8;
            this.chkCamera.Text = "Câmera de ré Multilaser";
            this.chkCamera.UseVisualStyleBackColor = true;
            // 
            // txtValorCarro
            // 
            this.txtValorCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorCarro.ForeColor = System.Drawing.Color.Black;
            this.txtValorCarro.Location = new System.Drawing.Point(525, 134);
            this.txtValorCarro.Name = "txtValorCarro";
            this.txtValorCarro.ReadOnly = true;
            this.txtValorCarro.Size = new System.Drawing.Size(177, 26);
            this.txtValorCarro.TabIndex = 53213;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Lime;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(719, 550);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 54);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(580, 550);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(102, 54);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(1000, 550);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(102, 54);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblValorPagar
            // 
            this.lblValorPagar.AutoSize = true;
            this.lblValorPagar.BackColor = System.Drawing.Color.Transparent;
            this.lblValorPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPagar.ForeColor = System.Drawing.Color.White;
            this.lblValorPagar.Location = new System.Drawing.Point(990, 104);
            this.lblValorPagar.Name = "lblValorPagar";
            this.lblValorPagar.Size = new System.Drawing.Size(153, 20);
            this.lblValorPagar.TabIndex = 9;
            this.lblValorPagar.Text = "VALOR A PAGAR";
            // 
            // lblValorOpicionais
            // 
            this.lblValorOpicionais.AutoSize = true;
            this.lblValorOpicionais.BackColor = System.Drawing.Color.Transparent;
            this.lblValorOpicionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorOpicionais.ForeColor = System.Drawing.Color.White;
            this.lblValorOpicionais.Location = new System.Drawing.Point(726, 104);
            this.lblValorOpicionais.Name = "lblValorOpicionais";
            this.lblValorOpicionais.Size = new System.Drawing.Size(234, 20);
            this.lblValorOpicionais.TabIndex = 10;
            this.lblValorOpicionais.Text = "VALOR DOS ACESSORIOS";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(627, 331);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(77, 24);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Codigo";
            // 
            // txtValorAcessorios
            // 
            this.txtValorAcessorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorAcessorios.ForeColor = System.Drawing.Color.Black;
            this.txtValorAcessorios.Location = new System.Drawing.Point(753, 134);
            this.txtValorAcessorios.Name = "txtValorAcessorios";
            this.txtValorAcessorios.ReadOnly = true;
            this.txtValorAcessorios.Size = new System.Drawing.Size(177, 26);
            this.txtValorAcessorios.TabIndex = 123213;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.Black;
            this.txtCodigo.Location = new System.Drawing.Point(720, 328);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(87, 29);
            this.txtCodigo.TabIndex = 14;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.ForeColor = System.Drawing.Color.Black;
            this.txtPesquisar.Location = new System.Drawing.Point(942, 328);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(83, 29);
            this.txtPesquisar.TabIndex = 15;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.lblPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.ForeColor = System.Drawing.Color.White;
            this.lblPesquisar.Location = new System.Drawing.Point(834, 331);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(102, 24);
            this.lblPesquisar.TabIndex = 16;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPagar.ForeColor = System.Drawing.Color.Black;
            this.txtValorPagar.Location = new System.Drawing.Point(978, 134);
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.ReadOnly = true;
            this.txtValorPagar.Size = new System.Drawing.Size(177, 26);
            this.txtValorPagar.TabIndex = 133213;
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblCompra.Font = new System.Drawing.Font("Impact", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompra.ForeColor = System.Drawing.Color.White;
            this.lblCompra.Location = new System.Drawing.Point(99, 24);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(262, 53);
            this.lblCompra.TabIndex = 17;
            this.lblCompra.Text = "FAZER PEDIDO";
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoPizzariaCidade.Properties.Resources.ChatGPT_Image_10_de_set__de_2025__16_42_16__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.lblCompra);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtValorPagar);
            this.Controls.Add(this.txtValorAcessorios);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblValorOpicionais);
            this.Controls.Add(this.lblValorPagar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtValorCarro);
            this.Controls.Add(this.grpOpicionais);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.lblValorCarro);
            this.Controls.Add(this.cmbCarros);
            this.Controls.Add(this.btnNovo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.grpOpicionais.ResumeLayout(false);
            this.grpOpicionais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ComboBox cmbCarros;
        private System.Windows.Forms.Label lblValorCarro;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.GroupBox grpOpicionais;
        private System.Windows.Forms.CheckBox chkCamera;
        private System.Windows.Forms.TextBox txtValorCarro;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblValorPagar;
        private System.Windows.Forms.Label lblValorOpicionais;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtValorAcessorios;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.CheckBox chkTapete;
        private System.Windows.Forms.CheckBox chkCarregador;
        private System.Windows.Forms.CheckBox chkSensor;
        private System.Windows.Forms.CheckBox chkPortaMalas;
        private System.Windows.Forms.CheckBox chkCapa;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txtValorPagar;
        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.Button btnSalvar;
    }
}