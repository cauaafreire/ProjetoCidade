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
            this.btnNovo = new System.Windows.Forms.Button();
            this.cmbCarros = new System.Windows.Forms.ComboBox();
            this.lblValorCarro = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpOpicionais = new System.Windows.Forms.GroupBox();
            this.chkCamera = new System.Windows.Forms.CheckBox();
            this.txtValorCarro = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblValorPagar = new System.Windows.Forms.Label();
            this.lblValorOpicionais = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtValorAcessorios = new System.Windows.Forms.TextBox();
            this.txtValorPagar = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.chkSensor = new System.Windows.Forms.CheckBox();
            this.chkCarregador = new System.Windows.Forms.CheckBox();
            this.chkTapete = new System.Windows.Forms.CheckBox();
            this.chkPortaMalas = new System.Windows.Forms.CheckBox();
            this.chkCapa = new System.Windows.Forms.CheckBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpOpicionais.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(912, 490);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 46);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // cmbCarros
            // 
            this.cmbCarros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCarros.FormattingEnabled = true;
            this.cmbCarros.Location = new System.Drawing.Point(67, 78);
            this.cmbCarros.Name = "cmbCarros";
            this.cmbCarros.Size = new System.Drawing.Size(310, 24);
            this.cmbCarros.TabIndex = 1;
            this.cmbCarros.Text = "TIPO DE CARRO";
            // 
            // lblValorCarro
            // 
            this.lblValorCarro.AutoSize = true;
            this.lblValorCarro.Location = new System.Drawing.Point(679, 78);
            this.lblValorCarro.Name = "lblValorCarro";
            this.lblValorCarro.Size = new System.Drawing.Size(103, 13);
            this.lblValorCarro.TabIndex = 2;
            this.lblValorCarro.Text = "VALOR DO CARRO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(582, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(616, 174);
            this.dataGridView1.TabIndex = 3;
            // 
            // grpOpicionais
            // 
            this.grpOpicionais.Controls.Add(this.chkPortaMalas);
            this.grpOpicionais.Controls.Add(this.chkCapa);
            this.grpOpicionais.Controls.Add(this.chkTapete);
            this.grpOpicionais.Controls.Add(this.chkCarregador);
            this.grpOpicionais.Controls.Add(this.chkSensor);
            this.grpOpicionais.Controls.Add(this.chkCamera);
            this.grpOpicionais.Location = new System.Drawing.Point(67, 296);
            this.grpOpicionais.Name = "grpOpicionais";
            this.grpOpicionais.Size = new System.Drawing.Size(384, 231);
            this.grpOpicionais.TabIndex = 4;
            this.grpOpicionais.TabStop = false;
            this.grpOpicionais.Text = "ESCOLHA OS ACESSORIOS";
            this.grpOpicionais.Enter += new System.EventHandler(this.grpOpicionais_Enter);
            // 
            // chkCamera
            // 
            this.chkCamera.AutoSize = true;
            this.chkCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCamera.Location = new System.Drawing.Point(17, 38);
            this.chkCamera.Name = "chkCamera";
            this.chkCamera.Size = new System.Drawing.Size(177, 21);
            this.chkCamera.TabIndex = 0;
            this.chkCamera.Text = "Câmera de ré Multilaser";
            this.chkCamera.UseVisualStyleBackColor = true;
            // 
            // txtValorCarro
            // 
            this.txtValorCarro.Location = new System.Drawing.Point(672, 104);
            this.txtValorCarro.Name = "txtValorCarro";
            this.txtValorCarro.Size = new System.Drawing.Size(117, 20);
            this.txtValorCarro.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(768, 490);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 46);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(609, 490);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 46);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(1061, 490);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 46);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // lblValorPagar
            // 
            this.lblValorPagar.AutoSize = true;
            this.lblValorPagar.Location = new System.Drawing.Point(996, 78);
            this.lblValorPagar.Name = "lblValorPagar";
            this.lblValorPagar.Size = new System.Drawing.Size(93, 13);
            this.lblValorPagar.TabIndex = 9;
            this.lblValorPagar.Text = "VALOR A PAGAR";
            // 
            // lblValorOpicionais
            // 
            this.lblValorOpicionais.AutoSize = true;
            this.lblValorOpicionais.Location = new System.Drawing.Point(811, 78);
            this.lblValorOpicionais.Name = "lblValorOpicionais";
            this.lblValorOpicionais.Size = new System.Drawing.Size(141, 13);
            this.lblValorOpicionais.TabIndex = 10;
            this.lblValorOpicionais.Text = "VALOR DOS ACESSORIOS";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(660, 239);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Codigo";
            // 
            // txtValorAcessorios
            // 
            this.txtValorAcessorios.Location = new System.Drawing.Point(812, 104);
            this.txtValorAcessorios.Name = "txtValorAcessorios";
            this.txtValorAcessorios.Size = new System.Drawing.Size(140, 20);
            this.txtValorAcessorios.TabIndex = 12;
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.Location = new System.Drawing.Point(981, 104);
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.Size = new System.Drawing.Size(117, 20);
            this.txtValorPagar.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(710, 236);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(117, 20);
            this.textBox4.TabIndex = 14;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(951, 236);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(117, 20);
            this.txtPesquisar.TabIndex = 15;
            // 
            // chkSensor
            // 
            this.chkSensor.AutoSize = true;
            this.chkSensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSensor.Location = new System.Drawing.Point(17, 65);
            this.chkSensor.Name = "chkSensor";
            this.chkSensor.Size = new System.Drawing.Size(260, 21);
            this.chkSensor.TabIndex = 1;
            this.chkSensor.Text = "Sensor de estacionamento Tay Tech";
            this.chkSensor.UseVisualStyleBackColor = true;
            // 
            // chkCarregador
            // 
            this.chkCarregador.AutoSize = true;
            this.chkCarregador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCarregador.Location = new System.Drawing.Point(17, 91);
            this.chkCarregador.Name = "chkCarregador";
            this.chkCarregador.Size = new System.Drawing.Size(337, 21);
            this.chkCarregador.TabIndex = 2;
            this.chkCarregador.Text = "Carregador de carro USB-A/USB-C 30W Essager";
            this.chkCarregador.UseVisualStyleBackColor = true;
            // 
            // chkTapete
            // 
            this.chkTapete.AutoSize = true;
            this.chkTapete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTapete.Location = new System.Drawing.Point(17, 118);
            this.chkTapete.Name = "chkTapete";
            this.chkTapete.Size = new System.Drawing.Size(310, 21);
            this.chkTapete.TabIndex = 3;
            this.chkTapete.Text = "Tapete de borracha BRB Unicol para Stratus";
            this.chkTapete.UseVisualStyleBackColor = true;
            // 
            // chkPortaMalas
            // 
            this.chkPortaMalas.AutoSize = true;
            this.chkPortaMalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPortaMalas.Location = new System.Drawing.Point(17, 171);
            this.chkPortaMalas.Name = "chkPortaMalas";
            this.chkPortaMalas.Size = new System.Drawing.Size(363, 21);
            this.chkPortaMalas.TabIndex = 5;
            this.chkPortaMalas.Text = "Organizador de porta-malas dobrável à prova d\'água";
            this.chkPortaMalas.UseVisualStyleBackColor = true;
            // 
            // chkCapa
            // 
            this.chkCapa.AutoSize = true;
            this.chkCapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCapa.Location = new System.Drawing.Point(17, 144);
            this.chkCapa.Name = "chkCapa";
            this.chkCapa.Size = new System.Drawing.Size(244, 21);
            this.chkCapa.TabIndex = 4;
            this.chkCapa.Text = "Capa de banco de couro universal";
            this.chkCapa.UseVisualStyleBackColor = true;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(874, 239);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisar.TabIndex = 16;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 600);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.textBox4);
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblValorCarro);
            this.Controls.Add(this.cmbCarros);
            this.Controls.Add(this.btnNovo);
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpOpicionais.ResumeLayout(false);
            this.grpOpicionais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ComboBox cmbCarros;
        private System.Windows.Forms.Label lblValorCarro;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.TextBox txtValorPagar;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.CheckBox chkTapete;
        private System.Windows.Forms.CheckBox chkCarregador;
        private System.Windows.Forms.CheckBox chkSensor;
        private System.Windows.Forms.CheckBox chkPortaMalas;
        private System.Windows.Forms.CheckBox chkCapa;
        private System.Windows.Forms.Label lblPesquisar;
    }
}