using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ClassLabNu
{
    public class Cliente
    {
        // Atributos
        private int id;
        private string nome;
        private string cpf;
        private string email;
        private DateTime dataCad;
        private bool ativo;

        // Propriedades
        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Cpf { get { return cpf; } set { cpf = value; } }
        public string Email { get { return email; } set { email = value; } }
        public DateTime DataCad { get { return dataCad; } set { dataCad = value; } }
        public bool Ativo { get { return ativo; } set { ativo = value; } }


        // Construtores
        public Cliente()
        {
        }

        public Cliente(int id)
        {
            Id = id;
        }
        public Cliente(int id, string nome, string email)
        {
            Id = id;
            Nome = nome;
            Email = email;
        }

        public Cliente(string nome, string cpf, string email)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            // DataCad = DateTime.Now;
            // ativo = true
        }

        public Cliente(int id, string nome, string cpf, string email, DateTime dataCad, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            DataCad = dataCad;
            Ativo = ativo;
        }

        // Métodos da Classe
        public void Inserir() // chamadas de banco e grava o registro

        {
            MySqlCommand cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_inserir";
            cmd.Parameters.AddWithValue("_nome", Nome);
            cmd.Parameters.AddWithValue("_cpf", Cpf);
            cmd.Parameters.AddWithValue("_email", Email);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
            // OBS.: Lembrar de fazer tratamento quando da erro de duplicação
        }
        public bool Alterar(int _id, string _nome, string _email)
        {
            bool resultado = false;
            try
            {
                MySqlCommand cmd = Banco.Abrir();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                // Recebe o nome da procedure
                cmd.CommandText = "sp_cliente_alterar";
                // Recebe os parâmetros da procedure - Lá do MySQL
                cmd.Parameters.Add("_id", MySqlDbType.Int32).Value = _id;
                // USA-SE ESSE^^ de forma mais técnica e é necessário saber exatamente o tipo de valor do parametro
                cmd.Parameters.Add("_nome", MySqlDbType.VarChar).Value = _nome;
                cmd.Parameters.Add("_email", MySqlDbType.VarChar).Value = _email;
                // LEMBRETE: o valor remete ao nome do campo construído da PROCEDURE, logo é VarChar e não String!!
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

            }
            return resultado;
        }
        public static Cliente ConsultarPorId(int _id)
        {
            Cliente cliente = new Cliente();
            // conecta banco e realiza consulta por Id do cliente
            MySqlCommand cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from clientes where idCli =" + _id;
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) // dr data reader
            {
                cliente.Id = Convert.ToInt32(dr["idCli"]);
                cliente.Nome = dr["nome"].ToString();
                cliente.Cpf = dr.GetString(2);
                cliente.Email = dr.GetString(3);
                cliente.dataCad = dr.GetDateTime(4);
                cliente.Ativo = dr.GetBoolean(5);
            }
            return cliente;
        }
        public static Cliente ConsultarPorCpf(int _cpf)
        {
            Cliente cliente = new Cliente();
            // conecta banco e realiza consulta por CPF do cliente
            MySqlCommand cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from clientes where cpf =" + _cpf;
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) // dr data reader
            {
                cliente.Id = Convert.ToInt32(dr["Cpf"]);
                cliente.Nome = dr["Nome"].ToString();
                cliente.Cpf = dr.GetString(2);
                cliente.Email = dr.GetString(3);
                cliente.dataCad = dr.GetDateTime(4);
                cliente.Ativo = dr.GetBoolean(5);
            }
            return cliente;
        }
        public static List<Cliente> ListarNome()
        {
            List<Cliente> clientes = new List<Cliente>();
            MySqlCommand cmd = Banco.Abrir(); // Objeto de conexão MySQL
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from clientes where ativo = 1 order by 2"; // Colocar em ordem na coluna 2 (alfabética)
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clientes.Add(new Cliente(
                    dr.GetInt32(0),         // IDCLI
                    dr.GetString(1),        // NOME
                    dr.GetString(2),        // CPF
                    dr.GetString(3),        // EMAIL
                    dr.GetDateTime(4),      // DATACAD
                    dr.GetBoolean(5)        // ATIVO
                    ));
            }
            return clientes;
        }

        public static List<Cliente> ListarId()
        {
            List<Cliente> clientes = new List<Cliente>();
            MySqlCommand cmd = Banco.Abrir(); // Objeto de conexão MySQL
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from clientes where ativo = 1 order by 1"; // Colocar em ordem na coluna 1 (ID)
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clientes.Add(new Cliente(
                    dr.GetInt32(0),         // IDCLI
                    dr.GetString(1),        // NOME
                    dr.GetString(2),        // CPF
                    dr.GetString(3),        // EMAIL
                    dr.GetDateTime(4),      // DATACAD
                    dr.GetBoolean(5)        // ATIVO
                    ));
            }
            return clientes;
        }

        public void Desativado(int _id)
        {
            MySqlCommand cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            // Text direto, pois Command.Type usamos quando criamos procedure
            cmd.CommandText = "update clientes set ativo = 0 where idCli = " + _id;
            cmd.ExecuteReader();
            cmd.Connection.Close();
        }



    }
}
