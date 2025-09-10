using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPizzariaCidade
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void fazerPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedido ped = new Pedido ();
            ped.Show();
            this.Hide();
        }



        private void verMaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carro car = new carro ();
            car.Show(); 
            this.Hide();
        }
    }
}
