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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e) // Para acessar o formulário Usuário
        {
            //Criar Instancia do Formulario Usuário
            FormUsuario formUsuario = new FormUsuario();

            //Tornado formUsuario Filho do contaner FormPrincipal
            //formUsuario.MdiParent = this;

            //Exibe o Formulario de Cliente no Formprincipal
            formUsuario.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e) // Para acessar o formulário Cliente
        {
            // Criar Instancia do Formulario Cliente
            FormCliente formCliente = new FormCliente();

            // Tornado formCliente Filho do contaner FormPrincipal
            //formCliente.MdiParent = this;
            //FormPrincipal formPrincipal = new FormPrincipal();
            //formPrincipal.Hide();

            // Exibe o Formulario de Cliente no Formprincipal
            formCliente.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e) // Para acessar o formulário Produto
        {

            //Criar Instancia do Formulario Produto
            FormProduto formProduto = new FormProduto();

            //Tornado formProduto Filho do contaner FormPrincipal
            //formProduto.MdiParent = this;

            //Exibe o Formulario de Cliente no Formprincipal
            formProduto.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
