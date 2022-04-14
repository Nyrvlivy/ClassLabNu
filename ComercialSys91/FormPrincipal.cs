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

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar Instancia do Formulario Cliente
            FormCliente formCliente = new FormCliente();

            // Tornado frmCliente Filho do contaner FormPrincipal
            formCliente.MdiParent = this;

            // Exibe o Formulario de Cliente no Formprincipal
            formCliente.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Criar Instancia do Formulario Produto
            FormProduto formProduto = new FormProduto();

            //Tornado frmCliente Filho do contaner FormPrincipal
            formProduto.MdiParent = this;

            //Exibe o Formulario de Cliente no Formprincipal
            formProduto.Show();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Criar Instancia do Formulario Usuário
            FormUsuario formUsuario = new FormUsuario();

            //Tornado frmCliente Filho do contaner FormPrincipal
            formUsuario.MdiParent = this;

            //Exibe o Formulario de Cliente no Formprincipal
            formUsuario.Show();
        }

    }
}
