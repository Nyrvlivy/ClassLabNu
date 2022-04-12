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
            var cmd = Banco.Abrir(); // F9 - mostra opções + F5 -> gera break point
            if (cmd.Connection.State == ConnectionState.Open) 
            {
            Usuario usuario = new Usuario("Zé", "ze@ti.com","123456",new Nivel("Caixa","cx"));
            }

            Cliente cliente = new Cliente();

            //MessageBox.Show($"Olá, {usuario.Nome}!");
            //Text = "Sistema Comercial TI91 | " + usuario.Nome + " -- " + usuario.Nivel.Nome;
            // OBS.: Se colocar um nível específico, você pode determinar que só um determinado nível pode usar o formulário
            //MessageBox.Show("Olá, TI91!");
        }
    }
}
