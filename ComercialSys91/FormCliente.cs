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
            txtNome.Focus();
            cmBoxUf.Enabled = false;

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente(txtNome.Text, txtCpf.Text, txtEmail.Text);

            try
            {
                c.Inserir();
                MessageBox.Show("Cliente gravado com sucesso!");
                btnlimpar_Click(sender, e); //sender = ação de enviar; e = evento (clique)


            }
            catch (MySql.Data.MySqlClient.MySqlException error)
            {
                MessageBox.Show($"Olá, amiguinho! Ooops, deu erro: {error.Message}");
                //("Falha na inserção. Não foi possível gravar dados corretamente!");
            }
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvClientes.Rows.Clear();
            chBoxNome.Checked = true;
            List<Cliente> listaDeClientes = Cliente.ListarNome();
            int cont = 0;
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

                txtId.Text = "";
                txtCpf.Text = "";
                txtNome.Text = "";
                txtEmail.Text = "";

                txtCpf.ReadOnly = false;
                btnlimpar.Enabled = false;
                btnDesativar.Enabled = false;

                label6.Enabled = false;
                label7.Enabled = false;
            }
            else
            {
                Cliente cliente = Cliente.ConsultarPorId(int.Parse(txtId.Text));
                if (cliente.Id > 0)
                {
                    txtId.Focus();
                    txtId.Enabled = true;

                    txtNome.Text = cliente.Nome.ToString();
                    txtCpf.Text = cliente.Cpf.ToString();
                    txtEmail.Text = cliente.Email.ToString();

                    dtpDataCad.Value = cliente.DataCad.Date;
                    chkAtivo.Checked = cliente.Ativo;

                    txtCpf.ReadOnly = true;
                    btnAlterar.Enabled = true;
                    btnInserir.Enabled = false;
                    btnlimpar.Enabled = true;
                    btnDesativar.Enabled = true;
                    btnAlterarCep.Enabled = true;
                    btnAlterarTel.Enabled = true;

                    label6.Enabled = true;
                    label7.Enabled = true;

                    btnBuscar.Enabled = false;


                }
                else
                {
                    MessageBox.Show("Código de cliente não encontrado!");
                    btnBuscar.Text = "...";

                    txtId.Focus();
                    txtId.Text = "";

                    txtId.ReadOnly = true;
                    txtCpf.ReadOnly = false;

                    label6.Enabled = false;
                    label7.Enabled = false;
                    chkAtivo.Enabled = false;

                    btnBuscar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnDesativar.Enabled = false;

                }
            }
        }
        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtNome.Focus();

            txtId.Text = "";
            txtNome.Text = "";
            txtCpf.Text = "";
            txtEmail.Text = "";

            btnBuscar.Text = "...";
            label6.Enabled = false;
            label7.Enabled = false;
            txtId.ReadOnly = true;
            txtCpf.ReadOnly = false;
            txtCpf.Enabled = true;
            btnBuscar.Enabled = true;
            btnInserir.Enabled = true;
            btnAlterar.Enabled = false;
        }

        // CRIAR LOG DE AUDITORIA
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            if (cliente.Alterar(int.Parse(txtId.Text), txtNome.Text, txtEmail.Text))
            {
                MessageBox.Show("Cliente alterado com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha na alteração");
                btnBuscar.Text = "...";
                txtId.Text = "";
                txtCpf.Text = "";
                txtNome.Text = "";
                txtEmail.Text = "";

                txtId.ReadOnly = true;
                label6.Enabled = false;
                label7.Enabled = false;
                chkAtivo.Enabled = false;
                txtCpf.ReadOnly = false;
                btnAlterar.Enabled = false;
                btnDesativar.Enabled = false;
            }
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void grbInserir_Enter(object sender, EventArgs e)
        {

        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chBoxId_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxId.Checked == true)
            {
                chBoxNome.Checked = false;
                chBoxId.Checked = true;

                dgvClientes.Rows.Clear();
                List<Cliente> listaDeClientes = Cliente.ListarId();
                int cont = 0;
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
            else
            {
                chBoxNome.Checked = true;
            }
        }

        private void chBoxNome_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxNome.Checked == true)
            {
                chBoxId.Checked = false;
                chBoxNome.Checked = true;

                dgvClientes.Rows.Clear();
                List<Cliente> listaDeClientes = Cliente.ListarNome();
                int cont = 0;
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
            else
            {
                chBoxId.Checked = true;
            }
        }

        private void mskTxtCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void btnBuscarCep_Click(object sender, EventArgs e)
        {
            if (btnBuscar.Text == "&Busca Online")
            {
                try
                {
                    btnBuscar.Text = "&Buscar Novamente";

                    BuscaCep buscacep = new BuscaCep(mskTxtCep.Text);
                    txtLogradouro.Text = buscacep.TipomaisLogradouro;
                    txtBairro.Text = buscacep.Bairro;
                    txtCidade.Text = buscacep.Cidade;
                    txtUf.Text = buscacep.UF;

                    txtNumero.Text = "";
                    txtComplemento.Text = "";

                    txtLogradouro.ReadOnly = true;
                    txtBairro.ReadOnly = true;
                    txtCidade.ReadOnly = true;
                    txtUf.ReadOnly = true;



                }
                catch (Exception erro)
                {
                    MessageBox.Show($"Ops... " + erro.Message);
                }
            }
        }

        private void txtUf_TextChanged(object sender, EventArgs e)
        {
            var indice = cmBoxUf.FindString(txtUf.Text);
            cmBoxEstado.SelectedIndex = indice;
            cmBoxUf.SelectedIndex = indice;
            txtNumero.Focus();


        }

        private void btnCadastroManual_Click(object sender, EventArgs e)
        {
            txtLogradouro.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            cmBoxUf.Enabled = false;
        }
    }
}

