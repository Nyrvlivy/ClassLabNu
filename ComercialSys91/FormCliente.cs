using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // não precisa, só usar como Var
using ClassLabNu;

namespace ComercialSys91
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show($"Olá, {usuario.Nome}!");
            //Text = "Sistema Comercial TI91 | " + usuario.Nome + " -- " + usuario.Nivel.Nome;
            // OBS.: Se colocar um nível específico, você pode determinar que só um determinado nível pode usar o formulário
            //MessageBox.Show("Olá, TI91!");
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente(txtNome.Text, txtCpf.Text, txtEmail.Text);

            try
            {
                c.Inserir();
                MessageBox.Show("Cliente gravado com sucesso!");


            }
            catch (MySql.Data.MySqlClient.MySqlException errinho)
            {
                MessageBox.Show($"Olá, amiguinho! Ooops, deu {errinho.Message}");
                //("Falha na inserção. Não foi possível gravar dados corretamente!");
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lstClientes.Items.Clear();
            List<Cliente> listaDeClientes = Cliente.Listar();
            foreach (Cliente cliente in listaDeClientes)
            {
                lstClientes.Items.Add(cliente.Id + " | " + cliente.Nome + " - " + cliente.Cpf);
            }
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
