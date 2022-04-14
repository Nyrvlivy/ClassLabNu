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
            Usuario c = new Usuario(txtNome.Text, txtEmail.Text, txtSenha.Text, new Nivel(txtNivel.Text));

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

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNivel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenhaNov_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lstUsuarios.Items.Clear();
            List<Usuario> listaDeUsuarios = Usuario.Listar();
            foreach (Usuario usuario in listaDeUsuarios)
            {
                lstUsuarios.Items.Add(usuario.Id + "  |  Nome: " + usuario.Nome + "     |  Email: " + usuario.Email + "   |  Senha: " + usuario.Senha +
                                      "   |  Nivel: " + usuario.Nivel);
            }
        }
    }
}
