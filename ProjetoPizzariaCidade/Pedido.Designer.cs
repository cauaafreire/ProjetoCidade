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
            this.txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.grpOpicionais.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(851, 571);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(85, 43);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // cmbCarros
            // 
            this.cmbCarros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCarros.ForeColor = System.Drawing.Color.White;
            this.cmbCarros.FormattingEnabled = true;
            this.cmbCarros.Location = new System.Drawing.Point(26, 107);
            this.cmbCarros.Name = "cmbCarros";
            this.cmbCarros.Size = new System.Drawing.Size(349, 28);
            this.cmbCarros.TabIndex = 1;
            this.cmbCarros.Text = "TIPO DE CARRO";
            this.cmbCarros.SelectedIndexChanged += new System.EventHandler(this.cmbCarros_SelectedIndexChanged);
            // 
            // lblValorCarro
            // 
            this.lblValorCarro.AutoSize = true;
            this.lblValorCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCarro.ForeColor = System.Drawing.Color.White;
            this.lblValorCarro.Location = new System.Drawing.Point(794, 38);
            this.lblValorCarro.Name = "lblValorCarro";
            this.lblValorCarro.Size = new System.Drawing.Size(168, 20);
            this.lblValorCarro.TabIndex = 2;
            this.lblValorCarro.Text = "VALOR DO CARRO";
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(539, 348);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(604, 186);
            this.dgvPedido.TabIndex = 3;
            this.dgvPedido.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // grpOpicionais
            // 
            this.grpOpicionais.Controls.Add(this.chkPortaMalas);
            this.grpOpicionais.Controls.Add(this.chkCapa);
            this.grpOpicionais.Controls.Add(this.chkTapete);
            this.grpOpicionais.Controls.Add(this.chkCarregador);
            this.grpOpicionais.Controls.Add(this.chkSensor);
            this.grpOpicionais.Controls.Add(this.chkCamera);
            this.grpOpicionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOpicionais.ForeColor = System.Drawing.Color.White;
            this.grpOpicionais.Location = new System.Drawing.Point(26, 325);
            this.grpOpicionais.Name = "grpOpicionais";
            this.grpOpicionais.Size = new System.Drawing.Size(349, 209);
            this.grpOpicionais.TabIndex = 4;
            this.grpOpicionais.TabStop = false;
            this.grpOpicionais.Text = "ESCOLHA OS ACESSORIOS";
            this.grpOpicionais.Enter += new System.EventHandler(this.grpOpicionais_Enter);
            // 
            // chkPortaMalas
            // 
            this.chkPortaMalas.AutoSize = true;
            this.chkPortaMalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPortaMalas.Location = new System.Drawing.Point(17, 171);
            this.chkPortaMalas.Name = "chkPortaMalas";
            this.chkPortaMalas.Size = new System.Drawing.Size(397, 24);
            this.chkPortaMalas.TabIndex = 5;
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
            this.chkCapa.TabIndex = 4;
            this.chkCapa.Text = "Capa de banco de couro universal";
            this.chkCapa.UseVisualStyleBackColor = true;
            // 
            // chkTapete
            // 
            this.chkTapete.AutoSize = true;
            this.chkTapete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTapete.Location = new System.Drawing.Point(17, 118);
            this.chkTapete.Name = "chkTapete";
            this.chkTapete.Size = new System.Drawing.Size(345, 24);
            this.chkTapete.TabIndex = 3;
            this.chkTapete.Text = "Tapete de borracha BRB Unicol para Stratus";
            this.chkTapete.UseVisualStyleBackColor = true;
            // 
            // chkCarregador
            // 
            this.chkCarregador.AutoSize = true;
            this.chkCarregador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCarregador.Location = new System.Drawing.Point(17, 91);
            this.chkCarregador.Name = "chkCarregador";
            this.chkCarregador.Size = new System.Drawing.Size(378, 24);
            this.chkCarregador.TabIndex = 2;
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
            this.chkSensor.TabIndex = 1;
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
            this.chkCamera.TabIndex = 0;
            this.chkCamera.Text = "Câmera de ré Multilaser";
            this.chkCamera.UseVisualStyleBackColor = true;
            // 
            // txtValorCarro
            // 
            this.txtValorCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorCarro.ForeColor = System.Drawing.Color.White;
            this.txtValorCarro.Location = new System.Drawing.Point(773, 70);
            this.txtValorCarro.Name = "txtValorCarro";
            this.txtValorCarro.Size = new System.Drawing.Size(211, 26);
            this.txtValorCarro.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(720, 571);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(87, 43);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(575, 571);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(95, 43);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(970, 571);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(88, 43);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblValorPagar
            // 
            this.lblValorPagar.AutoSize = true;
            this.lblValorPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPagar.ForeColor = System.Drawing.Color.White;
            this.lblValorPagar.Location = new System.Drawing.Point(801, 180);
            this.lblValorPagar.Name = "lblValorPagar";
            this.lblValorPagar.Size = new System.Drawing.Size(153, 20);
            this.lblValorPagar.TabIndex = 9;
            this.lblValorPagar.Text = "VALOR A PAGAR";
            // 
            // lblValorOpicionais
            // 
            this.lblValorOpicionais.AutoSize = true;
            this.lblValorOpicionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorOpicionais.ForeColor = System.Drawing.Color.White;
            this.lblValorOpicionais.Location = new System.Drawing.Point(760, 108);
            this.lblValorOpicionais.Name = "lblValorOpicionais";
            this.lblValorOpicionais.Size = new System.Drawing.Size(234, 20);
            this.lblValorOpicionais.TabIndex = 10;
            this.lblValorOpicionais.Text = "VALOR DOS ACESSORIOS";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(676, 294);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(65, 20);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Codigo";
            // 
            // txtValorAcessorios
            // 
            this.txtValorAcessorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorAcessorios.ForeColor = System.Drawing.Color.White;
            this.txtValorAcessorios.Location = new System.Drawing.Point(773, 141);
            this.txtValorAcessorios.Name = "txtValorAcessorios";
            this.txtValorAcessorios.Size = new System.Drawing.Size(211, 26);
            this.txtValorAcessorios.TabIndex = 12;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(773, 291);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(44, 26);
            this.txtCodigo.TabIndex = 14;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.ForeColor = System.Drawing.Color.White;
            this.txtPesquisar.Location = new System.Drawing.Point(1002, 291);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(83, 26);
            this.txtPesquisar.TabIndex = 15;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.ForeColor = System.Drawing.Color.White;
            this.lblPesquisar.Location = new System.Drawing.Point(866, 294);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(88, 20);
            this.lblPesquisar.TabIndex = 16;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // txt
            // 
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.ForeColor = System.Drawing.Color.White;
            this.txt.Location = new System.Drawing.Point(773, 221);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(211, 26);
            this.txt.TabIndex = 13;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoPizzariaCidade.Properties.Resources.ChatGPT_Image_10_de_set__de_2025__16_23_03__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txt);
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
        private System.Windows.Forms.Button btnSalvar;
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
        private System.Windows.Forms.TextBox txt;
    }
}