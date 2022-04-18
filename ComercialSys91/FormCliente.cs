using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // não precisa, só usar como Var
using System.Windows.Forms;
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
        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvClientes.Rows.Clear();
            List<Cliente> listaDeClientes = Cliente.Listar();
            int cont = listaDeClientes.Count;
            foreach (Cliente cliente in listaDeClientes)
            {
                dgvClientes.Rows.Add();
                dgvClientes.Rows[cont].Cells[0].Value = cliente.Id.ToString();
                dgvClientes.Rows[cont].Cells[1].Value = cliente.Nome.ToString();
                dgvClientes.Rows[cont].Cells[2].Value = cliente.Cpf.ToString();
                dgvClientes.Rows[cont].Cells[3].Value = cliente.Email.ToString();
                dgvClientes.Rows[cont].Cells[4].Value = cliente.Ativo;
                cont++;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (btnBuscar.Text == "...")
            {
                txtId.ReadOnly = false;
                txtId.Focus();
                btnBuscar.Text = "&Buscar";
            }
            else
            {
                Cliente cliente = Cliente.ConsultarPorId(int.Parse(txtId.Text));
                if (cliente.Id > 0)
                {
                    label6.Enabled = true;
                    label7.Enabled = true;
                    txtNome.Text = cliente.Nome.ToString();
                    txtCpf.Text = cliente.Cpf.ToString();
                    txtEmail.Text = cliente.Email.ToString();
                    dtpDataCad.Value = cliente.DataCad.Date;
                    chkAtivo.Checked = cliente.Ativo;

                    btnBuscar.Text = "...";
                    txtId.ReadOnly=true;
                    label6.Enabled = false;
                    label7.Enabled = false;
                    btnAlterar.Enabled=true;
                    txtCpf.ReadOnly=true;
                }
                else
                {
                    MessageBox.Show("Código de cliente não encontrado!");
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            if(cliente.Alterar(int.Parse(txtId.Text),txtNome.Text,txtEmail.Text))
            {
                MessageBox.Show("Cliente alterado com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha na alteração");
            }
        }
    }
}
