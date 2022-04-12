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
    public partial class Form1 : Form
    {
        public Form1()
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
            c.Inserir();
            txtId.Text = c.Id.ToString(); // Fazer tratamento em Clientes para erros de duplicação
        }
    }
}
