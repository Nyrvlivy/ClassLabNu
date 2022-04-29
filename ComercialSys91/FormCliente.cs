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
            cmbTipoTel.SelectedIndex = 0;

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


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (btnBuscar.Text == "...")
            {
                txtId.ReadOnly = false;
                txtId.Focus();
                btnBuscar.Text = "&Buscar";

                txtId.Clear();
                txtCpf.Clear();
                txtNome.Clear();
                txtEmail.Clear();

                txtCpf.ReadOnly = false;
                btnlimpar.Enabled = false;
                btnDesativar.Enabled = false;

                label6.Enabled = false;
                label7.Enabled = false;
            }
            else
            {
                try
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
                    }
                }
                catch
                {
                    {
                        MessageBox.Show("Digite um código válido!");
                        btnBuscar.Text = "...";

                        txtId.Focus();
                        txtId.Clear();

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
        }
        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtNome.Focus();

            txtId.Clear();
            txtNome.Clear();
            txtCpf.Clear();
            txtEmail.Clear();

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
                txtId.Clear();
                txtCpf.Clear();
                txtNome.Clear();
                txtEmail.Clear();

                txtId.ReadOnly = true;
                label6.Enabled = false;
                label7.Enabled = false;
                chkAtivo.Enabled = false;
                txtCpf.ReadOnly = false;
                btnAlterar.Enabled = false;
                btnDesativar.Enabled = false;
            }
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

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            {
                DialogResult alertaExclusao = MessageBox.Show($"Os dados do Cliente " + txtId.Text + " serão excluídos permanentemente! Desega continuar?", "Excluir Aluno...",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);

                if (alertaExclusao == DialogResult.Yes && txtId.Text != string.Empty)
                {
                    var comm = Banco.Abrir();
                    comm.CommandText = "delete from clientes where id = " + txtId.Text;
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Aluno excluído com sucesso!");
                }

            }

        }

        private void btnBuscarOnline_Click(object sender, EventArgs e)
        {
            // Botões 
            btnBuscar.Enabled = false;
            btnBuscarNovamente.Visible = true;
            btnBuscarNovamente.Enabled = true;

            // Caixas de Texto
            lbCep.Enabled = true;
            lbLogradouro.Enabled = true;
            lbNumero.Enabled = true;
            lbBairro.Enabled = true;
            lbCidade.Enabled = true;
            lbEstado.Enabled = true;
            lbUf.Enabled = true;
            lbComplemento.Enabled = true;
            lbTipo.Enabled = true;

            mskTxtCep.Enabled = true;
            mskTxtCep.ReadOnly = false;

            // Campos para editar
            txtNumero.Clear();
            txtComplemento.Clear();
        }
        private void btnBuscarNovamente_Click(object sender, EventArgs e)
        {
            if (btnBuscarNovamente.Text == "&Buscar")
                try
                {
                    btnBuscarNovamente.Text = "&Buscar Novamente";

                    // Busca CEP no banco
                    BuscaCep buscacep = new BuscaCep(mskTxtCep.Text);
                    txtLogradouro.Text = buscacep.TipomaisLogradouro;
                    txtBairro.Text = buscacep.Bairro;
                    txtCidade.Text = buscacep.Cidade;
                    txtUf.Text = buscacep.UF;

                    // Campos que recebem o CEP
                    txtLogradouro.ReadOnly = true;
                    txtBairro.ReadOnly = true;
                    txtCidade.ReadOnly = true;
                    txtUf.ReadOnly = true;

                    // Campos Alteráveis
                    txtNumero.ReadOnly = false;
                    txtNumero.Enabled = true;
                    txtComplemento.ReadOnly = false;
                    txtComplemento.Enabled = true;
                    cmbTipoTel.Enabled = true;

                    // Campos para editar
                    txtNumero.Clear();
                    txtComplemento.Clear();
                }
                catch { }
            else
            {
                // Busca CEP no banco
                BuscaCep buscacep = new BuscaCep(mskTxtCep.Text);
                txtLogradouro.Text = buscacep.TipomaisLogradouro;
                txtBairro.Text = buscacep.Bairro;
                txtCidade.Text = buscacep.Cidade;
                txtUf.Text = buscacep.UF;

                // Campos que recebem o CEP
                txtLogradouro.ReadOnly = true;
                txtBairro.ReadOnly = true;
                txtCidade.ReadOnly = true;
                txtUf.ReadOnly = true;

                // Campos Alteráveis
                txtNumero.ReadOnly = false;
                txtNumero.Enabled = true;
                txtComplemento.ReadOnly = false;
                txtComplemento.Enabled = true;
                cmbTipoTel.Enabled = true;
                cmBoxEstado.SelectedItem = null;
                cmBoxUf.SelectedItem = null;
                txtComplemento.Clear();
                cmbTipoTel.SelectedIndex = 0;

                // Campos para editar
                txtNumero.Clear();
                txtComplemento.Clear();
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
            // Botões 
            btnBuscar.Enabled = true;
            btnBuscarNovamente.Visible = false;
            btnBuscarNovamente.Enabled = false;

            // Caixas de Texto
            lbCep.Enabled = true;
            lbLogradouro.Enabled = true;
            lbNumero.Enabled = true;
            lbBairro.Enabled = true;
            lbCidade.Enabled = true;
            lbEstado.Enabled = true;
            lbUf.Enabled = true;
            lbComplemento.Enabled = true;
            lbTipo.Enabled = true;

            mskTxtCep.Enabled = true;
            mskTxtCep.ReadOnly = false;

            // Enabled 

            mskTxtCep.Enabled = true;
            txtLogradouro.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            cmBoxEstado.Enabled = true;
            cmBoxUf.Enabled = false;
            txtComplemento.Enabled = true;
            cmbTipoTel.Enabled = true;

            // ReadOnly
            mskTxtCep.ReadOnly = false;
            txtLogradouro.ReadOnly = false;
            txtNumero.ReadOnly = false;
            txtBairro.ReadOnly = false;
            txtCidade.ReadOnly = false;
            txtComplemento.ReadOnly = false;

            // Campos para editar
            mskTxtCep.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            cmBoxEstado.SelectedItem = null;
            cmBoxUf.SelectedItem = null;
            txtComplemento.Clear();
            cmbTipoTel.SelectedIndex = 0;
        }
        private void cmBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cmBoxEstado.SelectedIndex;
            cmBoxUf.SelectedIndex = index;
        }

        private void label6_Click(object sender, EventArgs e) { }
        private void txtNome_TextChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void grbTelefones_Enter(object sender, EventArgs e) { }
        private void txtCpf_TextChanged(object sender, EventArgs e) { }
        private void mskTxtCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void grbInserir_Enter(object sender, EventArgs e) { }
        private void chkAtivo_CheckedChanged(object sender, EventArgs e) { }
        private void label11_Click(object sender, EventArgs e) { }
    }
}

