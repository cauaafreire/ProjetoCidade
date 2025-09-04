using System;
using System.Windows.Forms;

namespace ProjetoPizzariaCidade
{
    public partial class Pedido : Form
    {
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
    }
}
