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
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Usuario c = new Usuario(txtNomeUser.Text, txtEmailUser.Text, txtSenhaUser.Text, new Nivel(cmbNivel.Text));

            try
            {
                c.Inserir();
                MessageBox.Show("Usuario gravado com sucesso!");


            }
            catch (MySql.Data.MySqlClient.MySqlException errinho)
            {
                MessageBox.Show($"Falha na inserção do Usuário! Error: {errinho.Message}");
                // Mensagem de erro evidenciando a falha.
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e) { }
        private void txtEmail_TextChanged(object sender, EventArgs e) { }
        private void txtId_TextChanged(object sender, EventArgs e) { }
        private void txtSenha_TextChanged(object sender, EventArgs e) { }        
        private void txtSenhaNov_TextChanged(object sender, EventArgs e) { }
        private void label15_Click(object sender, EventArgs e) { }
    }
}
