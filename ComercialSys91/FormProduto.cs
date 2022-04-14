using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using ClassLabNu;

namespace ComercialSys91
{
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Produto c = new Produto(txtDescricao.Text, Convert.ToDouble(txtUnidade.Text), txtCodBar.Text, Convert.ToDouble(txtValor.Text), Convert.ToDouble(txtDesconto.Text));

            try
            {
                c.Inserir();
                MessageBox.Show("Produto gravado com sucesso!");


            }
            catch (MySql.Data.MySqlClient.MySqlException errinho)
            {
                MessageBox.Show($"Falha na inserção do Produto! Error: {errinho.Message}");
                // Mensagem de erro evidenciando a falha.
            }
        }

        

        private void lstProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCodBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUnidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lstProdutos.Items.Clear();
            List<Produto> listaDeProdutos = Produto.Listar();
            foreach (Produto produto in listaDeProdutos)
            {
                lstProdutos.Items.Add(produto.Id + "  |  Descrição: " + produto.Descricao + "     |  Unidade: " + produto.Unidade + "   |  Código de Barras: " + produto.CodBar +
                                      "   |  Valor: R$" + produto.Valor + "   |  Desconto: " + produto.Desconto + "%");
            }
        }
    }
}
