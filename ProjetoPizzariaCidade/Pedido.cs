using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoPizzariaCidade
{
    public partial class Pedido : Form
    {
        //INSTANCIANDO A CLASSE DE CONEXAO
        Conexao con = new Conexao();
        public Pedido()
        {
            InitializeComponent();
        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            cmbCarros.Items.Add("Sedã");
            cmbCarros.Items.Add("Toyota Corolla GLi (2025) – R$ 158.490");
            cmbCarros.Items.Add("Chevrolet Cruze — R$ 140.000");
            cmbCarros.Items.Add("Volkswagen Jetta GLI — R$ 247.290");
            cmbCarros.Items.Add("Honda Civic Hatch Type R — R$ 429.990");
            cmbCarros.Items.Add("SUVs");
            cmbCarros.Items.Add("Fiat Pulse — R$ 98.990");
            cmbCarros.Items.Add("Citroën Basalt — R$ 101.490");
            cmbCarros.Items.Add("Volkswagen Tera — R$ 105.890");
            cmbCarros.Items.Add("Renault Kardian — R$ 112.690");
            cmbCarros.Items.Add("Esportivos");
            cmbCarros.Items.Add("Mazda MX-5 (Miata) — R$ 220.000");
            cmbCarros.Items.Add("BMW M240i — R$ 380.000");
            cmbCarros.Items.Add("Ford Mustang EcoBoost — R$ 310.000");
            cmbCarros.Items.Add("Subaru BRZ — R$ 250.000");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //DECLARANDO AS VARIAVEIS 
            Double valorCarro = 0, valorAcessorios = 0, valorTotal = 0;

            if (cmbCarros.SelectedIndex == 0)
            {
                valorCarro = 158490;
            }
            else if (cmbCarros.SelectedIndex == 1)
            {
                valorCarro = 140000;
            }
            else if (cmbCarros.SelectedIndex == 2)
            {
                valorCarro = 247290;
            }
            else if (cmbCarros.SelectedIndex == 3)
            {
                valorCarro = 429990;
            }
            else if (cmbCarros.SelectedIndex == 4)
            {
                valorCarro = 98990;
            }
            else if (cmbCarros.SelectedIndex == 5)
            {
                valorCarro = 101490;
            }
            else if (cmbCarros.SelectedIndex == 6)
            {
                valorCarro = 105890;
            }
            else if (cmbCarros.SelectedIndex == 7)
            {
                valorCarro = 112690;
            }
            else if (cmbCarros.SelectedIndex == 8)
            {
                valorCarro = 220000;
            }
            else if (cmbCarros.SelectedIndex == 9)
            {
                valorCarro = 390000;
            }
            else if (cmbCarros.SelectedIndex == 10)
            {
                valorCarro = 310000;
            }
            else if (cmbCarros.SelectedIndex == 11)
            {
                valorCarro = 250000;
            }
            else
            {
            }
            if (chkCamera.Checked == true)
            {
                valorAcessorios = valorAcessorios + 89.90;
            }
            if (chkSensor.Checked == true)
            {
                valorAcessorios = valorAcessorios + 45.00;
            }
            if (chkCarregador.Checked == true)
            {
                valorAcessorios = valorAcessorios + 16.86;
            }
            if (chkTapete.Checked == true)
            {
                valorAcessorios = valorAcessorios + 113.40;
            }
            if (chkCapa.Checked == true)
            {
                valorAcessorios = valorAcessorios + 120.00;
            }
            if (chkPortaMalas.Checked == true)
            {
                valorAcessorios = valorAcessorios + 41.78;
            }
            else {
            }
            valorTotal = valorCarro + valorAcessorios;
            txtValorCarro.Text = Convert.ToString(valorCarro);
            txtValorAcessorios.Text = Convert.ToString(valorAcessorios);
            txtValorPagar.Text = Convert.ToString(valorTotal);
        }

        private void grpOpicionais_Enter(object sender, EventArgs e)
        {
            cmbCarros.SelectedIndex = -1;
            txtValorCarro.Clear();
            txtValorAcessorios.Clear();
            chkCamera.Checked = false;
            chkTapete.Checked = false;
            chkCapa.Checked = false;
            chkCarregador.Checked = false;
            chkPortaMalas.Checked = false;
            chkSensor.Checked = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            cmbCarros.SelectedIndex = 0;

            txtValorCarro.Clear();
            txtValorAcessorios.Clear();
            txtValorPagar.Clear();

            txtPesquisar.Clear();

            chkCamera.Checked = false;
            chkTapete.Checked = false;
            chkCapa.Checked = false;
            chkCarregador.Checked = false;
            chkPortaMalas.Checked = false;
            chkSensor.Checked = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //verifica os campos 
            if (txtValorCarro.Text == "")
            {
                MessageBox.Show("Campo Obrigatorio");
                txtValorCarro.Focus();
            }
            else if (txtValorAcessorios.Text == "")
            {
                MessageBox.Show("Campo Obrigatorio");
                txtValorAcessorios.Focus();
            }
            else if (txtValorPagar.Text == "")
            {
                MessageBox.Show("Campo Obrigatorio");
                txtValorPagar.Focus();
            }
            else
            {
                //inserindo dados no banco de dados
                string sql = "insert into tbPedido(tipoCarro,valorCarro,valorAcessorios,valorTotal) values(@carro,@vcarro,@vacessorios,@total)";
                MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                cmd.Parameters.Add("@carro", MySqlDbType.Text).Value = cmbCarros.Text;
                cmd.Parameters.Add("@vcarro", MySqlDbType.Text).Value = txtValorCarro.Text;
                cmd.Parameters.Add("@vacessorios", MySqlDbType.Text).Value = txtValorAcessorios;
                cmd.Parameters.Add("@total", MySqlDbType.Text).Value = txtValorPagar.Text;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados cadstrados com sucesso");
                cmbCarros.Text = "";
                txtValorCarro.Text = "";
                txtValorAcessorios.Text = "";
                txtValorPagar.Text = "";
                cmbCarros.Focus();
                con.DesConnectarBD();

            }

        }

        private void cmbCarros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCarros.SelectedIndex == 0)
            {
                MessageBox.Show("Campo invalido");
                cmbCarros.SelectedIndex = -1;
            }
            else if (cmbCarros.SelectedIndex == 4)
            {
                MessageBox.Show("Campo invalido");
                cmbCarros.SelectedIndex = -1;
            }
            else if (cmbCarros.SelectedIndex == 9)
            {
                MessageBox.Show("Campo invalido");
                cmbCarros.SelectedIndex = -1;
            }
            else
            {

            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CarregarPedidos();

        }

        //Metodo que vai carregar informaçoes no data grid
        public void CarregarPedidos()
        {
            try
            {
                txtCodigo.Text = dgvPedido.SelectedRows[0].Cells[0].Value.ToString();
                cmbCarros.Text = dgvPedido.SelectedRows[0].Cells[1].Value.ToString();
                txtValorCarro.Text = dgvPedido.SelectedRows[0].Cells[2].Value.ToString();
                txtValorAcessorios.Text = dgvPedido.SelectedRows[0].Cells[3].Value.ToString();
                txtValorPagar.Text = dgvPedido.SelectedRows[0].Cells[4].Value.ToString();   
            }
            catch (Exception erro) 
            {
                MessageBox.Show("Erro ao clicar" + erro);
            }
    }
}
