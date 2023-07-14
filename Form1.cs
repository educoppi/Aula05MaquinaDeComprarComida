using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula05MaquinaDeComprarComida
{
    public partial class Form1 : Form
    {

        public void limpar()
        {
            txtValor.Clear();
            lblPreco.Text = "";
            lblProduto.Text = "";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void produto1_Click(object sender, EventArgs e)
        {
            lblProduto.Text = "Salgadinho";
            lblPreco.Text = "5,00";

        }

        private void produto2_Click(object sender, EventArgs e)
        {
            lblProduto.Text = "Bolinho";
            lblPreco.Text = "4,50";
        }

        private void produto3_Click(object sender, EventArgs e)
        {
            lblProduto.Text = "Bolacha";
            lblPreco.Text = "4,00";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnComprar_Click_1(object sender, EventArgs e)
        {
            if (txtValor.Text == "")
            {
                MessageBox.Show("Insira o valor!");
                limpar();
                return;
            }

            double preco = double.Parse(lblPreco.Text);
            double valor = double.Parse(txtValor.Text);

            if (valor >= preco)
            {
                MessageBox.Show($"{lblProduto.Text} comprado com sucesso");
                limpar();
                return;
            }
            else
            {
                MessageBox.Show("Valor inserido insuficiente para efetuar a compra!");
                limpar();
                return;
            }
        }
    }
}
