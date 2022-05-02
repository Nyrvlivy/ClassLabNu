using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialSys91
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }


        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e) // Para acessar o formulário Usuário
        {
            FormUsuario formUsuario = new FormUsuario();
            formUsuario.MdiParent = this;
            formUsuario.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e) // Para acessar o formulário Cliente
        {
            FormCliente formCliente = new FormCliente();
            formCliente.MdiParent = this;
            formCliente.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e) // Para acessar o formulário Produto
        {
            FormProduto formProduto = new FormProduto();
            formProduto.MdiParent = this;
            formProduto.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNovoPedido formNovoPedido = new FormNovoPedido();
            formNovoPedido.MdiParent = this;
            formNovoPedido.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            //formLogin.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void alterarToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e) { }
    }
}
