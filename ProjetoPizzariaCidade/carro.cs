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
    public partial class carro : Form
    {
        public carro()
        {
            InitializeComponent();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("deseja sair?", "sair ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sair == DialogResult.No)
            {
                carro car = new carro();
                car.Show();
                this.Hide();
            }
            else
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("deseja Voltar?", "Voltar ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sair == DialogResult.No)
            {
                carro car = new carro();
                car.Show();
                this.Hide();
            }
            else
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
        }
    }
}
